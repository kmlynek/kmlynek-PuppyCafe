﻿#pragma checksum "..\..\PetsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9CB025E756FEC0A05C23F826C252A8360BDBC5360D327553075347A4A5DB1458"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PuppyCafeApp;
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


namespace PuppyCafeApp {
    
    
    /// <summary>
    /// PetsWindow
    /// </summary>
    public partial class PetsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\PetsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid petsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\PetsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn pets_idColumn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\PetsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn employee_idColumn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\PetsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn pet_nameColumn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PetsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn ageColumn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\PetsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\PetsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pets_idTextBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\PetsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox employee_idTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\PetsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pet_nameTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\PetsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ageTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/PuppyCafeApp;component/petswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PetsWindow.xaml"
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
            
            #line 8 "..\..\PetsWindow.xaml"
            ((PuppyCafeApp.PetsWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.petsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.pets_idColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.employee_idColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.pet_nameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.ageColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.pets_idTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.employee_idTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.pet_nameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.ageTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

