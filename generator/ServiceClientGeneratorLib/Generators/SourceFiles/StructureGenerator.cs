﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class StructureGenerator : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Xml.Serialization;" +
                    "\r\nusing System.Text;\r\nusing System.IO;\r\n\r\nusing Amazon.Runtime;\r\nusing Amazon.Ru" +
                    "ntime.Internal;\r\n\r\nnamespace ");
            
            #line 18 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model\r\n{\r\n");
            
            #line 20 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

	if(this.StructureType == StructureType.Request)
		this.FormatOperationRequestDocumentation(this.Operation);
	else if (this.Operation != null && GeneratorHelpers.HasSuppressedResult(this.Operation))
		this.FormatVoidResultDocumentation(this.Operation.Name);
	else if(this.StructureType == StructureType.Response && (this.Structure == null || string.IsNullOrEmpty(this.Structure.Documentation)))
	{

            
            #line default
            #line hidden
            this.Write("\t/// <summary>\r\n\t/// This is the response object from the ");
            
            #line 29 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write(" operation.\r\n\t/// </summary>\r\n");
            
            #line 31 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

	}
	else
	    this.FormatClassDocumentation(this.Structure);  

            
            #line default
            #line hidden
            this.Write("\tpublic partial class ");
            
            #line 36 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ClassName));
            
            #line default
            #line hidden
            
            #line 36 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.BaseClassString));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n");
            
            #line 38 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

        if(this.Structure != null)
        {
            if(this.IsWrapped)
            {

            
            #line default
            #line hidden
            this.Write("        private ");
            
            #line 44 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" _response;\r\n");
            
            #line 45 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

            }
            else
            {
		        foreach(var member in this.Structure.Members)
                {
					if (member.IsExcluded)
						continue;

            
            #line default
            #line hidden
            this.Write("        private ");
            
            #line 54 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            
            #line 54 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.IsNullable ? "?" : ""));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 54 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            
            #line 54 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.ShouldInstantiate ? string.Format(" = new {0}();", member.DetermineType()) : ";"));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 55 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                }
            }
        }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 61 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

        if(this.Structure != null)
        {
            if(this.IsWrapped)
            {

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// Gets and sets the ");
            
            #line 68 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" property.\r\n        /// </summary>\r\n        public ");
            
            #line 70 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 70 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            get { return this._response; }\r\n            set { this._" +
                    "response = value; }\r\n        }\r\n");
            
            #line 75 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

            }
            else
            {
        AddSimpleRequestConstructors(this.ClassName, this.Structure, this.Config.Namespace);
		        foreach(var member in this.Structure.Members)
                {
					if (member.IsExcluded)
						continue;

            
            #line default
            #line hidden
            
            #line 85 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
 this.FormatPropertyDocumentation(member); 
            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 86 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.AccessModifier));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 86 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            
            #line 86 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.UseNullable ? "?" : ""));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 86 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n");
            
            #line 88 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    if(member.IsNullable && !member.UseNullable)
                    {

            
            #line default
            #line hidden
            this.Write("            get { return this.");
            
            #line 92 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(".GetValueOrDefault(); }\r\n");
            
            #line 93 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }
                    else
                    {

            
            #line default
            #line hidden
            this.Write("            get { return this.");
            
            #line 98 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write("; }\r\n");
            
            #line 99 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }

            
            #line default
            #line hidden
            this.Write("            set { this.");
            
            #line 102 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(" = value; }\r\n        }\r\n\r\n");
            
            #line 105 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    if (member.EmitIsSetProperties)
                    {

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// This property is set to true if the property <" +
                    "seealso cref=\"");
            
            #line 110 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(@"""/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool Is");
            
            #line 119 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("Set\r\n        {\r\n            get\r\n            {\r\n                return Amazon.Uti" +
                    "l.Internal.InternalSDKUtils.GetIsSet(this.");
            
            #line 123 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(");\r\n            }\r\n            set\r\n            {\r\n                Amazon.Util.In" +
                    "ternal.InternalSDKUtils.SetIsSet(value, ref this.");
            
            #line 127 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(");\r\n            }\r\n        }\r\n\r\n");
            
            #line 131 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }

            
            #line default
            #line hidden
            this.Write("        // Check to see if ");
            
            #line 134 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" property is set\r\n        internal bool IsSet");
            
            #line 135 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n");
            
            #line 137 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    if (member.EmitIsSetProperties)
                    {

            
            #line default
            #line hidden
            this.Write("            return this.Is");
            
            #line 141 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("Set; \r\n");
            
            #line 142 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }
                    else if (member.IsNullable)
                    {

            
            #line default
            #line hidden
            this.Write("            return this.");
            
            #line 147 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(".HasValue; \r\n");
            
            #line 148 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }
                    else if (member.IsMap || member.IsList)
                    {

            
            #line default
            #line hidden
            this.Write("            return this.");
            
            #line 153 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(" != null && this.");
            
            #line 153 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(".Count > 0; \r\n");
            
            #line 154 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }
                    else
                    {

            
            #line default
            #line hidden
            this.Write("            return this.");
            
            #line 159 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(" != null;\r\n");
            
            #line 160 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 165 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                }
            }
        }

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 174 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

    // Set to true when the service model specifies a shape that should be wrapped in a response. ElastiCache CreateCacheCluster is an example of this.
    public bool IsWrapped { get; set; }

	public Operation Operation { get; set; }
    public string ClassName { get; set; }
    public string BaseClass { get; set; }
    public Shape Structure { get; set; }
	public StructureType StructureType { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
