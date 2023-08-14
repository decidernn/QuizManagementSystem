﻿#pragma checksum "..\..\TeacherPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D8E6751A27B07370E5116637C669C217E5963B7C75AFCBEBC106EE9B2F0FD754"
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
    /// TeacherPage
    /// </summary>
    public partial class TeacherPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\TeacherPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddNewQuestion;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\TeacherPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateQuestions;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\TeacherPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewDeleteQuestion;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\TeacherPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAllStudentResult;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\TeacherPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogOut;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\TeacherPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStudentAccs;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\TeacherPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\TeacherPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/QuizManagement;component/teacherpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TeacherPage.xaml"
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
            this.btnAddNewQuestion = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\TeacherPage.xaml"
            this.btnAddNewQuestion.Click += new System.Windows.RoutedEventHandler(this.btnAddNewQuestion_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnUpdateQuestions = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\TeacherPage.xaml"
            this.btnUpdateQuestions.Click += new System.Windows.RoutedEventHandler(this.btnUpdateQuestions_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnViewDeleteQuestion = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\TeacherPage.xaml"
            this.btnViewDeleteQuestion.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAllStudentResult = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\TeacherPage.xaml"
            this.btnAllStudentResult.Click += new System.Windows.RoutedEventHandler(this.btnAllStudentResult_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnLogOut = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\TeacherPage.xaml"
            this.btnLogOut.Click += new System.Windows.RoutedEventHandler(this.btnLogOut_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnStudentAccs = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\TeacherPage.xaml"
            this.btnStudentAccs.Click += new System.Windows.RoutedEventHandler(this.btnStudentAccs_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\TeacherPage.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

