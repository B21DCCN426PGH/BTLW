#pragma checksum "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\Stores\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db236ba2c580166a5756230c25f355fb176eb982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stores_Index), @"mvc.1.0.view", @"/Views/Stores/Index.cshtml")]
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
#line 1 "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\_ViewImports.cshtml"
using ABCD_OnlineMall;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\_ViewImports.cshtml"
using ABCD_OnlineMall.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db236ba2c580166a5756230c25f355fb176eb982", @"/Views/Stores/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a7c816d6395d12c811cfd7548c1293e6b942c7b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Stores_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ABCD_OnlineMall.Models.Store>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/js/onload.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/css/store.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Plots", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StoreDetailsClient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card card--effect-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\Stores\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            DefineSection("onload", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db236ba2c580166a5756230c25f355fb176eb9825908", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n");
            DefineSection("storecss", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "db236ba2c580166a5756230c25f355fb176eb9827158", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n<div class=\"store\">\n    <div class=\"store-1200\">\n        <div class=\"heading-title\">\n            <h1 class=\"heading-title-text\">Stores</h1>\n        </div>\n");
#nullable restore
#line 19 "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\Stores\Index.cshtml"
         using (Html.BeginForm("Index", "Stores", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""search"">
                <div class=""search-wrap"">
                    <input name=""searchString"" type=""text"" class=""search-input"" placeholder=""Input search..."">
                    <button type=""submit"" value=""Search"" class=""fas fa-search search-icon"" />
                </div>
            </div>
");
#nullable restore
#line 27 "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\Stores\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"store-wrap\" id=\"list-store\">\n            <div class=\"grid\">\n");
#nullable restore
#line 31 "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\Stores\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-3\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db236ba2c580166a5756230c25f355fb176eb9829974", async() => {
                WriteLiteral("\n                            <div class=\"card-img\"");
                BeginWriteAttribute("style", "\n                                 style=\'", 1177, "\'", 1260, 4);
                WriteAttributeValue("", 1218, "background-image:", 1218, 17, true);
                WriteAttributeValue(" ", 1235, "url(\"/", 1236, 7, true);
#nullable restore
#line 36 "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\Stores\Index.cshtml"
WriteAttributeValue("", 1242, item.ImageName, 1242, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1257, "\");", 1257, 3, true);
                EndWriteAttribute();
                WriteLiteral(">\n                            </div>\n                            <div class=\"card-more\">\n                                <p class=\"card-text\">More</p>\n                            </div>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\Stores\Index.cshtml"
                                                                                    WriteLiteral(item.StoreId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <h1 class=\"card-name\">");
#nullable restore
#line 42 "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\Stores\Index.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.StoreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <div class=\"card-time\">\n                            <p class=\"time-string\">");
#nullable restore
#line 44 "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\Stores\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.OpenTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 44 "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\Stores\Index.cshtml"
                                                                                             Write(Html.DisplayFor(modelItem => item.CloseTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p class=\"time-text-open\">Open</p>\n                            <p class=\"time-text-close\">Close</p>\n                        </div>\n                    </div>\n");
#nullable restore
#line 49 "C:\Users\pgh12\OneDrive\Desktop\eProject3\ABCD-OnlineMall-master-master\ABCD-OnlineMall-master-master\ABCD-OnlineMall\Views\Stores\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
        <div class=""notification"">
            <div class=""notification-text"">
                Not Found
            </div>
        </div>
    </div>
</div>
<script>
    var store = document.getElementById(""list-store"");
    if (store.clientHeight == 0) {
        document.getElementsByClassName(""notification"")[0].style.display = ""block"";
    }
    const time = new Date();

    let day = time.getDate();
    let hours = time.getHours();
    let minutes = time.getMinutes();
    let seconds = time.getSeconds();

    const timestring = document.getElementsByClassName('time-string');
    for (var i = 0; i < timestring.length; i++) {
        var timer = timestring[i].innerHTML;
        var openhours = parseInt(timer.slice(0, 2));
        var openminutes = parseInt(timer.slice(3, 5));
        //console.log(typeof openhours);
        //console.log(openminutes);
        var closehours = parseInt(timer.slice(11, 13));
        var closeminutes = parseInt(timer.slice(14, 16));
        //c");
            WriteLiteral(@"onsole.log(closehours);
        //console.log(closeminutes);
        var textopen = document.getElementsByClassName('time-text-open');
        var textclose = document.getElementsByClassName('time-text-close');
        console.log(textopen);
        console.log(textclose);
        if (hours > openhours && hours < closehours) {
            textopen.style.display = ""block"";
        } else {
            textclose.style.display = ""block"";
        }

    }




</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ABCD_OnlineMall.Models.Store>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
