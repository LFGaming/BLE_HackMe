﻿#pragma checksum "C:\Users\micro\Documents\GitHub\BLE_HackMe\cs\Scenarios\Scenario_03_Advertisements.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E183261F754623F9C91160C0815BEC445B859A45E1724D970E423237BA97BFB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLE_Hackme
{
    partial class Scenario_03_Advertisements : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Scenario_03_Advertisements_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IScenario_03_Advertisements_Bindings
        {
            private global::BLE_Hackme.Scenario_03_Advertisements dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj5;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj5Click;

            // Static fields for each binding's enabled/disabled state

            public Scenario_03_Advertisements_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 100 && columnNumber == 62)
                {
                    this.obj5.Click -= obj5Click;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // Scenarios\Scenario_03_Advertisements.xaml line 100
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Button)target;
                        this.obj5Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ValueSubmitButton_Click();
                        };
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += obj5Click;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IScenario_03_Advertisements_Bindings

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

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::BLE_Hackme.Scenario_03_Advertisements)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BLE_Hackme.Scenario_03_Advertisements obj, int phase)
            {
                if (obj != null)
                {
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Scenarios\Scenario_03_Advertisements.xaml line 106
                {
                    this.Hint1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // Scenarios\Scenario_03_Advertisements.xaml line 112
                {
                    this.Hint2 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // Scenarios\Scenario_03_Advertisements.xaml line 99
                {
                    this.ValueToEnter = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Scenarios\Scenario_03_Advertisements.xaml line 100
                {
                    this.Submit = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6: // Scenarios\Scenario_03_Advertisements.xaml line 16
                {
                    this.Solved = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Scenarios\Scenario_03_Advertisements.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Scenario_03_Advertisements_obj1_Bindings bindings = new Scenario_03_Advertisements_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

