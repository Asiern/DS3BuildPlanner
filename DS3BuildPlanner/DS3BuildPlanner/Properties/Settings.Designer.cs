﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DS3BuildPlanner.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int colorSchemeIndex {
            get {
                return ((int)(this["colorSchemeIndex"]));
            }
            set {
                this["colorSchemeIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::MaterialSkin.Accent ThemeAccent {
            get {
                return ((global::MaterialSkin.Accent)(this["ThemeAccent"]));
            }
            set {
                this["ThemeAccent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::MaterialSkin.Primary ThemePrimary1 {
            get {
                return ((global::MaterialSkin.Primary)(this["ThemePrimary1"]));
            }
            set {
                this["ThemePrimary1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::MaterialSkin.Primary ThemePrimary2 {
            get {
                return ((global::MaterialSkin.Primary)(this["ThemePrimary2"]));
            }
            set {
                this["ThemePrimary2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::MaterialSkin.Primary ThemePrimary3 {
            get {
                return ((global::MaterialSkin.Primary)(this["ThemePrimary3"]));
            }
            set {
                this["ThemePrimary3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::MaterialSkin.TextShade ThemeTextShade {
            get {
                return ((global::MaterialSkin.TextShade)(this["ThemeTextShade"]));
            }
            set {
                this["ThemeTextShade"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Theme {
            get {
                return ((string)(this["Theme"]));
            }
            set {
                this["Theme"] = value;
            }
        }
    }
}
