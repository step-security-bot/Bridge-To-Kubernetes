﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.BridgeToKubernetes.RoutingManager {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.BridgeToKubernetes.RoutingManager.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Unable to find container being debugged when retrieving probes. .
        /// </summary>
        internal static string FailedToFindDebuggedContainer {
            get {
                return ResourceManager.GetString("FailedToFindDebuggedContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find named port &apos;{0}&apos; in container &apos;{1}&apos; - either container ports are empty or named port is empty. .
        /// </summary>
        internal static string FailedToFindNamedPortEmptyFormat {
            get {
                return ResourceManager.GetString("FailedToFindNamedPortEmptyFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find named port &apos;{0}&apos; in container &apos;{1}&apos;. .
        /// </summary>
        internal static string FailedToFindNamedPortFormat {
            get {
                return ResourceManager.GetString("FailedToFindNamedPortFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service port &apos;{0}&apos; from ingress &apos;{1}&apos; does not match any port on the service &apos;{2}&apos;. .
        /// </summary>
        internal static string FailedToMatchServicePortFromIngressFormat {
            get {
                return ResourceManager.GetString("FailedToMatchServicePortFromIngressFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read annotation value &apos;{0}&apos; from object &apos;{1}&apos;. .
        /// </summary>
        internal static string FailedToReadAnnotationFormat {
            get {
                return ResourceManager.GetString("FailedToReadAnnotationFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read label value &apos;{0}&apos; from object &apos;{1}&apos;. .
        /// </summary>
        internal static string FailedToReadLabelFormat {
            get {
                return ResourceManager.GetString("FailedToReadLabelFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of generated envoy resources do not match. .
        /// </summary>
        internal static string FailedToValidateEnvoyResources {
            get {
                return ResourceManager.GetString("FailedToValidateEnvoyResources", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of expected ingresses is &apos;{0}&apos;, but number of generated cloned ingresses is &apos;{1}&apos;. .
        /// </summary>
        internal static string FailedToValidateGeneratedIngressCountFormat {
            get {
                return ResourceManager.GetString("FailedToValidateGeneratedIngressCountFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of expected ingresses should be 0, but the count is actually &apos;{0}&apos;. .
        /// </summary>
        internal static string GeneratedIngressCountInvalidFormat {
            get {
                return ResourceManager.GetString("GeneratedIngressCountInvalidFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown kubernetes object of type &apos;{0}&apos;. .
        /// </summary>
        internal static string UnknownKubernetesObjectFormat {
            get {
                return ResourceManager.GetString("UnknownKubernetesObjectFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Count of Virtual hosts list is not equal to 1 which is unexpected. .
        /// </summary>
        internal static string VirtualHostCount {
            get {
                return ResourceManager.GetString("VirtualHostCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual host does not contain any &apos;.&apos; which is unexpected. .
        /// </summary>
        internal static string VirtualHostInvalid {
            get {
                return ResourceManager.GetString("VirtualHostInvalid", resourceCulture);
            }
        }
    }
}