#pragma checksum "C:\Users\Hp-pavilion\Downloads\Task15_12_2021-master\Task\Task\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "993ddeba28b774d9bf8a1c56174ceff90003fc78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\Hp-pavilion\Downloads\Task15_12_2021-master\Task\Task\Views\_ViewImports.cshtml"
using Task;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp-pavilion\Downloads\Task15_12_2021-master\Task\Task\Views\_ViewImports.cshtml"
using Task.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"993ddeba28b774d9bf8a1c56174ceff90003fc78", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e4748c78e07aa5cf64bc1a89b8bfaeab258e7a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sentMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\Hp-pavilion\Downloads\Task15_12_2021-master\Task\Task\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Page Header Start -->\n<div class=\"page-header\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-12\">\n                <h2>Contact Us</h2>\n            </div>\n            <div class=\"col-12\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 286, "\"", 293, 0);
            EndWriteAttribute();
            WriteLiteral(">Home</a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 322, "\"", 329, 0);
            EndWriteAttribute();
            WriteLiteral(@">Contact</a>
            </div>
        </div>
    </div>
</div>
<!-- Page Header End -->
<!-- Contact Start -->
<div class=""contact"">
    <div class=""container"">
        <div class=""section-header text-center"">
            <p>Contact Us</p>
            <h2>Contact For Any Query</h2>
        </div>
        <div class=""row align-items-center contact-information"">
            <div class=""col-md-6 col-lg-3"">
                <div class=""contact-info"">
                    <div class=""contact-icon"">
                        <i class=""fa fa-map-marker-alt""></i>
                    </div>
                    <div class=""contact-text"">
                        <h3>Address</h3>
                        <p>123 Street, NY, USA</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3"">
                <div class=""contact-info"">
                    <div class=""contact-icon"">
                        <i class=""fa fa-phone-alt""></i>
                    </div>
            ");
            WriteLiteral(@"        <div class=""contact-text"">
                        <h3>Call Us</h3>
                        <p>+012 345 6789</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3"">
                <div class=""contact-info"">
                    <div class=""contact-icon"">
                        <i class=""fa fa-envelope""></i>
                    </div>
                    <div class=""contact-text"">
                        <h3>Email Us</h3>
                        <p>info@example.com</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3"">
                <div class=""contact-info"">
                    <div class=""contact-icon"">
                        <i class=""fa fa-share""></i>
                    </div>
                    <div class=""contact-text"">
                        <h3>Follow Us</h3>
                        <div class=""contact-social"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 2352, "\"", 2359, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2426, "\"", 2433, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2503, "\"", 2510, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-youtube\"></i></a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2577, "\"", 2584, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2653, "\"", 2660, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fab fa-linkedin-in""></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row contact-form"">
            <div class=""col-md-6"">
                <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3001156.4288297426!2d-78.01371936852176!3d42.72876761954724!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4ccc4bf0f123a5a9%3A0xddcfc6c1de189567!2sNew%20York%2C%20USA!5e0!3m2!1sen!2sbd!4v1600663868074!5m2!1sen!2sbd"" frameborder=""0"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 3227, "\"", 3245, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"false\" tabindex=\"0\"></iframe>\n            </div>\n            <div class=\"col-md-6\">\n                <div id=\"success\"></div>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "993ddeba28b774d9bf8a1c56174ceff90003fc789094", async() => {
                WriteLiteral(@"
                    <div class=""control-group"">
                        <input type=""text"" class=""form-control"" id=""name"" placeholder=""Your Name"" required=""required"" data-validation-required-message=""Please enter your name"" />
                        <p class=""help-block text-danger""></p>
                    </div>
                    <div class=""control-group"">
                        <input type=""email"" class=""form-control"" id=""email"" placeholder=""Your Email"" required=""required"" data-validation-required-message=""Please enter your email"" />
                        <p class=""help-block text-danger""></p>
                    </div>
                    <div class=""control-group"">
                        <input type=""text"" class=""form-control"" id=""subject"" placeholder=""Subject"" required=""required"" data-validation-required-message=""Please enter a subject"" />
                        <p class=""help-block text-danger""></p>
                    </div>
                    <div class=""control-group"">
                   ");
                WriteLiteral(@"     <textarea class=""form-control"" id=""message"" placeholder=""Message"" required=""required"" data-validation-required-message=""Please enter your message""></textarea>
                        <p class=""help-block text-danger""></p>
                    </div>
                    <div>
                        <button class=""btn custom-btn"" type=""submit"" id=""sendMessageButton"">Send Message</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n<!-- Contact End -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
