﻿#pragma checksum "..\..\menu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C94FF62D7C4A77F1CC3312A63E3523F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApplication1;


namespace WpfApplication1 {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button game;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button table;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton easy;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton medium;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton hard;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock rek;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_Copy;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NK;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\menu.xaml"
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
            this.game = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\menu.xaml"
            this.game.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.table = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\menu.xaml"
            this.table.Click += new System.Windows.RoutedEventHandler(this.table_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.easy = ((System.Windows.Controls.RadioButton)(target));
            
            #line 12 "..\..\menu.xaml"
            this.easy.Checked += new System.Windows.RoutedEventHandler(this.easy_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.medium = ((System.Windows.Controls.RadioButton)(target));
            
            #line 13 "..\..\menu.xaml"
            this.medium.Checked += new System.Windows.RoutedEventHandler(this.medium_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.hard = ((System.Windows.Controls.RadioButton)(target));
            
            #line 14 "..\..\menu.xaml"
            this.hard.Checked += new System.Windows.RoutedEventHandler(this.hard_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\menu.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.rek = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.textBlock_Copy = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.NK = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
