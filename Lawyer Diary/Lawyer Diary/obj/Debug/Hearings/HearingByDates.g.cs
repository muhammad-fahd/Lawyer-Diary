﻿#pragma checksum "..\..\..\Hearings\HearingByDates.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E7D0A483C6B1A222713B4C988C29AEB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Lawyer_Diary.Hearings;
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


namespace Lawyer_Diary.Hearings {
    
    
    /// <summary>
    /// HearingByDates
    /// </summary>
    public partial class HearingByDates : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Hearings\HearingByDates.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpSelectDate;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Hearings\HearingByDates.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid completeCasesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Hearings\HearingByDates.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpenCase;
        
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
            System.Uri resourceLocater = new System.Uri("/Lawyer Diary;component/hearings/hearingbydates.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Hearings\HearingByDates.xaml"
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
            
            #line 8 "..\..\..\Hearings\HearingByDates.xaml"
            ((Lawyer_Diary.Hearings.HearingByDates)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dpSelectDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 29 "..\..\..\Hearings\HearingByDates.xaml"
            this.dpSelectDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpSelectDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.completeCasesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 34 "..\..\..\Hearings\HearingByDates.xaml"
            this.completeCasesDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.completeCasesDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnOpenCase = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Hearings\HearingByDates.xaml"
            this.btnOpenCase.Click += new System.Windows.RoutedEventHandler(this.btnOpenCase_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
