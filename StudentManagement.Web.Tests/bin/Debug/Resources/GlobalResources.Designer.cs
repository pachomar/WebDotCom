﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagement.Web.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class GlobalResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GlobalResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StudentManagement.Web.Resources.GlobalResources", typeof(GlobalResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no data matching the specified text.
        /// </summary>
        public static string EmptyGridMessage {
            get {
                return ResourceManager.GetString("EmptyGridMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password cannot be empty.
        /// </summary>
        public static string EmptyPasswordLogin {
            get {
                return ResourceManager.GetString("EmptyPasswordLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UserName cannot be empty.
        /// </summary>
        public static string EmptyUserLogin {
            get {
                return ResourceManager.GetString("EmptyUserLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is already a student with the specified email in the system.
        /// </summary>
        public static string ExistingEmailError {
            get {
                return ResourceManager.GetString("ExistingEmailError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User name or password is incorrect.
        /// </summary>
        public static string InvalidUserOrPassword {
            get {
                return ResourceManager.GetString("InvalidUserOrPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User is already logged out.
        /// </summary>
        public static string NoUserLogged {
            get {
                return ResourceManager.GetString("NoUserLogged", resourceCulture);
            }
        }
    }
}
