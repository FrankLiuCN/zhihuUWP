﻿#pragma checksum "C:\Frank\SourceCode\ZhiHu.UWP\ZhiHu.UWP.Mobile\Views\Home.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "90B89F8D66E39A6F403A81CBC42401A1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zhihu.UWP.Views
{
    partial class Home : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        private class Home_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IHome_Bindings
        {
            private global::Zhihu.UWP.Views.Home dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj7;

            public Home_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IHome_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // Home_obj1_Bindings

            public void SetDataRoot(global::Zhihu.UWP.Views.Home newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Zhihu.UWP.Views.Home obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update__test(obj._test, phase);
                    }
                }
            }
            private void Update__test(global::Zhihu.UWP.ViewModels.HomeTest obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element2 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 82 "..\..\..\Views\Home.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element2).Click += this.topic_Click;
                    #line default
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element3 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 92 "..\..\..\Views\Home.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element3).Click += this.txtTitle_Click;
                    #line default
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element4 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 35 "..\..\..\Views\Home.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element4).Click += this.topic_Click;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element5 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 49 "..\..\..\Views\Home.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element5).Click += this.txtTitle_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.homeHeader = (global::Zhihu.UWP.Controls.PageHeader)(target);
                }
                break;
            case 7:
                {
                    this.lvQuestion = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 139 "..\..\..\Views\Home.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lvQuestion).SelectionChanged += this.lvQuestion_SelectionChanged;
                    #line default
                }
                break;
            case 8:
                {
                    this.prLoading = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Home_obj1_Bindings bindings = new Home_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

