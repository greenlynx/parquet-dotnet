﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parquet.CLI {
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
    internal class Help {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Help() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Parquet.CLI.Help", typeof(Help).Assembly);
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
        ///   Looks up a localized string similar to Display verbose output..
        /// </summary>
        internal static string App_Verbose {
            get {
                return ResourceManager.GetString("App_Verbose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to parquet file..
        /// </summary>
        internal static string Argument_Path {
            get {
                return ResourceManager.GetString("Argument_Path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Converts between file formats. Currently supports conversion from parquet to multiline json only. When launched prints json documents to the terminal..
        /// </summary>
        internal static string Command_Convert_Description {
            get {
                return ResourceManager.GetString("Command_Convert_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to input file, required..
        /// </summary>
        internal static string Command_Convert_Input {
            get {
                return ResourceManager.GetString("Command_Convert_Input", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum amount of rows to fetch. By default the first 10 rows are shown..
        /// </summary>
        internal static string Command_Convert_MaxRows {
            get {
                return ResourceManager.GetString("Command_Convert_MaxRows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to output file. If not specified, the result is printed to the console..
        /// </summary>
        internal static string Command_Convert_Output {
            get {
                return ResourceManager.GetString("Command_Convert_Output", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When set, colorises and idents output..
        /// </summary>
        internal static string Command_Convert_Pretty {
            get {
                return ResourceManager.GetString("Command_Convert_Pretty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output style. By default result is a multiline json document. Specify &quot;single&quot; to generate an array document with list of documents embedded, or &quot;multiline&quot; for a multiline json..
        /// </summary>
        internal static string Command_Convert_Style {
            get {
                return ResourceManager.GetString("Command_Convert_Style", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays internal parquet metadata.
        /// </summary>
        internal static string Command_Meta_Description {
            get {
                return ResourceManager.GetString("Command_Meta_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays parquet file schema as Parquet.Net sees it. Note that this is a simplified, human-readable version of the schema..
        /// </summary>
        internal static string Command_Schema_Description {
            get {
                return ResourceManager.GetString("Command_Schema_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays and interactive shell app for exploring the contents of the Parquet file. .
        /// </summary>
        internal static string Command_View_Description {
            get {
                return ResourceManager.GetString("Command_View_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display the full contents of the Parquet file. For larger files, screen wrapping may be an issue, so you should consider piping the result to a file and viewing that file independently of Parq..
        /// </summary>
        internal static string Command_ViewAll_Description {
            get {
                return ResourceManager.GetString("Command_ViewAll_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expand Cells based on value length. Defaults to false..
        /// </summary>
        internal static string Command_ViewAll_Expand {
            get {
                return ResourceManager.GetString("Command_ViewAll_Expand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minimum column width. Defaults to 5..
        /// </summary>
        internal static string Command_ViewAll_Min {
            get {
                return ResourceManager.GetString("Command_ViewAll_Min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display Null Values. Defaults to true..
        /// </summary>
        internal static string Command_ViewAll_Nulls {
            get {
                return ResourceManager.GetString("Command_ViewAll_Nulls", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display types in column headesr. Defaults to false..
        /// </summary>
        internal static string Command_ViewAll_Types {
            get {
                return ResourceManager.GetString("Command_ViewAll_Types", resourceCulture);
            }
        }
    }
}
