﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotSee.AutoNode.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotSee.AutoNode.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to AutoNode: Configuration file was not found..
        /// </summary>
        internal static string ErrorConfigNotFound {
            get {
                return ResourceManager.GetString("ErrorConfigNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: There was a problem creating node &apos;{0}&apos; under node &apos;{1}&apos;..
        /// </summary>
        internal static string ErrorCreateNode {
            get {
                return ResourceManager.GetString("ErrorCreateNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: The dictionary key specified in autoNode.config was not found..
        /// </summary>
        internal static string ErrorDictionaryKeyNotFound {
            get {
                return ResourceManager.GetString("ErrorDictionaryKeyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: There was a problem with new node creation. Please check that the doctype alias you have defined in rules actually exists.
        /// </summary>
        internal static string ErrorGeneric {
            get {
                return ResourceManager.GetString("ErrorGeneric", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: There was a problem loading AutoNode configuration from the config file.
        /// </summary>
        internal static string ErrorLoadConfig {
            get {
                return ResourceManager.GetString("ErrorLoadConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: Node &apos;{0}&apos; was not republished successfully under node &apos;{1}&apos;..
        /// </summary>
        internal static string ErrorRepublishNoSuccess {
            get {
                return ResourceManager.GetString("ErrorRepublishNoSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: Aborting node creation since node already exists.
        /// </summary>
        internal static string InfoAbortCreateNodeNodeExists {
            get {
                return ResourceManager.GetString("InfoAbortCreateNodeNodeExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: Aborting node creation due to rule restrictions. Parent node already has children, rule indicates that parent node should not have children.
        /// </summary>
        internal static string InfoAbortCreateNodeRuleRestrictions {
            get {
                return ResourceManager.GetString("InfoAbortCreateNodeRuleRestrictions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: Node &apos;{0}&apos; was created successfully under node &apos;{1}&apos;..
        /// </summary>
        internal static string InfoCreateNodeSuccess {
            get {
                return ResourceManager.GetString("InfoCreateNodeSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: Loading configuration complete.
        /// </summary>
        internal static string InfoLoadConfigComplete {
            get {
                return ResourceManager.GetString("InfoLoadConfigComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: Loading configuration....
        /// </summary>
        internal static string InfoLoadingConfig {
            get {
                return ResourceManager.GetString("InfoLoadingConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: Republishing already existing child node....
        /// </summary>
        internal static string InfoRepublishingExistingNode {
            get {
                return ResourceManager.GetString("InfoRepublishingExistingNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: Bringing newly created node first....
        /// </summary>
        internal static string InfoSortingNodes {
            get {
                return ResourceManager.GetString("InfoSortingNodes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AutoNode: Trying to automatically create node of type {nodeType} for node {parentNodeId} of type {parentNodeType}....
        /// </summary>
        internal static string InfoTryCreateNode {
            get {
                return ResourceManager.GetString("InfoTryCreateNode", resourceCulture);
            }
        }
    }
}
