﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tianyue.Domain;
using Tianyue.Domain.Configuration;
using Tianyue.Domain.Enum;
using Tianyue.Facade;
using Tianyue.Utility.Extension;
using Tianyue.Utility.Helper;

namespace Tianyue.Dream.WPF.MainPage
{
    /// <summary>
    /// pgUser.xaml 的交互逻辑
    /// </summary>
    public partial class pgUserManagement : Page
    {
        public pgUserManagement()
        {
            InitializeComponent();
        }
        
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<RoleView> lstRole = GlobalFacade.ConfigurationFacade.GetAllRole().FindAll(r => r.Disable == false).ToList();
            lvRole.ItemsSource = null;
            lvRole.ItemsSource = lstRole;
            
            PageQuery_Click(null, null);
        }

        private User userEdit = null;

        private void PageQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                PageQuery_Click(null, null);
            }
        }

        private void PageQuery_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User userQuery = new User();
                userQuery.UserUniqueId = txtQueryUserUniqueId.Text;
                userQuery.UserName = txtQueryUserName.Text;

                List<UserView> lstUser = GlobalFacade.ConfigurationFacade.GetUserList(userQuery).ToList();

                dgQuery.ItemsSource = null;
                dgQuery.ItemsSource = lstUser;

            }
            catch (Exception ex)
            {
                //LogHelper.LogMsg("btnLogin_Click>>" + ex.Message, true);
            }

        }

        /// <summary>
        /// gridview的绑定列方法，用于隐藏一些列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_AutoGeneratedColumns(object sender, EventArgs e)
        {
            try
            {
                DataGrid dg = (DataGrid)sender;
                Hashtable htDataGridColumn = new Hashtable();
                UserView user = new UserView();

                Hashtable htAllProperty = ClassHelper.TraversePropertyType(user);
               
                foreach(DictionaryEntry property in htAllProperty)
                {
                    if (!property.Value.ToString().Contains("Guid"))
                    {
                        htDataGridColumn.Add(property.Key, "");
                    }
                }
                
                foreach (DataGridColumn c in dg.Columns)
                {
                    if (!htDataGridColumn.Contains(c.SortMemberPath))
                    {
                        c.Visibility = Visibility.Hidden;
                    }
                }
                //LanguageHelper.SetDataGridViewLanguage(dg);
            }
            catch (Exception ex)
            {
                //LogHelper.LogMsg(strClass + ".radGridView_AutoGeneratedColumns>>" + ex.Message, true);
            }
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.dgQuery.SelectedIndex == -1)
            {
                return;
            }

            UserView userSelect = dgQuery.Items[dgQuery.SelectedIndex] as UserView;

            if (userSelect == null)
            {
                return;
            }

            userEdit = new User();
            userEdit.UID = userSelect.UID;
            userEdit.UserName = userSelect.UserName;
            userEdit.UserUniqueId = userSelect.UserUniqueId;
            userEdit.UserType = userSelect.UserType;
            userEdit.Nickname = userSelect.Nickname;
            userEdit.Password = userSelect.Password;
            userEdit.EmailAddress = userSelect.EmailAddress;
            userEdit.PhoneNumber = userSelect.PhoneNumber;
            userEdit.Description = userSelect.Description;
            userEdit.CreatedUser = userSelect.CreatedUserGuid;
            userEdit.CreatedTime = userSelect.CreatedTime;
            userEdit.Disable = userSelect.Disable;

            //tbUser.SelectedItem = tbiEdit;

            txtUserNameEdit.Text = userEdit.UserName;
            txtUserUniqueIdEdit.Text = userEdit.UserUniqueId;
            txtUserTypeEdit.Text = userEdit.UserType;
            txtNicknameEdit.Text = userEdit.Nickname;
            txtPasswordEdit.Text = userEdit.Password.ToString();
            txtEmailAddressEdit.Text = userEdit.EmailAddress;
            txtPhoneNumberEdit.Text = userEdit.PhoneNumber;
            txtDescriptionEdit.Text = userEdit.Description;
            cbDisableEdit.IsChecked = userEdit.Disable;

            tbUser.SelectedItem = tbiEdit;
        }

        private void btnSubmitEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                userEdit = VerifyData(OperationType.Edit);

                if (userEdit == null)
                    return;

                bool blAddResult = GlobalFacade.ConfigurationFacade.UpdateSingleUser(userEdit);

            }
            catch (Exception excp)
            {

            }
        }

        private void btnCancelEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSubmitAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User userAdd = new User();
                userAdd = VerifyData(OperationType.Add);

                if (userAdd == null)
                    return;

                bool blAddResult = GlobalFacade.ConfigurationFacade.InsertSingleUser(userAdd);

            }
            catch(Exception excp)
            {

            }
        }

        private void btnCancelAdd_Click(object sender, RoutedEventArgs e)
        {

        }


        private User VerifyData(OperationType operationType)
        {
            User pageFunction = new User();
            if(operationType == OperationType.Add)
            {
                if(txtUserUniqueIdAdd.Text.IsNullOrEmptyOrWhiteSpace())
                {
                    return null;
                }
                if (txtUserNameAdd.Text.IsNullOrEmptyOrWhiteSpace())
                {
                    return null;
                }
                if (txtNicknameAdd.Text.IsNullOrEmptyOrWhiteSpace())
                {
                    return null;
                }
                if (txtPasswordAdd.Text.IsNullOrEmptyOrWhiteSpace())
                {
                    return null;
                }
                if (txtUserTypeAdd.Text.IsNullOrEmptyOrWhiteSpace())
                {
                    return null;
                }
                
                pageFunction.UID = Guid.NewGuid();
                pageFunction.UserName = txtUserNameAdd.Text;
                pageFunction.UserUniqueId = txtUserUniqueIdAdd.Text;
                pageFunction.Nickname = txtNicknameAdd.Text;
                pageFunction.Password = txtPasswordAdd.Text;
                pageFunction.EmailAddress = txtEmailAddressAdd.Text;
                pageFunction.PhoneNumber = txtPhoneNumberAdd.Text;
                pageFunction.UserType = txtUserTypeAdd.Text;
                pageFunction.Description = txtDescriptionAdd.Text;
                pageFunction.Disable = cbDisableAdd.IsChecked == null ? false : (bool)cbDisableAdd.IsChecked;
                pageFunction.CreatedUser = GlobalVariable.UserEntity.UID;
                pageFunction.CreatedTime = DateTime.Now;
            }
            else
            {
                if (userEdit == null)
                    return null;

                if (txtUserUniqueIdAdd.Text.IsNullOrEmptyOrWhiteSpace())
                {
                    return null;
                }
                if (txtUserNameAdd.Text.IsNullOrEmptyOrWhiteSpace())
                {
                    return null;
                }
                if (txtNicknameAdd.Text.IsNullOrEmptyOrWhiteSpace())
                {
                    return null;
                }
                if (txtPasswordAdd.Text.IsNullOrEmptyOrWhiteSpace())
                {
                    return null;
                }
                if (txtUserTypeAdd.Text.IsNullOrEmptyOrWhiteSpace())
                {
                    return null;
                }

                pageFunction.UserName = txtUserNameEdit.Text;
                pageFunction.UserUniqueId = txtUserUniqueIdEdit.Text;
                pageFunction.Nickname = txtNicknameEdit.Text;
                pageFunction.Password = txtPasswordEdit.Text;
                pageFunction.EmailAddress = txtEmailAddressEdit.Text;
                pageFunction.PhoneNumber = txtPhoneNumberEdit.Text;
                pageFunction.UserType = txtUserTypeEdit.Text;
                pageFunction.Description = txtDescriptionEdit.Text;
                pageFunction.Disable = cbDisableEdit.IsChecked == null ? false : (bool)cbDisableEdit.IsChecked;
                pageFunction.CreatedUser = userEdit.CreatedUser;
                pageFunction.CreatedTime = userEdit.CreatedTime;
                pageFunction.ModifiedUser = GlobalVariable.UserEntity.UID;
                pageFunction.ModifiedTime = DateTime.Now;

            }

            return pageFunction;

        }


        private void NumberTextbox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            try
            {
                if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) ||
                    (e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.Back ||
                     e.Key == Key.Left || e.Key == Key.Right)
                {
                    if (e.KeyboardDevice.Modifiers != ModifierKeys.None)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (e.Key != Key.Tab)
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //LogHelper.LogMsg(strClass + ".txtPackingQtyE_PreviewKeyDown>>" + ex.Message, true);
            }
        }

        private void txtUserInfo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                User userQuery = new User();
                userQuery.UserUniqueId = txtUserInfo.Text;
                userQuery.UserName = txtUserInfo.Text;
                userQuery.Nickname = txtUserInfo.Text;

                List<UserView> lstUser = GlobalFacade.ConfigurationFacade.GetUserList(userQuery).ToList();

                dgUserSet.ItemsSource = null;
                dgUserSet.ItemsSource = lstUser;

            }
            catch (Exception ex)
            {
                //LogHelper.LogMsg("btnLogin_Click>>" + ex.Message, true);
            }
        }

        private void txtUserInfo_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                User userQuery = new User();
                userQuery.UserUniqueId = txtUserInfo.Text;
                userQuery.UserName = txtUserInfo.Text;
                userQuery.Nickname = txtUserInfo.Text;

                List<UserView> lstUser = GlobalFacade.ConfigurationFacade.GetUserList(userQuery).ToList();
                
                dgUserSet.ItemsSource = null;
                dgUserSet.ItemsSource = lstUser;

            }
            catch (Exception ex)
            {
                //LogHelper.LogMsg("btnLogin_Click>>" + ex.Message, true);
            }
        }
        
    }
}
