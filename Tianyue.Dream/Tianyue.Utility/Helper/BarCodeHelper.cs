﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tianyue.Utility.Helper
{

    /// <summary>
    /// 扫码输入钩子
    /// </summary>
    public class BarCodeHelper
    {
        public delegate void BardCodeDeletegate(BarCodes barCode);

        //定义成静态，这样不会抛出回收异常
        private static HookProc hookproc;
        private BarCodes barCode;

        private int hKeyboardHook;

        //string strBarCode = "";
        private readonly StringBuilder sbBarCode = new StringBuilder();
        public event BardCodeDeletegate BarCodeEvent;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern bool UnhookWindowsHookEx(int idHook);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("user32", EntryPoint = "GetKeyNameText")]
        private static extern int GetKeyNameText(int IParam, StringBuilder lpBuffer, int nSize);

        [DllImport("user32", EntryPoint = "GetKeyboardState")]
        private static extern int GetKeyboardState(byte[] pbKeyState);

        [DllImport("user32", EntryPoint = "ToAscii")]
        private static extern bool ToAscii(int VirtualKey, int ScanCode, byte[] lpKeySate, ref uint lpChar, int uFlags);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string name);

        private int KeyboardHookProc(int nCode, int wParam, IntPtr lParam)
        {
            if (nCode == 0)
            {
                var msg = (EventMsg)Marshal.PtrToStructure(lParam, typeof(EventMsg));
                if (wParam == 0x100) //WM_KEYDOWN=0x100 
                {
                    barCode.VirtKey = msg.message & 0xff; //虚拟吗
                    barCode.ScanCode = msg.paramL & 0xff; //扫描码
                    var strKeyName = new StringBuilder(225);
                    if (GetKeyNameText(barCode.ScanCode * 65536, strKeyName, 255) > 0)
                        barCode.KeyName = strKeyName.ToString().Trim(' ', '\0');
                    else
                        barCode.KeyName = "";
                    var kbArray = new byte[256];
                    uint uKey = 0;
                    GetKeyboardState(kbArray);


                    if (ToAscii(barCode.VirtKey, barCode.ScanCode, kbArray, ref uKey, 0))
                    {
                        barCode.Ascll = uKey;
                        barCode.Chr = Convert.ToChar(uKey);
                    }

                    var ts = DateTime.Now.Subtract(barCode.Time);

                    if (ts.TotalMilliseconds > 50)
                    {
                        //时间戳，大于50 毫秒表示手动输入
                        //strBarCode = barCode.Chr.ToString();
                        sbBarCode.Remove(0, sbBarCode.Length);
                        sbBarCode.Append(barCode.Chr.ToString());
                        barCode.OriginalChrs = " " + Convert.ToString(barCode.Chr);
                        barCode.OriginalAsciis = " " + Convert.ToString(barCode.Ascll);
                        barCode.OriginalBarCode = Convert.ToString(barCode.Chr);
                    }
                    else
                    {
                        sbBarCode.Append(barCode.Chr.ToString());
                        if ((msg.message & 0xff) == 13 && sbBarCode.Length > 3)
                        {
                            //回车
                            //barCode.BarCode = strBarCode;
                            barCode.BarCode = sbBarCode.ToString(); // barCode.OriginalBarCode;
                            barCode.IsValid = true;
                            sbBarCode.Remove(0, sbBarCode.Length);
                        }

                        //strBarCode += barCode.Chr.ToString();
                    }

                    barCode.Time = DateTime.Now;
                    try
                    {
                        if (BarCodeEvent != null && barCode.IsValid)
                        {
                            AsyncCallback callback = AsyncBack;
                            //object obj;
                            var delArray = BarCodeEvent.GetInvocationList();
                            //foreach (Delegate del in delArray)
                            foreach (BardCodeDeletegate del in delArray)
                                try
                                {
                                    //方法1
                                    //obj = del.DynamicInvoke(barCode);
                                    //方法2
                                    del.BeginInvoke(barCode, callback, del); //异步调用防止界面卡死
                                }
                                catch (Exception ex)
                                {
                                    throw ex;
                                }

                            //BarCodeEvent(barCode);//触发事件
                            barCode.BarCode = "";
                            barCode.OriginalChrs = "";
                            barCode.OriginalAsciis = "";
                            barCode.OriginalBarCode = "";
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        barCode.IsValid = false; //最后一定要 设置barCode无效
                        barCode.Time = DateTime.Now;
                    }
                }
            }

            return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
        }

        //异步返回方法
        public void AsyncBack(IAsyncResult ar)
        {
            var del = ar.AsyncState as BardCodeDeletegate;
            del.EndInvoke(ar);
        }

        //安装钩子
        public bool Start()
        {
            if (hKeyboardHook == 0)
            {
                hookproc = KeyboardHookProc;


                //GetModuleHandle 函数 替代 Marshal.GetHINSTANCE
                //防止在 framework4.0中 注册钩子不成功
                var modulePtr = GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName);

                //WH_KEYBOARD_LL=13
                //全局钩子 WH_KEYBOARD_LL
                //  hKeyboardHook = SetWindowsHookEx(13, hookproc, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);

                hKeyboardHook = SetWindowsHookEx(13, hookproc, modulePtr, 0);
            }

            return hKeyboardHook != 0;
        }

        //卸载钩子
        public bool Stop()
        {
            if (hKeyboardHook != 0) return UnhookWindowsHookEx(hKeyboardHook);
            return true;
        }


        public struct BarCodes
        {
            public int VirtKey; //虚拟吗
            public int ScanCode; //扫描码
            public string KeyName; //键名
            public uint Ascll; //Ascll
            public char Chr; //字符
            public string OriginalChrs; //原始 字符
            public string OriginalAsciis; //原始 ASCII


            public string OriginalBarCode; //原始数据条码

            public string BarCode; //条码信息 保存最终的条码
            public bool IsValid; //条码是否有效
            public DateTime Time; //扫描时间,
        }

        private struct EventMsg
        {
            public int message;
            public int paramL;
            public int paramH;
            public int Time;
            public int hwnd;
        }


        private delegate int HookProc(int nCode, int wParam, IntPtr lParam);
    }
}
