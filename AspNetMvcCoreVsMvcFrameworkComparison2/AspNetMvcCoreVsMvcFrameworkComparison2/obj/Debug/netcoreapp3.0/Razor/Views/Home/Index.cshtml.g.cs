#pragma checksum "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f4f5adb3b755fbc3e6056f98cc22d276be82a9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\_ViewImports.cshtml"
using AspNetMvcCoreVsMvcFrameworkComparison2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\_ViewImports.cshtml"
using AspNetMvcCoreVsMvcFrameworkComparison2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4f5adb3b755fbc3e6056f98cc22d276be82a9f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b966825864aa832587622981da608a23497fe7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetMVCCoreVsMVCFrameworkComparison2.Models.Portfolio>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\Home\Index.cshtml"
   
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4f5adb3b755fbc3e6056f98cc22d276be82a9f3782", async() => {
                WriteLiteral(@"
	<!-- Required meta tags -->
	<meta charset=""utf-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
	<link rel=""icon"" href=""./img/favicon.png"" type=""image/png"">
	<title>Portfolio</title>
	<!-- Bootstrap CSS -->
	<link rel=""stylesheet"" href=""./css/bootstrap.css"">
	<link rel=""stylesheet"" href=""./vendors/linericon/style.css"">
	<link rel=""stylesheet"" href=""./css/font-awesome.min.css"">
	<link rel=""stylesheet"" href=""./vendors/owl-carousel/owl.carousel.min.css"">
	<link rel=""stylesheet"" href=""./css/magnific-popup.css"">
	<link rel=""stylesheet"" href=""./vendors/nice-select/css/nice-select.css"">
	<!-- main css -->
	<link rel=""stylesheet"" href=""./css/style.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4f5adb3b755fbc3e6056f98cc22d276be82a9f5504", async() => {
                WriteLiteral(@"

    <!--================ Start Header Area =================-->
    <header class=""header_area"">
        <div class=""main_menu"">
            <nav class=""navbar navbar-expand-lg navbar-light"">
                <div class=""container"">
                    <!-- Brand and toggle get grouped for better mobile display -->
                    <a class=""navbar-brand logo_h"" href=""#""><img src=""./img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 1280, "\"", 1286, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
                            aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>
                    <!-- Collect the nav links, forms, and other content for toggling -->
                    <div class=""collapse navbar-collapse offset"" id=""navbarSupportedContent"">
                        <ul class=""nav navbar-nav menu_nav justify-content-end"">
                            <li class=""nav-item""><a class=""nav-link"" href=""#"">Home</a></li>
                            <li class=""nav-item""><a class=""nav-link"" href=""#"">About</a></li>
                            <li class=""nav-item""><a class=""nav-link"" href=""#"">Services</a></li>
                 ");
                WriteLiteral(@"           <li class=""nav-item active""><a class=""nav-link"" href=""#"">Portfolio</a></li>
                            <li class=""nav-item submenu dropdown"">
                                <a href=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true""
                                   aria-expanded=""false"">Pages</a>
                                <ul class=""dropdown-menu"">
                                    <li class=""nav-item""><a class=""nav-link"" href=""#"">Elements</a></li>
                                    <li class=""nav-item""><a class=""nav-link"" href=""#"">Portfolio Details</a></li>
                                </ul>
                            </li>
                            <li class=""nav-item submenu dropdown"">
                                <a href=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true""
                                   aria-expanded=""false"">Blog</a>
                                <ul clas");
                WriteLiteral(@"s=""dropdown-menu"">
                                    <li class=""nav-item""><a class=""nav-link"" href=""#"">Blog</a></li>
                                    <li class=""nav-item""><a class=""nav-link"" href=""#"">Blog Details</a></li>
                                </ul>
                            </li>
                            <li class=""nav-item""><a class=""nav-link"" href=""#"">Contact</a></li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
    </header>
    <!--================ End Header Area =================-->
    <!--================ Start Banner Area =================-->
    <section class=""banner_area"">
        <div class=""banner_inner d-flex align-items-center"">
            <div class=""container"">
                <div class=""banner_content text-center"">
                    <h2>Portfolio</h2>
                    <div class=""page_link"">
                        <a href=""#"">Home</a>
                        <a href=""#"">Por");
                WriteLiteral(@"tfolio</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================ End Banner Area =================-->
    <!--================ Start About Us Area =================-->
    <section class=""about_area section_gap"">
        <div class=""container"">
            <div class=""row justify-content-start align-items-center"">
                <div class=""col-lg-5"">
                    <div class=""about_img"">
                        <img");
                BeginWriteAttribute("class", " class=\"", 4869, "\"", 4877, 0);
                EndWriteAttribute();
                WriteLiteral(" src=\"./img/about-us.png\"");
                BeginWriteAttribute("alt", " alt=\"", 4903, "\"", 4909, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>

                <div class=""offset-lg-1 col-lg-5"">
                    <div class=""main_title text-left"">
                        <h2>
                            let’s <br>
                            Introduce about <br>
                            myself
                        </h2>
                        <p>
                            Full name: ");
#nullable restore
#line 106 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\Home\Index.cshtml"
                                  Write(Model.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            Age: ");
#nullable restore
#line 109 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\Home\Index.cshtml"
                            Write(Model.Age);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            Email: ");
#nullable restore
#line 112 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\Home\Index.cshtml"
                              Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            Educational institution: ");
#nullable restore
#line 115 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\Home\Index.cshtml"
                                                Write(Model.EducationalInstitution);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            Workplace: ");
#nullable restore
#line 118 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\Home\Index.cshtml"
                                  Write(Model.WorkPlace);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            Job: ");
#nullable restore
#line 121 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\Home\Index.cshtml"
                            Write(Model.Job);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            Achievements: ");
#nullable restore
#line 124 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\Home\Index.cshtml"
                                     Write(Model.Achievements);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </p>
                        <p>
                            Is give may shall likeness made yielding spirit a itself together created after sea
                            is in beast beginning signs open god you're gathering whose gathered cattle let.
                            Creature whales fruit unto meat the life beginning all in under give two.
                        </p>
                        <a class=""primary_btn"" href=""#""><span>Download CV</span></a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================ End About Us Area =================-->
    <!--================Start Portfolio Area =================-->
    <section class=""portfolio_area section_gap_top"" id=""portfolio"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""main_title text-left"">
                        <h2>
                         ");
                WriteLiteral(@"   quality work <br>
                            Recently done project
                        </h2>
                    </div>
                </div>
            </div>

            <div class=""filters-content"">
                <div class=""row portfolio-grid justify-content-center"">
");
#nullable restore
#line 154 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\Home\Index.cshtml"
                      foreach(var item in Model.WorkExamples)
                     {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-lg-4 col-md-6 portfolio_box\">\r\n                            <div class=\"single_portfolio\">\r\n                                <img class=\"img-fluid w-100\"");
                BeginWriteAttribute("src", " src=", 7638, "", 7658, 1);
#nullable restore
#line 158 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\Home\Index.cshtml"
WriteAttributeValue("", 7643, item.ImagePath, 7643, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 7658, "\"", 7664, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <div class=""overlay""></div>
                                <a href=""#"" class=""img-gal"">
                                    <div class=""icon"">
                                        <span class=""lnr lnr-cross""></span>
                                    </div>
                                </a>
                            </div>
                        </div>
");
#nullable restore
#line 167 "C:\Users\Admin\source\repos\AspNetMvcCoreVsMvcFrameworkComparison2\AspNetMvcCoreVsMvcFrameworkComparison2\Views\Home\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
            </div>
        </div>
    </section>
    <!--================End Portfolio Area =================-->

    <!--================Footer Area =================-->
    <footer class=""footer_area"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-12"">
                    <div class=""footer_top flex-column"">
                        <div class=""footer_logo"">
                            <a href=""#"">
                                <img src=""./img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 8669, "\"", 8675, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </a>
                            <h4>Follow Me</h4>
                        </div>
                        <div class=""footer_social"">
                            <a href=""#""><i class=""fa fa-facebook""></i></a>
                            <a href=""#""><i class=""fa fa-twitter""></i></a>
                            <a href=""#""><i class=""fa fa-dribbble""></i></a>
                            <a href=""#""><i class=""fa fa-behance""></i></a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row footer_bottom justify-content-center"">
                <p class=""col-lg-8 col-sm-12 footer-text"">
                    <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                    Copyright &copy;
                    <script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class=""fa fa-heart-o"" aria-hidden=""true""></");
                WriteLiteral(@"i> by <a href=""https://colorlib.com"" target=""_blank"">Colorlib</a>
                    <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                </p>
            </div>
        </div>
    </footer>
    <!--================End Footer Area =================-->
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""./js/jquery-3.2.1.min.js""></script>
    <script src=""./js/popper.js""></script>
    <script src=""./js/bootstrap.min.js""></script>
    <script src=""./js/stellar.js""></script>
    <script src=""./js/jquery.magnific-popup.min.js""></script>
    <script src=""./vendors/nice-select/js/jquery.nice-select.min.js""></script>
    <script src=""./vendors/isotope/imagesloaded.pkgd.min.js""></script>
    <script src=""./vendors/isotope/isotope-min.js""></script>
    <script src=""./vendors/owl-carousel/owl.carousel.min.js""></script>
    <script src=""./js/jquery.ajaxchimp.min.js""></script>
    <script src=""");
                WriteLiteral(@"./js/mail-script.js""></script>
    <!--gmaps Js-->
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyCjCGmQ0Uq4exrzdcL6rvxywDDOvfAu6eE""></script>
    <script src=""./js/gmaps.min.js""></script>
    <script src=""./js/theme.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetMVCCoreVsMVCFrameworkComparison2.Models.Portfolio> Html { get; private set; }
    }
}
#pragma warning restore 1591