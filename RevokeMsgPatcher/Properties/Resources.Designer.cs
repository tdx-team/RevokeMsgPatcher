﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RevokeMsgPatcher.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RevokeMsgPatcher.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 [{&quot;FileName&quot;:&quot;WeChatWin.dll&quot;,&quot;Version&quot;:&quot;2.6.8.65&quot;,&quot;SHA1Before&quot;:&quot;e01f6855a96c12c30808960903ed199a33e4952c&quot;,&quot;SHA1After&quot;:&quot;d9120569cfd0433aebea107d7b90805cbbac7518&quot;,&quot;Position&quot;:2454265,&quot;Content&quot;:117},{&quot;FileName&quot;:&quot;WeChatWin.dll&quot;,&quot;Version&quot;:&quot;2.6.8.52&quot;,&quot;SHA1Before&quot;:&quot;88131302f664df6a657c9ca49d152da536fe5729&quot;,&quot;SHA1After&quot;:&quot;8d1454b73831644181e962c1fa0ea4e2da4124a3&quot;,&quot;Position&quot;:2453049,&quot;Content&quot;:117},{&quot;FileName&quot;:&quot;WeChatWin.dll&quot;,&quot;Version&quot;:&quot;2.6.8.51&quot;,&quot;SHA1Before&quot;:&quot;d0a5517b1292a751501b00b4b1f0702db2d9fc30&quot;,&quot;SHA1After&quot;:&quot;53e7b [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string PatchJson {
            get {
                return ResourceManager.GetString("PatchJson", resourceCulture);
            }
        }
    }
}
