﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImageDatabase.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string IndexFolder {
            get {
                return ((string)(this["IndexFolder"]));
            }
            set {
                this["IndexFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string QueryFolder {
            get {
                return ((string)(this["QueryFolder"]));
            }
            set {
                this["QueryFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SurfThresholdSelectedIndex {
            get {
                return ((int)(this["SurfThresholdSelectedIndex"]));
            }
            set {
                this["SurfThresholdSelectedIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double SurfUniquenessThreshold {
            get {
                return ((double)(this["SurfUniquenessThreshold"]));
            }
            set {
                this["SurfUniquenessThreshold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SurfGoodMatchThreshold {
            get {
                return ((int)(this["SurfGoodMatchThreshold"]));
            }
            set {
                this["SurfGoodMatchThreshold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SurfAlgo {
            get {
                return ((int)(this["SurfAlgo"]));
            }
            set {
                this["SurfAlgo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int CEDDAlgo {
            get {
                return ((int)(this["CEDDAlgo"]));
            }
            set {
                this["CEDDAlgo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CodeBookFolder {
            get {
                return ((string)(this["CodeBookFolder"]));
            }
            set {
                this["CodeBookFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public double Locate_GoodThresholdDistance {
            get {
                return ((double)(this["Locate_GoodThresholdDistance"]));
            }
            set {
                this["Locate_GoodThresholdDistance"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SelectedAlgo {
            get {
                return ((int)(this["SelectedAlgo"]));
            }
            set {
                this["SelectedAlgo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("128")]
        public int Locate_SizeOfCookbook {
            get {
                return ((int)(this["Locate_SizeOfCookbook"]));
            }
            set {
                this["Locate_SizeOfCookbook"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Locate_IsCodeBookNeedToBeCreated {
            get {
                return ((bool)(this["Locate_IsCodeBookNeedToBeCreated"]));
            }
            set {
                this["Locate_IsCodeBookNeedToBeCreated"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Locate_IsLteSchemeNeedToAppy {
            get {
                return ((bool)(this["Locate_IsLteSchemeNeedToAppy"]));
            }
            set {
                this["Locate_IsLteSchemeNeedToAppy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int Locate_SelectedMethod {
            get {
                return ((int)(this["Locate_SelectedMethod"]));
            }
            set {
                this["Locate_SelectedMethod"] = value;
            }
        }
    }
}
