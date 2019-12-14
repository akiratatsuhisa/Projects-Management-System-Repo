#pragma checksum "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "512bf05c80909fed580fc7725f2d1b9d7922548d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Management_Views_Projects_Index), @"mvc.1.0.view", @"/Areas/Management/Views/Projects/Index.cshtml")]
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
#nullable restore
#line 1 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\_ViewImports.cshtml"
using WebApplication.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\_ViewImports.cshtml"
using WebApplication.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512bf05c80909fed580fc7725f2d1b9d7922548d", @"/Areas/Management/Views/Projects/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dbc63e91c5c3f5ee5e2a6f1912a9b0306f8b7fe", @"/Areas/Management/Views/_ViewImports.cshtml")]
    public class Areas_Management_Views_Projects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication.Models.Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Xem chi tiết"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
  
    ViewData["Title"] = "Projects";
    Lecturer lecturer = @ViewBag.Lecturer;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title "">Danh sách đồ án giảng viên theo dõi</h4>
                <p class=""card-category"">
                    <dl class=""row"">
                        <dt class=""col-2"">
                            Tên giảng viên:
                        </dt>
                        <dd class=""col-10"">
                            ");
#nullable restore
#line 19 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                       Write(lecturer.ApplicationUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                                                          Write(lecturer.ApplicationUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </dd>
                    </dl>
                </p>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead class="" text-primary"">
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 30 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 33 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 36 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.ProjectType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 39 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 42 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 48 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 52 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 55 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 58 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ProjectType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 61 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 64 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"td-actions text-right\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "512bf05c80909fed580fc7725f2d1b9d7922548d11866", async() => {
                WriteLiteral("\r\n                                        <i class=\"material-icons\">info</i>\r\n                                    ");
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
#nullable restore
#line 67 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 72 "E:\GitHub\Project-Management-System-Repo\WebApplication\WebApplication\Areas\Management\Views\Projects\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591