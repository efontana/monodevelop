﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.MacDev.ObjCIntegration {
    using MonoDevelop.MacDev.ObjCIntegration;
    using System;
    
    
    public partial class CSharpCodeTypeDefinition : CodebehindTemplateBase {
        
        public override string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write("// This file has been autogenerated from parsing an Objective-C header file added in Xcode.\n\nusing System;\n\nusing ");
            
            #line default
            #line hidden
            
            #line 8 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( WrapperNamespace ));
            
            #line default
            #line hidden
            
            #line 8 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write(".Foundation;\n");
            
            #line default
            #line hidden
            
            #line 9 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"

foreach (var ns in Type.GetNamespaces ())
	WriteLine ("using {0};", ns);

            
            #line default
            #line hidden
            
            #line 13 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write("\nnamespace ");
            
            #line default
            #line hidden
            
            #line 14 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( GetNs (Type.CliName) ));
            
            #line default
            #line hidden
            
            #line 14 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write("\n{\n");
            
            #line default
            #line hidden
            
            #line 16 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"

string userTypeName = GetName (Type.CliName);
string baseTypeName = GetName (Type.BaseCliType);

            
            #line default
            #line hidden
            
            #line 20 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write("\tpublic partial class ");
            
            #line default
            #line hidden
            
            #line 20 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(userTypeName ));
            
            #line default
            #line hidden
            
            #line 20 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write(" : ");
            
            #line default
            #line hidden
            
            #line 20 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(baseTypeName ));
            
            #line default
            #line hidden
            
            #line 20 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write("\n\t{\n\t\tpublic ");
            
            #line default
            #line hidden
            
            #line 22 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(userTypeName ));
            
            #line default
            #line hidden
            
            #line 22 "/Users/fejj/src/xamarin/monodevelop/main/src/addins/MonoDevelop.MacDev/ObjCIntegration/CSharpCodeTypeDefinition.tt"
            this.Write(" (IntPtr handle) : base (handle)\n\t\t{\n\t\t}\n\t}\n}\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        protected override void Initialize() {
            base.Initialize();
        }
    }
}
