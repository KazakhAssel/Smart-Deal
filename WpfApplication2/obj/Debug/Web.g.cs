﻿#pragma checksum "..\..\Web.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3D58FADAB5CA8BD321901BE3A27053895DE0612A"
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
using WpfApplication2;


namespace WpfApplication2 {
    
    
    /// <summary>
    /// Web
    /// </summary>
    public partial class Web : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\Web.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgVideo;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Web.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgCapture;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Web.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntCapture;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Web.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntSaveImage;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Web.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntResolution;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Web.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntSetting;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Web.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntStart;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Web.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntStop;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Web.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bntContinue;
        
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
            System.Uri resourceLocater = new System.Uri("/Working Concept;component/web.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Web.xaml"
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
            
            #line 8 "..\..\Web.xaml"
            ((WpfApplication2.Web)(target)).Loaded += new System.Windows.RoutedEventHandler(this.mainWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imgVideo = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.imgCapture = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.bntCapture = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\Web.xaml"
            this.bntCapture.Click += new System.Windows.RoutedEventHandler(this.bntCapture_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bntSaveImage = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\Web.xaml"
            this.bntSaveImage.Click += new System.Windows.RoutedEventHandler(this.bntSaveImage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.bntResolution = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\Web.xaml"
            this.bntResolution.Click += new System.Windows.RoutedEventHandler(this.bntResolution_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.bntSetting = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\Web.xaml"
            this.bntSetting.Click += new System.Windows.RoutedEventHandler(this.bntSetting_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.bntStart = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\Web.xaml"
            this.bntStart.Click += new System.Windows.RoutedEventHandler(this.bntStart_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.bntStop = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\Web.xaml"
            this.bntStop.Click += new System.Windows.RoutedEventHandler(this.bntStop_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.bntContinue = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\Web.xaml"
            this.bntContinue.Click += new System.Windows.RoutedEventHandler(this.bntContinue_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

