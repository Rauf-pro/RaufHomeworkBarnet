#pragma checksum "C:\Users\User\Desktop\TaskLesson16.12\TaskLesson\TaskLesson\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e4c18a2d92e7cda133d4a43178c7f3c4ff87af8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\TaskLesson16.12\TaskLesson\TaskLesson\Views\_ViewImports.cshtml"
using TaskLesson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\TaskLesson16.12\TaskLesson\TaskLesson\Views\_ViewImports.cshtml"
using TaskLesson.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4c18a2d92e7cda133d4a43178c7f3c4ff87af8", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6da5a8c3a5e7290003cade3a13408c571ca1d20", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://html.commonsupport.xyz/2019/Barnet/contact.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\TaskLesson16.12\TaskLesson\TaskLesson\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page title -->
<section class=""page-title"" style=""background-image:url(images/background/3.jpg)"">
    <div class=""container"">
        <div class=""outer-box"">
            <h1>Blog Grid One</h1>
            <ul class=""bread-crumb clearfix"">
                <li><a href=""index.html"">Home</a></li>
                <li class=""active"">Blog Grid One</li>
            </ul>
        </div>
    </div>
</section>

<!-- Blog section one -->
<section class=""blog-section-one sp-two"">
    <div class=""container"">
        <div class=""row"">
            <!-- News block two -->
            <div class=""col-lg-4 news-block-two"">
                <div class=""inner-box wow fadeInUp"" data-wow-duration=""1.5s"">
                    <div class=""image"">
                        <img src=""images/resource/news-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 909, "\"", 915, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""overlay"">
                            <a class=""link-btn"" href=""blog-details.html"">
                                <i class=""icon-link""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""lower-content"">
                        <ul class=""post-meta"">
                            <li><span>Explore</span></li>
                            <li><span>Lyfestyle</span></li>
                        </ul>
                        <h4><a href=""blog-details.html"">Aspernatur aut odit fugit.</a></h4>
                        <div class=""text"">Lorem ipsum dolor sit amet adipelit sed eius mtempor encid dolore</div>
                    </div>
                </div>
            </div>
            <!-- News block two -->
            <div class=""col-lg-4 news-block-two"">
                <div class=""inner-box wow fadeInUp"" data-wow-duration=""1.5s"">
                    <div class=""image"">
          ");
            WriteLiteral("              <img src=\"images/resource/news-5.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1991, "\"", 1997, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""overlay"">
                            <a class=""link-btn"" href=""blog-details.html"">
                                <i class=""icon-link""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""lower-content"">
                        <ul class=""post-meta"">
                            <li><span>Explore</span></li>
                            <li><span>Lyfestyle</span></li>
                        </ul>
                        <h4><a href=""blog-details.html"">Aspernatur aut odit fugit.</a></h4>
                        <div class=""text"">Lorem ipsum dolor sit amet adipelit sed eius mtempor encid dolore</div>
                    </div>
                </div>
            </div>
            <!-- News block two -->
            <div class=""col-lg-4 news-block-two"">
                <div class=""inner-box wow fadeInUp"" data-wow-duration=""1.5s"">
                    <div class=""image"">
          ");
            WriteLiteral("              <img src=\"images/resource/news-6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3073, "\"", 3079, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""overlay"">
                            <a class=""link-btn"" href=""blog-details.html"">
                                <i class=""icon-link""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""lower-content"">
                        <ul class=""post-meta"">
                            <li><span>Explore</span></li>
                            <li><span>Lyfestyle</span></li>
                        </ul>
                        <h4><a href=""blog-details.html"">Aspernatur aut odit fugit.</a></h4>
                        <div class=""text"">Lorem ipsum dolor sit amet adipelit sed eius mtempor encid dolore</div>
                    </div>
                </div>
            </div>
            <!-- News block two -->
            <div class=""col-lg-4 news-block-two"">
                <div class=""inner-box wow fadeInUp"" data-wow-duration=""1.5s"">
                    <div class=""image"">
          ");
            WriteLiteral("              <img src=\"images/resource/news-7.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4155, "\"", 4161, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""overlay"">
                            <a class=""link-btn"" href=""blog-details.html"">
                                <i class=""icon-link""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""lower-content"">
                        <ul class=""post-meta"">
                            <li><span>Explore</span></li>
                            <li><span>Lyfestyle</span></li>
                        </ul>
                        <h4><a href=""blog-details.html"">Aspernatur aut odit fugit.</a></h4>
                        <div class=""text"">Lorem ipsum dolor sit amet adipelit sed eius mtempor encid dolore</div>
                    </div>
                </div>
            </div>
            <!-- News block two -->
            <div class=""col-lg-4 news-block-two"">
                <div class=""inner-box wow fadeInUp"" data-wow-duration=""1.5s"">
                    <div class=""image"">
          ");
            WriteLiteral("              <img src=\"images/resource/news-8.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5237, "\"", 5243, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""overlay"">
                            <a class=""link-btn"" href=""blog-details.html"">
                                <i class=""icon-link""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""lower-content"">
                        <ul class=""post-meta"">
                            <li><span>Explore</span></li>
                            <li><span>Lyfestyle</span></li>
                        </ul>
                        <h4><a href=""blog-details.html"">Aspernatur aut odit fugit.</a></h4>
                        <div class=""text"">Lorem ipsum dolor sit amet adipelit sed eius mtempor encid dolore</div>
                    </div>
                </div>
            </div>
            <!-- News block two -->
            <div class=""col-lg-4 news-block-two"">
                <div class=""inner-box wow fadeInUp"" data-wow-duration=""1.5s"">
                    <div class=""image"">
          ");
            WriteLiteral("              <img src=\"images/resource/news-9.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6319, "\"", 6325, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""overlay"">
                            <a class=""link-btn"" href=""blog-details.html"">
                                <i class=""icon-link""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""lower-content"">
                        <ul class=""post-meta"">
                            <li><span>Explore</span></li>
                            <li><span>Lyfestyle</span></li>
                        </ul>
                        <h4><a href=""blog-details.html"">Aspernatur aut odit fugit.</a></h4>
                        <div class=""text"">Lorem ipsum dolor sit amet adipelit sed eius mtempor encid dolore</div>
                    </div>
                </div>
            </div>
            <!-- News block two -->
            <div class=""col-lg-4 news-block-two"">
                <div class=""inner-box wow fadeInUp"" data-wow-duration=""1.5s"">
                    <div class=""image"">
          ");
            WriteLiteral("              <img src=\"images/resource/news-10.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7402, "\"", 7408, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""overlay"">
                            <a class=""link-btn"" href=""blog-details.html"">
                                <i class=""icon-link""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""lower-content"">
                        <ul class=""post-meta"">
                            <li><span>Explore</span></li>
                            <li><span>Lyfestyle</span></li>
                        </ul>
                        <h4><a href=""blog-details.html"">Aspernatur aut odit fugit.</a></h4>
                        <div class=""text"">Lorem ipsum dolor sit amet adipelit sed eius mtempor encid dolore</div>
                    </div>
                </div>
            </div>
            <!-- News block two -->
            <div class=""col-lg-4 news-block-two"">
                <div class=""inner-box wow fadeInUp"" data-wow-duration=""1.5s"">
                    <div class=""image"">
          ");
            WriteLiteral("              <img src=\"images/resource/news-11.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 8485, "\"", 8491, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""overlay"">
                            <a class=""link-btn"" href=""blog-details.html"">
                                <i class=""icon-link""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""lower-content"">
                        <ul class=""post-meta"">
                            <li><span>Explore</span></li>
                            <li><span>Lyfestyle</span></li>
                        </ul>
                        <h4><a href=""blog-details.html"">Aspernatur aut odit fugit.</a></h4>
                        <div class=""text"">Lorem ipsum dolor sit amet adipelit sed eius mtempor encid dolore</div>
                    </div>
                </div>
            </div>
            <!-- News block two -->
            <div class=""col-lg-4 news-block-two"">
                <div class=""inner-box wow fadeInUp"" data-wow-duration=""1.5s"">
                    <div class=""image"">
          ");
            WriteLiteral("              <img src=\"images/resource/news-12.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 9568, "\"", 9574, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""overlay"">
                            <a class=""link-btn"" href=""blog-details.html"">
                                <i class=""icon-link""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""lower-content"">
                        <ul class=""post-meta"">
                            <li><span>Explore</span></li>
                            <li><span>Lyfestyle</span></li>
                        </ul>
                        <h4><a href=""blog-details.html"">Aspernatur aut odit fugit.</a></h4>
                        <div class=""text"">Lorem ipsum dolor sit amet adipelit sed eius mtempor encid dolore</div>
                    </div>
                </div>
            </div>
            <!-- News block two -->
            <div class=""col-lg-4 news-block-two"">
                <div class=""inner-box wow fadeInUp"" data-wow-duration=""1.5s"">
                    <div class=""image"">
          ");
            WriteLiteral("              <img src=\"images/resource/news-13.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 10651, "\"", 10657, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""overlay"">
                            <a class=""link-btn"" href=""blog-details.html"">
                                <i class=""icon-link""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""lower-content"">
                        <ul class=""post-meta"">
                            <li><span>Explore</span></li>
                            <li><span>Lyfestyle</span></li>
                        </ul>
                        <h4><a href=""blog-details.html"">Aspernatur aut odit fugit.</a></h4>
                        <div class=""text"">Lorem ipsum dolor sit amet adipelit sed eius mtempor encid dolore</div>
                    </div>
                </div>
            </div>
            <!-- News block two -->
            <div class=""col-lg-4 news-block-two"">
                <div class=""inner-box wow fadeInUp"" data-wow-duration=""1.5s"">
                    <div class=""image"">
          ");
            WriteLiteral("              <img src=\"images/resource/news-14.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 11734, "\"", 11740, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""overlay"">
                            <a class=""link-btn"" href=""blog-details.html"">
                                <i class=""icon-link""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""lower-content"">
                        <ul class=""post-meta"">
                            <li><span>Explore</span></li>
                            <li><span>Lyfestyle</span></li>
                        </ul>
                        <h4><a href=""blog-details.html"">Aspernatur aut odit fugit.</a></h4>
                        <div class=""text"">Lorem ipsum dolor sit amet adipelit sed eius mtempor encid dolore</div>
                    </div>
                </div>
            </div>
            <!-- News block two -->
            <div class=""col-lg-4 news-block-two"">
                <div class=""inner-box wow fadeInUp"" data-wow-duration=""1.5s"">
                    <div class=""image"">
          ");
            WriteLiteral("              <img src=\"images/resource/news-15.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 12817, "\"", 12823, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""overlay"">
                            <a class=""link-btn"" href=""blog-details.html"">
                                <i class=""icon-link""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""lower-content"">
                        <ul class=""post-meta"">
                            <li><span>Explore</span></li>
                            <li><span>Lyfestyle</span></li>
                        </ul>
                        <h4><a href=""blog-details.html"">Aspernatur aut odit fugit.</a></h4>
                        <div class=""text"">Lorem ipsum dolor sit amet adipelit sed eius mtempor encid dolore</div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- Subscribe section -->
<section class=""subscribe-section"">
    <div class=""container"">
        <div class=""outer-box"">
            <div class=""row"">
                <d");
            WriteLiteral("iv class=\"title-column col-lg-6\">\r\n                    <h2>Subscribe <br>to Our Newsletter</h2>\r\n                </div>\r\n                <div class=\"subscribe-form col-lg-6\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e4c18a2d92e7cda133d4a43178c7f3c4ff87af820466", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <input type=\"email\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 14240, "\"", 14248, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Your email...\"");
                BeginWriteAttribute("required", " required=\"", 14277, "\"", 14288, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <button type=\"submit\" class=\"theme-btn btn-style-six\">Subscribe Now</button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
