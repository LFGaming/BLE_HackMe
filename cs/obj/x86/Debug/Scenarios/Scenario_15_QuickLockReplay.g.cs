﻿#pragma checksum "C:\Users\micro\Documents\GitHub\BLE_HackMe\cs\Scenarios\Scenario_15_QuickLockReplay.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5FE675C15EFFAA136D2576642E75122C77DF4B11DA4234BE679DEA40413E993B"
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
    partial class Scenario_15_QuickLockReplay : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Scenarios\Scenario_15_QuickLockReplay.xaml line 147
                {
                    this.VoiceUnlocking = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3: // Scenarios\Scenario_15_QuickLockReplay.xaml line 151
                {
                    this.SmartLock = (global::BLE_Hackme.UserControls.SmartLockUserControl)(target);
                }
                break;
            case 4: // Scenarios\Scenario_15_QuickLockReplay.xaml line 155
                {
                    this.Hint1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5: // Scenarios\Scenario_15_QuickLockReplay.xaml line 168
                {
                    this.Hint2 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6: // Scenarios\Scenario_15_QuickLockReplay.xaml line 186
                {
                    this.Hint3 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7: // Scenarios\Scenario_15_QuickLockReplay.xaml line 17
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
            return returnValue;
        }
    }
}

