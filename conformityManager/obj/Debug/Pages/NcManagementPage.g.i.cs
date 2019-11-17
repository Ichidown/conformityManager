﻿#pragma checksum "..\..\..\Pages\NcManagementPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "026F85D041C4B0792025B97BB8484BF510A00EB3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace conformityManager.Pages {
    
    
    /// <summary>
    /// NcManagementPage
    /// </summary>
    public partial class NcManagementPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\Pages\NcManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost NewFormDialog;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\NcManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame NcFileFormFrame;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Pages\NcManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost DeleateDialog;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\Pages\NcManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.Transitioner MainTransitioner;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\Pages\NcManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame QualityFrame;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\Pages\NcManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame HseFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/conformityManager;component/pages/ncmanagementpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\NcManagementPage.xaml"
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
            this.NewFormDialog = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 2:
            this.NcFileFormFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.DeleateDialog = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 4:
            
            #line 62 "..\..\..\Pages\NcManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ConfirmRemoveNcFile);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 92 "..\..\..\Pages\NcManagementPage.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.SwitchToQuality);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 97 "..\..\..\Pages\NcManagementPage.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.SwitchToHSE);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 105 "..\..\..\Pages\NcManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowNewNcForm);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MainTransitioner = ((MaterialDesignThemes.Wpf.Transitions.Transitioner)(target));
            return;
            case 9:
            this.QualityFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 10:
            this.HseFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
