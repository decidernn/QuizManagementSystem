﻿#pragma checksum "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "75CFD358F133A7327251DBA983FCE8CB9E02BEAABF8ED33759591DCEA0B26FF5"
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
using QuizManagement.Teacher_UC;
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


namespace QuizManagement.Teacher_UC {
    
    
    /// <summary>
    /// UC_UpdateQuestion
    /// </summary>
    public partial class UC_UpdateQuestion : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboQuestion;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuestion;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOption1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOption2;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOption3;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOption4;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAnswer;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReset;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/QuizManagement;component/teacher_uc/uc_updatequestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
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
            this.comboQuestion = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
            this.comboQuestion.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboQuestion_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtQuestion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtOption1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtOption2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtOption3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtOption4 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtAnswer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnReset = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
            this.btnReset.Click += new System.Windows.RoutedEventHandler(this.btnReset_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Teacher_UC\UC_UpdateQuestion.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
