﻿#pragma checksum "..\..\..\CaseManipulation\ShowCompleteCase.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "62A6FFEEE78709C12604088DBEC8AB77"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Lawyer_Diary;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Lawyer_Diary {
    
    
    /// <summary>
    /// ShowCompleteCase
    /// </summary>
    public partial class ShowCompleteCase : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.MaskedTextBox txtSearchBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid completeCasesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrintCase;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpenCase;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteCase;
        
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
            System.Uri resourceLocater = new System.Uri("/Lawyer Diary;component/casemanipulation/showcompletecase.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
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
            
            #line 9 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
            ((Lawyer_Diary.ShowCompleteCase)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtSearchBox = ((Xceed.Wpf.Toolkit.MaskedTextBox)(target));
            
            #line 32 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
            this.txtSearchBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtSearchBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSearchBox = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
            this.btnSearchBox.Click += new System.Windows.RoutedEventHandler(this.btnSearchBox_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.completeCasesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 44 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
            this.completeCasesDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.completeCasesDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnPrintCase = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
            this.btnPrintCase.Click += new System.Windows.RoutedEventHandler(this.btnPrintCase_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnOpenCase = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
            this.btnOpenCase.Click += new System.Windows.RoutedEventHandler(this.btnOpenCase_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDeleteCase = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\CaseManipulation\ShowCompleteCase.xaml"
            this.btnDeleteCase.Click += new System.Windows.RoutedEventHandler(this.btnDeleteCase_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

