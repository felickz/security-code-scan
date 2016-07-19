﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoslynSecurityGuard {
    using System;
    using System.Reflection;
    
    
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
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RoslynSecurityGuard.Messages", typeof(Messages).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to The dynamic value passed to the command execution should be validate..
        /// </summary>
        internal static string CommandInjectionAnalyzer_Message {
            get {
                return ResourceManager.GetString("CommandInjectionAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Potential command injection with Process.Start.
        /// </summary>
        internal static string CommandInjectionAnalyzer_Title {
            get {
                return ResourceManager.GetString("CommandInjectionAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dynamic value passed in the SQL query should be validate..
        /// </summary>
        internal static string LinqSqlInjectionAnalyzer_Message {
            get {
                return ResourceManager.GetString("LinqSqlInjectionAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Potential SQL injection with LINQ.
        /// </summary>
        internal static string LinqSqlInjectionAnalyzer_Title {
            get {
                return ResourceManager.GetString("LinqSqlInjectionAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate Validation has been disable. The communication could be intercepted..
        /// </summary>
        internal static string WeakCertificateValidationAnalyzer_Message {
            get {
                return ResourceManager.GetString("WeakCertificateValidationAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate Validation has been disable.
        /// </summary>
        internal static string WeakCertificateValidationAnalyzer_Title {
            get {
                return ResourceManager.GetString("WeakCertificateValidationAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The hashing function &quot;{0}&quot; is no longer recommended for password storage and signature generation..
        /// </summary>
        internal static string WeakHashingAnalyzer_Message {
            get {
                return ResourceManager.GetString("WeakHashingAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Weak hashing function.
        /// </summary>
        internal static string WeakHashingAnalyzer_Title {
            get {
                return ResourceManager.GetString("WeakHashingAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The random numbers generated could be predicted..
        /// </summary>
        internal static string WeakRandomAnalyzer_Message {
            get {
                return ResourceManager.GetString("WeakRandomAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Weak random generator.
        /// </summary>
        internal static string WeakRandomAnalyzer_Title {
            get {
                return ResourceManager.GetString("WeakRandomAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dynamic value passed to the XPath query should be validate.
        /// </summary>
        internal static string XPathInjectionAnalyzer_Message {
            get {
                return ResourceManager.GetString("XPathInjectionAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Potential command injection with XmlDocument.
        /// </summary>
        internal static string XPathInjectionAnalyzer_Title {
            get {
                return ResourceManager.GetString("XPathInjectionAnalyzer_Title", resourceCulture);
            }
        }
    }
}