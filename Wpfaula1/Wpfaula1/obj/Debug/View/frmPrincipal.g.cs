﻿#pragma checksum "..\..\..\View\frmPrincipal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "606E35572C13AD26DBE2FEBE3977F8BAEC507CD84D74FE1396E0C6D297B4A58E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using Wpfaula1.View;


namespace Wpfaula1.View {
    
    
    /// <summary>
    /// frmPrincipal
    /// </summary>
    public partial class frmPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumero1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumero2;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSomar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblResultado;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpfaula1;component/view/frmprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\frmPrincipal.xaml"
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
            this.txtNumero1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\View\frmPrincipal.xaml"
            this.txtNumero1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtNumero1_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtNumero2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\View\frmPrincipal.xaml"
            this.txtNumero2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtNumero2_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSomar = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\View\frmPrincipal.xaml"
            this.btnSomar.Click += new System.Windows.RoutedEventHandler(this.BtnSomar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblResultado = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
