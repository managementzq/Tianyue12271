﻿#pragma checksum "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C5FFBF3F21CC6F6C7D8818443252CDBF762C1072"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Tianyue.Wpf.Control;


namespace Tianyue.Wpf.Control {
    
    
    /// <summary>
    /// ModernCheckboxTree
    /// </summary>
    public partial class ModernCheckboxTree : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 1 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tianyue.Wpf.Control.ModernCheckboxTree uc;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView tvZsmTree;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuExpandAll;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuUnExpandAll;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuSelectAll;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuUnSelectAll;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tianyue.Wpf.Control;component/tianyuecontrol/moderncheckboxtree.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.uc = ((Tianyue.Wpf.Control.ModernCheckboxTree)(target));
            return;
            case 2:
            this.tvZsmTree = ((System.Windows.Controls.TreeView)(target));
            return;
            case 3:
            this.menuExpandAll = ((System.Windows.Controls.MenuItem)(target));
            
            #line 27 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
            this.menuExpandAll.Click += new System.Windows.RoutedEventHandler(this.menuExpandAll_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.menuUnExpandAll = ((System.Windows.Controls.MenuItem)(target));
            
            #line 33 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
            this.menuUnExpandAll.Click += new System.Windows.RoutedEventHandler(this.menuUnExpandAll_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.menuSelectAll = ((System.Windows.Controls.MenuItem)(target));
            
            #line 39 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
            this.menuSelectAll.Click += new System.Windows.RoutedEventHandler(this.menuSelectAll_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.menuUnSelectAll = ((System.Windows.Controls.MenuItem)(target));
            
            #line 45 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
            this.menuUnSelectAll.Click += new System.Windows.RoutedEventHandler(this.menuUnSelectAll_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 7:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseRightButtonDownEvent;
            
            #line 60 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.TreeViewItem_PreviewMouseRightButtonDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 8:
            
            #line 72 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.menuSelectChanged);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 83 "..\..\..\..\TianyueControl\ModernCheckboxTree.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.menuSelectAllChild_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

