﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Akeeba.extractCLI.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Language {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Language() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Akeeba.extractCLI.Resources.Language", typeof(Language).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} cannot be opened for reading.
        /// </summary>
        internal static string ERR_CANNOT_READ {
            get {
                return ResourceManager.GetString("ERR_CANNOT_READ", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occured.
        /// </summary>
        internal static string ERR_HEADER {
            get {
                return ResourceManager.GetString("ERR_HEADER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} does not exist.
        /// </summary>
        internal static string ERR_NOT_FOUND {
            get {
                return ResourceManager.GetString("ERR_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation has completed successfully.
        /// </summary>
        internal static string LBL_ALL_DONE {
            get {
                return ResourceManager.GetString("LBL_ALL_DONE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The archive extraction has finished.
        /// </summary>
        internal static string LBL_STATUS_FINISHED {
            get {
                return ResourceManager.GetString("LBL_STATUS_FINISHED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The archive extraction has been aborted.
        /// </summary>
        internal static string LBL_STATUS_IDLE {
            get {
                return ResourceManager.GetString("LBL_STATUS_IDLE", resourceCulture);
            }
        }
    }
}
