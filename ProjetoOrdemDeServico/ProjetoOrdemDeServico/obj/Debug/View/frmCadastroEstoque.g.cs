﻿#pragma checksum "..\..\..\View\frmCadastroEstoque.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B1C2A2FD7C5744653E9644B213E0AD2D07A2421948EC29A471A408D5A7547047"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjetoOrdemDeServico.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace ProjetoOrdemDeServico.View {
    
    
    /// <summary>
    /// frmCadastroEstoque
    /// </summary>
    public partial class frmCadastroEstoque : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\View\frmCadastroEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboCategoria;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\frmCadastroEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboProduto;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\frmCadastroEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuantidade;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\frmCadastroEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLote;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\frmCadastroEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtGridEstoque;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetoOrdemDeServico;component/view/frmcadastroestoque.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\frmCadastroEstoque.xaml"
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
            
            #line 9 "..\..\..\View\frmCadastroEstoque.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboCategoria = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\View\frmCadastroEstoque.xaml"
            this.cboCategoria.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CboCategoria_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cboProduto = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txtQuantidade = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtLote = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 21 "..\..\..\View\frmCadastroEstoque.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SalvarEstoque);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 22 "..\..\..\View\frmCadastroEstoque.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dtGridEstoque = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

