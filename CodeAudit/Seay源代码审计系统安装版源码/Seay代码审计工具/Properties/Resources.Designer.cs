﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seay代码审计工具.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Seay代码审计工具.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
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
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap _0 {
            get {
                object obj = ResourceManager.GetObject("0", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 匹配链接地址及标题`\&lt;a href *= *[&apos;&quot;]*(\S+)[&quot;&apos;].*\&gt;(.[^\&lt;]*)?\&lt;/a&gt;;
        ///匹配HTML标记的正则表达式`&lt;(\S*?)[^&gt;]*&gt;.*?&lt;/\1&gt;|&lt;.*? /&gt;;
        ///匹配Email地址的正则表达式`\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*;
        ///匹配网址URL`[a-zA-z]+://[^\s]*;
        ///匹配IP地址`\d+\.\d+\.\d+\.\d+;
        ///匹配国内电话号码`\d{3}-\d{8}|\d{4}-\d{7};
        ///匹配中国邮政编码`[1-9]\d{5}(?!\d);
        ///匹配中文字符`[\u4e00-\u9fa5];
        ///匹配26字母英文单词`^[A-Za-z]+$;
        ///匹配正整数`^[1-9]\d*$;
        ///匹配整数`^-?[1-9]\d*$;
        ///年-月-日`/^(d{2}|d{4})-((0([1-9]{1}))|(1[1|2]))-(([0-2]([1-9]{1}))|(3[0|1]))$/ 的本地化字符串。
        /// </summary>
        internal static string guize {
            get {
                return ResourceManager.GetString("guize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap mainbg3 {
            get {
                object obj = ResourceManager.GetObject("mainbg3", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 \`将下一个字符标记为一个特殊字符、或一个原义字符、或一个后向引用、或一个八进制转义符，例如&apos;n&apos;匹配字符&quot;n&quot;，&apos;\n&apos;匹配一个换行符，序列&apos;\\&apos;匹配&quot;\&quot;而&quot;\(&quot;则匹配&quot;(&quot;;
        ///.`匹配除&quot;\n&quot;之外的任何单个字符，要匹配包括&apos;\n&apos;在内的任何字符，请使用象&apos;[.\n]&apos;的模式;
        ///^`匹配输入字符串的开始位置,如果将^用作括号表达式中的第一个字符,则会对字符集求非;
        ///$`匹配输入字符串的结束位置，\d{3}$与搜索字符串结尾处的3个数字匹配;
        ///*`匹配前面的子表达式零次或多次，例如zo*能匹配&quot;z&quot;以及&quot;zoo&quot;，*等价于{0,};
        ///+`匹配前面的子表达式一次或多次，例如&apos;zo+&apos;能匹配&quot;zo&quot;以及&quot;zoo&quot;,但不能匹配&quot;z&quot;，+等价于{1,};
        ///?`匹配前面的子表达式零次或一次，例如&quot;do(es)?&quot;可以匹配&quot;do&quot;或&quot;does&quot;中的&quot;do&quot;，?等价于{0,1}，
        ///\b`匹配一个单词边界，也就是指单词和空格间的位置，例如&apos;er\b&apos;可以匹配&quot;never&quot;中的&apos;er&apos;，但不能匹配&quot;verb&quot;中的&apos;er&apos;;
        ///\B`匹配非单词边界，&apos;er\B&apos;能匹配&quot;verb&quot;中的&apos;er&apos;，但不能匹配&quot;n [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string relus {
            get {
                return ResourceManager.GetString("relus", resourceCulture);
            }
        }
    }
}
