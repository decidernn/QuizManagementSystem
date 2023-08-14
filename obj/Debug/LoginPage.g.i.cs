﻿#pragma checksum "..\..\LoginPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A40DDB3960F06F9AFD9ECF7D3571669E5EF3EFA99AB29C5AECEED041608F16F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using QuizManagement;
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


namespace QuizManagement {
    
    
    /// <summary>
    /// LoginPage
    /// </summary>
    public partial class LoginPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxSelectUser;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridTeacher;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsername;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxShowPassword;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock passwordTxtBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridStudent;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegStudent;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoginStudent;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsernameStudent;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPasswordStudent;
        
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
            System.Uri resourceLocater = new System.Uri("/QuizManagement;component/loginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginPage.xaml"
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
            this.comboBoxSelectUser = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\LoginPage.xaml"
            this.comboBoxSelectUser.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBoxSelectUser_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridTeacher = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.txtUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\LoginPage.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.btnLogin_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.checkBoxShowPassword = ((System.Windows.Controls.CheckBox)(target));
            
            #line 23 "..\..\LoginPage.xaml"
            this.checkBoxShowPassword.Unchecked += new System.Windows.RoutedEventHandler(this.checkBoxShowPassword_Unchecked);
            
            #line default
            #line hidden
            
            #line 23 "..\..\LoginPage.xaml"
            this.checkBoxShowPassword.Checked += new System.Windows.RoutedEventHandler(this.checkBoxShowPassword_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.passwordTxtBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.GridStudent = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.btnRegStudent = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\LoginPage.xaml"
            this.btnRegStudent.Click += new System.Windows.RoutedEventHandler(this.btnRegStudent_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnLoginStudent = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\LoginPage.xaml"
            this.btnLoginStudent.Click += new System.Windows.RoutedEventHandler(this.btnLoginStudent_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtUsernameStudent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.txtPasswordStudent = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

