#pragma checksum "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b3a72b8d51fb14906e58dc5fe65a354767baa49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Details.cshtml", typeof(AspNetCore.Views_Books_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\_ViewImports.cshtml"
using BookstoreCRUD;

#line default
#line hidden
#line 2 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\_ViewImports.cshtml"
using BookstoreCRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3a72b8d51fb14906e58dc5fe65a354767baa49", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a0ebee0fa57c6859ef2df24038eee08cd147d67", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookstoreCRUD.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 127, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Book</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(207, 41, false);
#line 14 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(248, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(312, 37, false);
#line 17 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(349, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(412, 41, false);
#line 20 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(453, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(517, 37, false);
#line 23 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(554, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(617, 41, false);
#line 26 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(658, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(722, 37, false);
#line 29 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(759, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(822, 43, false);
#line 32 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
            EndContext();
            BeginContext(865, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(929, 39, false);
#line 35 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Picture));

#line default
#line hidden
            EndContext();
            BeginContext(968, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1031, 45, false);
#line 38 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PageCount));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1140, 41, false);
#line 41 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.PageCount));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1244, 44, false);
#line 44 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1352, 40, false);
#line 47 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Language));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1439, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3a72b8d51fb14906e58dc5fe65a354767baa499089", async() => {
                BeginContext(1487, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\chewb\source\repos\BookstoreCRUD\Views\Books\Details.cshtml"
                           WriteLiteral(Model.Isbn);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1495, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1503, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3a72b8d51fb14906e58dc5fe65a354767baa4911401", async() => {
                BeginContext(1525, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1541, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookstoreCRUD.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
