#pragma checksum "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a41394a3a8615a96d7596798f84b459314db94b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PetPals.Pages.Pages_Profile), @"mvc.1.0.razor-page", @"/Pages/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Profile.cshtml", typeof(PetPals.Pages.Pages_Profile), null)]
namespace PetPals.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\_ViewImports.cshtml"
using PetPals;

#line default
#line hidden
#line 3 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\_ViewImports.cshtml"
using PetPals.Data;

#line default
#line hidden
#line 3 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a41394a3a8615a96d7596798f84b459314db94b0", @"/Pages/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04d2fcc8ca1a703d487c50932678537b6d34c035", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Profile-shareIcon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/facebook.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px;height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/twitter.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/instagram.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/goldstar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("42"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("42"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("profileheader"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(166, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d6957bb1db584b36acfbe75b2e70dbe9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(228, 51, true);
            WriteLiteral("\r\n<h3 id=\"profileheader\" style=\"text-align:center\">");
            EndContext();
            BeginContext(280, 76, false);
#line 9 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
                                            Write(HttpContext.Session.GetString(ProfileModel.SessionKeySelectedSitterFullname));

#line default
#line hidden
            EndContext();
            BeginContext(356, 52, true);
            WriteLiteral(" \'s Profile</h3>\r\n\r\n<div style=\"text-align:right\">\r\n");
            EndContext();
#line 12 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
     foreach (var item in Model.SocialLinks)
    {
        if (item.SitterID == Model.Sitter.ID)
        {
            if (item.Facebook != null)
            {

#line default
#line hidden
            BeginContext(574, 34, true);
            WriteLiteral("        <a class=Profile-shareLink");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 608, "\"", 659, 1);
#line 18 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
WriteAttributeValue("", 615, Html.DisplayFor(modelItem => item.Facebook), 615, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(660, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(675, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "375fd7cac17f409bb0aef89655bae04c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(764, 16, true);
            WriteLiteral("\r\n        </a>\r\n");
            EndContext();
#line 21 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
            }
            if (item.Twitter != null)
            {

#line default
#line hidden
            BeginContext(849, 34, true);
            WriteLiteral("        <a class=Profile-shareLink");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 883, "\"", 933, 1);
#line 24 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
WriteAttributeValue("", 890, Html.DisplayFor(modelItem => item.Twitter), 890, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(934, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(949, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "32da6226a29a4b8a8ce1f2b915a321dc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1037, 16, true);
            WriteLiteral("\r\n        </a>\r\n");
            EndContext();
#line 27 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
            }
            if (item.Instagram != null)
            {


#line default
#line hidden
            BeginContext(1126, 34, true);
            WriteLiteral("        <a class=Profile-shareLink");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1160, "\"", 1212, 1);
#line 31 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
WriteAttributeValue("", 1167, Html.DisplayFor(modelItem => item.Instagram), 1167, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1213, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(1228, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fc7acb37b3054eb6a4683ea35043529e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1318, 16, true);
            WriteLiteral("\r\n        </a>\r\n");
            EndContext();
#line 34 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
            }
        }
    }

#line default
#line hidden
            BeginContext(1367, 442, true);
            WriteLiteral(@"</div>

<div>
    <table class=""table"">
        <thead id=""button"">
            <tr>
                <th>
                    About Me
                </th>
                <th>
                    My Area
                </th>
                <th>
                    Contact Information
                </th>
            </tr>
        </thead>
        <tbody>

            <tr>
                <td>
                    ");
            EndContext();
            BeginContext(1810, 79, false);
#line 58 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
               Write(HttpContext.Session.GetString(ProfileModel.SessionKeySelectedSitterDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1957, 72, false);
#line 61 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
               Write(HttpContext.Session.GetString(ProfileModel.SessionKeySelectedSitterTown));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2097, 79, false);
#line 64 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
               Write(HttpContext.Session.GetString(ProfileModel.SessionKeySelectedSitterPhonenumber));

#line default
#line hidden
            EndContext();
            BeginContext(2176, 336, true);
            WriteLiteral(@"
                </td>
            </tr>

        </tbody>
    </table>
</div>

<div>
    <table class=""table"">
        <thead id=""button"">
            <tr>
                <th>
                    Animal Experience
                </th>
                <th></th>
            </tr>

        </thead>
        <tbody>
");
            EndContext();
#line 84 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
              

                foreach (var item in Model.Experiences)
                {

                    if (item.SitterID == Model.Sitter.ID)
                    { 

#line default
#line hidden
            BeginContext(2691, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2800, 45, false);
#line 93 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
                               Write(Html.DisplayFor(modelItem => item.AnimalType));

#line default
#line hidden
            EndContext();
            BeginContext(2845, 98, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>                      \r\n");
            EndContext();
#line 96 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"

                    }

                }

            

#line default
#line hidden
            BeginContext(3006, 304, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div>
    <table class=""table"">
        <thead id=""button"">
            <tr>
                <th>
                    Full list of services provided 
                </th>
                <th></th>
            </tr>

        </thead>
        <tbody>
");
            EndContext();
#line 118 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
              
                var serviceprice = 0;
                foreach (var item in Model.Services)
                {

                    if (item.SitterID == Model.Sitter.ID)
                    {
                        serviceprice = Convert.ToInt32(item.Price);

#line default
#line hidden
            BeginContext(3591, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3688, 46, false);
#line 128 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ServiceType));

#line default
#line hidden
            EndContext();
            BeginContext(3734, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>£ ");
            EndContext();
            BeginContext(3806, 12, false);
#line 130 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
                             Write(serviceprice);

#line default
#line hidden
            EndContext();
            BeginContext(3818, 40, true);
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 133 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
                    }
                }

            

#line default
#line hidden
            BeginContext(3917, 284, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>


<div>
    <table class=""table"">
        <thead id=""button"">
            <tr>
                <th>
                    Reviews
                </th>
                <th></th>
            </tr>

        </thead>
        <tbody>

");
            EndContext();
#line 155 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
              
                var Rating = 0;
                var averageRating = 0;
                foreach (var item in Model.Reviews)
                {
                    if (item.SitterID == Model.Sitter.ID)
                    {

#line default
#line hidden
            BeginContext(4444, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4541, 46, false);
#line 164 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(4587, 107, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                By: ");
            EndContext();
            BeginContext(4695, 52, false);
#line 167 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Customer.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(4747, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 170 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
                        Rating = Rating + item.Rating;
                    }
                }
                var count = Model.Reviews.Count(i => i.SitterID == Model.Sitter.ID);
                if (count == 0)
                {

#line default
#line hidden
            BeginContext(5051, 98, true);
            WriteLiteral("                    <tr>\r\n                    <td>No reviews yet</td>\r\n                    </tr>\r\n");
            EndContext();
#line 179 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
                }
                else
                {
                    averageRating = Rating / count;

#line default
#line hidden
            BeginContext(5262, 48, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
            EndContext();
#line 185 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
                         for (var i = 0; i < averageRating; i++)
                        {

#line default
#line hidden
            BeginContext(5403, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(5431, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba0b9f3a3f5e42fb8916be4ef227e762", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5487, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 188 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
                        }

#line default
#line hidden
            BeginContext(5516, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 191 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(5608, 44, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(5652, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc75213ec98b49e2b038c156d94088e1", async() => {
                BeginContext(5697, 118, true);
                WriteLiteral("\r\n    <div>\r\n        <button type=\"submit\" class=\"btn btn-default\" id=\"button\">Book this sitter</button>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5822, 17, true);
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(5839, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fa23b110b4d4bf6b793f03d6ff28be5", async() => {
                BeginContext(5879, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5895, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5925, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 210 "C:\Users\Zoe\source\repos\PetPals\PetPals\Pages\Profile.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PetPals.Pages.ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PetPals.Pages.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PetPals.Pages.ProfileModel>)PageContext?.ViewData;
        public PetPals.Pages.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591