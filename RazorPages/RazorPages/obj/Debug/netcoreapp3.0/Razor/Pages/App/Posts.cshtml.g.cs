#pragma checksum "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6623cf0faf94c35d6d4e09bd10ad2a1e5e06ecb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPages.Pages.App.Pages_App_Posts), @"mvc.1.0.razor-page", @"/Pages/App/Posts.cshtml")]
namespace RazorPages.Pages.App
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
#line 1 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\_ViewImports.cshtml"
using RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6623cf0faf94c35d6d4e09bd10ad2a1e5e06ecb0", @"/Pages/App/Posts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb4d15e82bf516f895a84b5c4d83ae504087504", @"/Pages/_ViewImports.cshtml")]
    public class Pages_App_Posts : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/App/AddPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Your comment:"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
  
    ViewData["Title"] = "Posts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Posts</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6623cf0faf94c35d6d4e09bd10ad2a1e5e06ecb05009", async() => {
                WriteLiteral("Add new post");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
 foreach(var post in Model.Posts)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"post w-50 h-auto\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6623cf0faf94c35d6d4e09bd10ad2a1e5e06ecb06470", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 253, "~/", 253, 2, true);
#nullable restore
#line 12 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
AddHtmlAttributeValue("", 255, post.ImageUrl, 255, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"description\">\r\n            <p><b>");
#nullable restore
#line 14 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
             Write(post.User.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n            <p>");
#nullable restore
#line 15 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
          Write(post.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"likes\">\r\n");
#nullable restore
#line 18 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
             if (Model.CurrentUser.LikedPosts.LikedPostListPosts.SingleOrDefault(postlist => postlist.PostId == post.Id) != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button style=\"color: red;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 639, "\"", 712, 10);
            WriteAttributeValue("", 649, "unlike({", 649, 8, true);
            WriteAttributeValue(" ", 657, "postId:", 658, 8, true);
            WriteAttributeValue(" ", 665, "\'", 666, 2, true);
#nullable restore
#line 20 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
WriteAttributeValue("", 667, post.Id, 667, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 675, "\',", 675, 2, true);
            WriteAttributeValue(" ", 677, "userId:", 678, 8, true);
            WriteAttributeValue(" ", 685, "\'", 686, 2, true);
#nullable restore
#line 20 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
WriteAttributeValue("", 687, Model.CurrentUser.Id, 687, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 708, "\'", 708, 1, true);
            WriteAttributeValue(" ", 709, "})", 710, 3, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-heart\"></i></button>\r\n");
#nullable restore
#line 21 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button style=\"color: black;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 846, "\"", 917, 10);
            WriteAttributeValue("", 856, "like({", 856, 6, true);
            WriteAttributeValue(" ", 862, "postId:", 863, 8, true);
            WriteAttributeValue(" ", 870, "\'", 871, 2, true);
#nullable restore
#line 24 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
WriteAttributeValue("", 872, post.Id, 872, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 880, "\',", 880, 2, true);
            WriteAttributeValue(" ", 882, "userId:", 883, 8, true);
            WriteAttributeValue(" ", 890, "\'", 891, 2, true);
#nullable restore
#line 24 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
WriteAttributeValue("", 892, Model.CurrentUser.Id, 892, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 913, "\'", 913, 1, true);
            WriteAttributeValue(" ", 914, "})", 915, 3, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-heart\"></i></button>\r\n");
#nullable restore
#line 25 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>");
#nullable restore
#line 26 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
             Write(post.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"comments\">\r\n");
#nullable restore
#line 29 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
             foreach(var comment in post.Comments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"comment\">\r\n                    <p><b>");
#nullable restore
#line 32 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
                     Write(comment.User.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                    <p>");
#nullable restore
#line 33 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
                  Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <hr />\r\n");
#nullable restore
#line 36 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6623cf0faf94c35d6d4e09bd10ad2a1e5e06ecb013319", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6623cf0faf94c35d6d4e09bd10ad2a1e5e06ecb013590", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 39 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.NewComment);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("   \r\n            <br />\r\n            <input type=\"hidden\" name=\"postId\"");
                BeginWriteAttribute("value", " value=\"", 1531, "\"", 1547, 1);
#nullable restore
#line 41 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
WriteAttributeValue("", 1539, post.Id, 1539, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"submit\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 45 "C:\Users\Admin\Documents\_STEP_ASP.NET\RazorPages\RazorPages\Pages\App\Posts.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .description{
        padding: 10px;
        border: 1px solid black;
    }
    .likes{
        background-color: transparent;
    }
</style>

<script>
    function like(options) {
        $.ajax({
            method: ""PUT"",
            url: ""/App/Posts?handler=Like"",
            beforeSend: function (xhr) {
                            xhr.setRequestHeader(""XSRF-TOKEN"",
                                $('input:hidden[name=""__RequestVerificationToken""]').val());
            },
            data: {
                postId: options.postId,
                userId: options.userId
            },
            success(){
                $(this).css(""color"", ""red"");
            }
        });
    }

    function unlike(options) {
        $.ajax({
            method: ""PUT"",
            url: ""/App/Posts?handler=Unlike"",
            beforeSend: function (xhr) {
                            xhr.setRequestHeader(""XSRF-TOKEN"",
                                $('input:hidden[name=""");
            WriteLiteral(@"__RequestVerificationToken""]').val());
                        },
            data: {
                postId: options.postId,
                userId: options.userId
            },
            success(){
                $(this).css(""color"", ""black"");
            }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPages.Pages.App.PostsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPages.Pages.App.PostsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPages.Pages.App.PostsModel>)PageContext?.ViewData;
        public RazorPages.Pages.App.PostsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591