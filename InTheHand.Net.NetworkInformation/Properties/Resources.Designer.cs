﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8009
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InTheHand.Net.NetworkInformation.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("InTheHand.Net.NetworkInformation.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to An invalid physical address was specified..
        /// </summary>
        internal static string net_bad_mac_address {
            get {
                return ResourceManager.GetString("net_bad_mac_address", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The collection is read-only..
        /// </summary>
        internal static string net_collection_readonly {
            get {
                return ResourceManager.GetString("net_collection_readonly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IPv4 address 0.0.0.0 and IPv6 address ::0 are unspecified addresses that cannot be used as a target address..
        /// </summary>
        internal static string net_invalid_ip_addr {
            get {
                return ResourceManager.GetString("net_invalid_ip_addr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The buffer length must not exceed 65500 bytes..
        /// </summary>
        internal static string net_invalidPingBufferSize {
            get {
                return ResourceManager.GetString("net_invalidPingBufferSize", resourceCulture);
            }
        }
    }
}
