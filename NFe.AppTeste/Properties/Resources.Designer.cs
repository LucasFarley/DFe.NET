﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NFe.AppTeste.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NFe.AppTeste.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;h1&gt;Nota Fiscal Eletrônica&lt;/h1&gt;
        ///&lt;h2&gt;Prezado Cliente,&lt;/h2&gt;
        ///&lt;p&gt;Segue anexo a Nota Fiscal eletrônica (xml e pdf), conforme pedido número 1234.&lt;/p&gt;
        ///&lt;p&gt;
        ///&lt;b&gt;Chave de acesso:&lt;/b&gt; 0123 4567 8901 2345 6789 0123 4567 8901 2345 6789 0123
        ///&lt;br&gt;&lt;b&gt;Número:&lt;/b&gt; 000123456
        ///&lt;br&gt;&lt;b&gt;Valor Total:&lt;/b&gt; 1.234,56
        ///&lt;/p&gt;
        ///&lt;p&gt;Consulte a autencidade de sua NFe acessando &lt;a href=&quot;http://www.nfe.fazenda.gov.br/portal/consulta.aspx?tipoConsulta=completa&amp;tipoConteudo=XbSeqxE8pl8=&quot;&gt;Consulta NFe Completa&lt;/a&gt; &lt;/p&gt;
        ///ZEUS Automação [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MensagemHtml {
            get {
                return ResourceManager.GetString("MensagemHtml", resourceCulture);
            }
        }
    }
}
