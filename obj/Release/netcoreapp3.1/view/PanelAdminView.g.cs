﻿#pragma checksum "..\..\..\..\view\PanelAdminView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81F68147803806D438180A02D5EE6D2C5EC6725B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using PanelAdmin.Langs;
using PanelAdmin.view;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PanelAdmin.view {
    
    
    /// <summary>
    /// PanelAdminView
    /// </summary>
    public partial class PanelAdminView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\view\PanelAdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Address;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\view\PanelAdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Port;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\view\PanelAdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button enButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\view\PanelAdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button frButton;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\view\PanelAdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid _listWorks;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PanelAdmin;component/view/paneladminview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\view\PanelAdminView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Address = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Port = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 47 "..\..\..\..\view\PanelAdminView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Connection_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.enButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\view\PanelAdminView.xaml"
            this.enButton.Click += new System.Windows.RoutedEventHandler(this.ChangeLanguage);
            
            #line default
            #line hidden
            return;
            case 5:
            this.frButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\view\PanelAdminView.xaml"
            this.frButton.Click += new System.Windows.RoutedEventHandler(this.ChangeLanguage);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 57 "..\..\..\..\view\PanelAdminView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Launch_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 63 "..\..\..\..\view\PanelAdminView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Pause_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 69 "..\..\..\..\view\PanelAdminView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this._listWorks = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

