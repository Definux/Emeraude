﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.ServiceAgents.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Definux.Emeraude.Admin.ClientBuilder.Models;
    using Definux.Emeraude.Admin.ClientBuilder.Shared;
    using Definux.Utilities.Extensions;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class EndpointsTemplate : EndpointsTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 9 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClientBuilderConstants.AutoGeneratedHeaderText));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 11 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
 foreach (var classItem in (List<ClassDescription>)Session["Classes"]) { if (classItem.IsComplex) {
            
            #line default
            #line hidden
            this.Write("/**\r\n * @typedef ");
            
            #line 13 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(classItem.Name));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 14 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
 foreach (var property in classItem.Properties) { 
            
            #line default
            #line hidden
            this.Write(" * @property {");
            
            #line 15 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Type.JavaScriptTypeName));
            
            #line default
            #line hidden
            this.Write("} ");
            
            #line 15 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToFirstLower()));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 16 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(" */\r\n");
            
            #line 18 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
 } } 
            
            #line default
            #line hidden
            
            #line 19 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
 foreach (var controller in (List<string>)Session["EndpointsControllers"]) { 
            
            #line default
            #line hidden
            this.Write("\r\nexport class ");
            
            #line 21 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controller.Replace("ApiController", string.Empty)));
            
            #line default
            #line hidden
            this.Write("ServiceAgent {\r\n");
            
            #line 22 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
 foreach (var endpoint in ((List<Endpoint>)Session["Endpoints"]).Where(x => x.ControllerName == controller).ToList()) { 
            
            #line default
            #line hidden
            this.Write("\r\n    /**\r\n     * ");
            
            #line 25 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(endpoint.ControllerName));
            
            #line default
            #line hidden
            this.Write("/");
            
            #line 25 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(endpoint.ActionName));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 26 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
if (endpoint.Arguments.Count > 0) {foreach (var argument in endpoint.Arguments) { 
            
            #line default
            #line hidden
            this.Write("     * @param {");
            
            #line 27 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(argument.Class.JavaScriptTypeName));
            
            #line default
            #line hidden
            this.Write("} ");
            
            #line 27 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(argument.Name));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 28 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 29 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("     * @param {Object} queryParams\r\n     * @param {Object} headers\r\n     * @retur" +
                    "ns {Promise}\r\n     */\r\n    ");
            
            #line 34 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(endpoint.ActionName.ToFirstLower()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 34 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(endpoint.ArgumentsListString));
            
            #line default
            #line hidden
            
            #line 34 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.IsNullOrEmpty(endpoint.ArgumentsListString) ? "" : ", "));
            
            #line default
            #line hidden
            this.Write("queryParams = null, headers = null) {");
            
            #line 34 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
 var requestUrl = "`" + endpoint.Route.Replace("{", "${") + "`";
            
            #line default
            #line hidden
            this.Write(" \r\n        let url = new URL(");
            
            #line 35 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(requestUrl));
            
            #line default
            #line hidden
            this.Write(", window.location.origin);\r\n        if (queryParams != null) {\r\n            url.s" +
                    "earch = new URLSearchParams(queryParams).toString();\r\n        }\r\n");
            
            #line 39 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
if (endpoint.MethodName.ToUpper() == "GET") {
            
            #line default
            #line hidden
            this.Write(@"        return fetch(url, {
            method: 'GET',
            headers: headers || { 'Content-Type': 'application/json', 'Accept': 'application/json' },
            credentials: 'include'
        })
            .then(response => response.json());
");
            
            #line 46 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 47 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
if (endpoint.MethodName.ToUpper() == "POST") {
            
            #line default
            #line hidden
            this.Write("        return fetch(url, {\r\n            method: \'POST\',\r\n            headers: he" +
                    "aders || { \'Content-Type\': \'application/json\', \'Accept\': \'application/json\' },\r\n" +
                    "            body: ");
            
            #line 51 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
if (!string.IsNullOrEmpty(endpoint.ArgumentsListString)) { 
            
            #line default
            #line hidden
            this.Write("JSON.stringify(");
            
            #line 51 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(endpoint.ComplexArgument.Name));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 51 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
 } else {
            
            #line default
            #line hidden
            this.Write("null");
            
            #line 51 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(",\r\n            credentials: \'include\'\r\n        })\r\n            .then(response => " +
                    "response.json());\r\n");
            
            #line 55 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 56 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
if (endpoint.MethodName.ToUpper() == "PUT") {
            
            #line default
            #line hidden
            this.Write("        return fetch(url, {\r\n            method: \'PUT\',\r\n            headers: hea" +
                    "ders || { \'Content-Type\': \'application/json\', \'Accept\': \'application/json\' },\r\n " +
                    "           body: ");
            
            #line 60 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
if (!string.IsNullOrEmpty(endpoint.ArgumentsListString)) { 
            
            #line default
            #line hidden
            this.Write("JSON.stringify(");
            
            #line 60 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(endpoint.ComplexArgument.Name));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 60 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
 } else {
            
            #line default
            #line hidden
            this.Write("null");
            
            #line 60 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(",\r\n            credentials: \'include\'\r\n        })\r\n            .then(response => " +
                    "response.json());\r\n");
            
            #line 64 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 65 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
if (endpoint.MethodName.ToUpper() == "DELETE") {
            
            #line default
            #line hidden
            this.Write(@"        return fetch(url, {
            method: 'DELETE',
            headers: headers || { 'Content-Type': 'application/json', 'Accept': 'application/json' },
            credentials: 'include'
        })
            .then(response => response.json());
");
            
            #line 72 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("    }\r\n");
            
            #line 74 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("}\r\n");
            
            #line 76 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 77 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
 foreach (var controller in (List<string>)Session["EndpointsControllers"]) { 
            
            #line default
            #line hidden
            this.Write("\r\n/**\r\n * @type {");
            
            #line 80 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controller.Replace("ApiController", string.Empty)));
            
            #line default
            #line hidden
            this.Write("ServiceAgent}\r\n */\r\nexport const ");
            
            #line 82 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controller.Replace("ApiController", string.Empty).ToFirstLower()));
            
            #line default
            #line hidden
            this.Write("ServiceAgent = new ");
            
            #line 82 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controller.Replace("ApiController", string.Empty)));
            
            #line default
            #line hidden
            this.Write("ServiceAgent();\r\n");
            
            #line 83 "D:\GitHubWorkspace\Emeraude\src\Admin\Definux.Emeraude.Admin.ClientBuilder.Modules.Vue\Implementations\ServiceAgents\Templates\EndpointsTemplate.tt"
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class EndpointsTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
