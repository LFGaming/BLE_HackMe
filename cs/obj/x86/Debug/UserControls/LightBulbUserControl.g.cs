﻿#pragma checksum "C:\Users\micro\Documents\GitHub\BLE_HackMe\cs\UserControls\LightBulbUserControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0F54F3026C41FABC33C69474158552DA9340DFD465CB4D0F4D8FBE2CE15B9F31"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLE_Hackme.UserControls
{
    partial class LightBulbUserControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
            case 2: // UserControls\LightBulbUserControl.xaml line 13
                {
                    this.LightBulbIn = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            case 3: // UserControls\LightBulbUserControl.xaml line 14
                {
                    this.LightBulbOut = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            case 4: // UserControls\LightBulbUserControl.xaml line 15
                {
                    this.LightBulbChecked = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
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

