#pragma checksum "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f61ba41fcf32c9d857f12183d5c14fb91b3cca5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Area_Index), @"mvc.1.0.view", @"/Views/Area/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Area/Index.cshtml", typeof(AspNetCore.Views_Area_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f61ba41fcf32c9d857f12183d5c14fb91b3cca5d", @"/Views/Area/Index.cshtml")]
    public class Views_Area_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IP_Project.Models.FloorPlanViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/heatmap.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/floor0.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("floorplan"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("groundfloor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int floor = Model.FloorId;

#line default
#line hidden
            BeginContext(172, 1278, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f61ba41fcf32c9d857f12183d5c14fb91b3cca5d6210", async() => {
                BeginContext(178, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(184, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f61ba41fcf32c9d857f12183d5c14fb91b3cca5d6595", async() => {
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
                BeginContext(248, 1195, true);
                WriteLiteral(@"
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.8.2/css/all.css"">
    <!-- Google Fonts -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap"">
    <!-- Bootstrap core CSS -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.4.1/css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- Material Design Bootstrap -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.13.0/css/mdb.min.css"" rel=""stylesheet"">
    <!-- JQuery -->
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <!-- Bootstrap tooltips -->
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.4/umd/popper.min.js""></script>
    <!-- Bootstrap core JavaScript -->
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.4.1/js/bootstrap.min.js");
                WriteLiteral("\"></script>\r\n    <!-- MDB core JavaScript -->\r\n    <script type=\"text/javascript\" src=\"https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.13.0/js/mdb.min.js\"></script>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1450, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1452, 5305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f61ba41fcf32c9d857f12183d5c14fb91b3cca5d10081", async() => {
                BeginContext(1458, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1465, 23, false);
#line 27 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
Write(Html.Partial("_Header"));

#line default
#line hidden
                EndContext();
                BeginContext(1488, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1494, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f61ba41fcf32c9d857f12183d5c14fb91b3cca5d10817", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1538, 530, true);
                WriteLiteral(@"

    <div class=""container"">
        <div class=""all-floors"">
            <button class=""btn floorBtn"" onclick=""setFloor(0)"">Ground floor</button>
            <button class=""btn floorBtn"" onclick=""setFloor(1)"">First floor</button>
            <button class=""btn floorBtn"" onclick=""setFloor(2)"">Second floor</button>
            <button class=""btn floorBtn"" onclick=""setFloor(3)"">Third floor</button>
        </div>
        <div class=""card own-card"">
            <div class=""map"" id=""groundfloor-map"">
                ");
                EndContext();
                BeginContext(2068, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f61ba41fcf32c9d857f12183d5c14fb91b3cca5d12702", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2133, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
                 foreach (var dim in Model.Dimensions)
                {

                    string left = dim.Width + "%";
                    string top = dim.Height + "%";
                    string error = "rgb(255,175,6)";
                    string yellow = "rgba(253,224,139,1)"; //12 people
                    string orange = "rgba(246,141,92,1)"; // 15 people
                    string red = "rgba(214,62,80,1)";  // 20 people
                    string neutral = "rgba(251,247,193,1)"; //10 people
                    string lightGreen = "rgba(230,236,153,1)"; // 8 people
                    string green = "rgba(154,208,147,1)"; // 5 people
                    string blue = "rgba(51,137,189,1)"; // 0 people
                    var area = Model.Areas.Where(ar => ar.AreaNumber == dim.AreaNumber).FirstOrDefault();
                    string color1, color2, color3;
                    if (area != null)
                    {
                        if (area.Amount >= 20)
                        {
                            color1 = red; color2 = orange; color3 = yellow;
                        }
                        else if (area.Amount >= 15)
                        {
                            color1 = orange; color2 = yellow; color3 = neutral;
                        }
                        else if (area.Amount >= 12)
                        {
                            color1 = yellow; color2 = neutral; color3 = neutral;
                        }
                        else if (area.Amount >= 10)
                        {
                            color1 = neutral; color2 = lightGreen; color3 = lightGreen;
                        }
                        else if (area.Amount >= 8)
                        {
                            color1 = lightGreen; color2 = green; color3 = blue;

                        }
                        else if (area.Amount >= 5)
                        {
                            color1 = green; color2 = green; color3 = blue;

                        }
                        else if (area.Amount > 0)
                        {
                            color1 = green; color2 = blue; color3 = blue;

                        }
                        else
                        {
                            color1 = blue; color2 = blue; color3 = blue;

                        }
                    }
                    else
                    {
                        color1 = error; color2 = error; color3 = error;

                    }
                    

#line default
#line hidden
#line 99 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
                     if (area == null)
                    {

#line default
#line hidden
                BeginContext(4793, 45, true);
                WriteLiteral("                        <a class=\"mark-point\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 4838, "\"", 4959, 12);
                WriteAttributeValue("", 4846, "left:", 4846, 5, true);
#line 101 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
WriteAttributeValue("", 4851, left, 4851, 5, false);

#line default
#line hidden
                WriteAttributeValue("", 4856, ";top:", 4856, 5, true);
#line 101 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
WriteAttributeValue("", 4861, top, 4861, 4, false);

#line default
#line hidden
                WriteAttributeValue("", 4865, ";position:absolute;background:", 4865, 30, true);
                WriteAttributeValue(" ", 4895, "radial-gradient(circle,", 4896, 24, true);
#line 101 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
WriteAttributeValue(" ", 4919, color1, 4920, 7, false);

#line default
#line hidden
                WriteAttributeValue(" ", 4927, "0%,", 4928, 4, true);
#line 101 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
WriteAttributeValue(" ", 4931, color2, 4932, 7, false);

#line default
#line hidden
                WriteAttributeValue(" ", 4939, "37%,", 4940, 5, true);
#line 101 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
WriteAttributeValue(" ", 4944, color3, 4945, 7, false);

#line default
#line hidden
                WriteAttributeValue(" ", 4952, "100%);", 4953, 7, true);
                EndWriteAttribute();
                BeginContext(4960, 34, true);
                WriteLiteral("><i class=\"fas fa-plus\"></i></a>\r\n");
                EndContext();
#line 102 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(5066, 45, true);
                WriteLiteral("                        <a class=\"mark-point\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 5111, "\"", 5232, 12);
                WriteAttributeValue("", 5119, "left:", 5119, 5, true);
#line 105 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
WriteAttributeValue("", 5124, left, 5124, 5, false);

#line default
#line hidden
                WriteAttributeValue("", 5129, ";top:", 5129, 5, true);
#line 105 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
WriteAttributeValue("", 5134, top, 5134, 4, false);

#line default
#line hidden
                WriteAttributeValue("", 5138, ";position:absolute;background:", 5138, 30, true);
                WriteAttributeValue(" ", 5168, "radial-gradient(circle,", 5169, 24, true);
#line 105 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
WriteAttributeValue(" ", 5192, color1, 5193, 7, false);

#line default
#line hidden
                WriteAttributeValue(" ", 5200, "0%,", 5201, 4, true);
#line 105 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
WriteAttributeValue(" ", 5204, color2, 5205, 7, false);

#line default
#line hidden
                WriteAttributeValue(" ", 5212, "37%,", 5213, 5, true);
#line 105 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
WriteAttributeValue(" ", 5217, color3, 5218, 7, false);

#line default
#line hidden
                WriteAttributeValue(" ", 5225, "100%);", 5226, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 5233, "\"", 5290, 6);
                WriteAttributeValue("", 5243, "showDetails(\'", 5243, 13, true);
#line 105 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
WriteAttributeValue("", 5256, area.Amount, 5256, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 5268, "\',", 5268, 2, true);
                WriteAttributeValue(" ", 5270, "\'", 5271, 2, true);
#line 105 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
WriteAttributeValue("", 5272, area.AreaNumber, 5272, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 5288, "\')", 5288, 2, true);
                EndWriteAttribute();
                BeginContext(5291, 34, true);
                WriteLiteral("><i class=\"fas fa-plus\"></i></a>\r\n");
                EndContext();
#line 106 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
                    }

#line default
#line hidden
#line 106 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(5367, 826, true);
                WriteLiteral(@"            </div>
            <div class=""card-body content-card"">
                <h2 class=""card-title"" id=""floor-title"">Ground floor</h2>
            </div>
        </div>
    </div>

    <!-- Modal -->
    <div class=""modal fade"" id=""details-camera"" tabindex=""-1"" role=""dialog""
         aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Create camera</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
                EndContext();
                BeginContext(6193, 310, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f61ba41fcf32c9d857f12183d5c14fb91b3cca5d22968", async() => {
                    BeginContext(6199, 297, true);
                    WriteLiteral(@"
                        <label>Area number</label>
                        <input class=""form-control"" id=""area-number"" disabled />

                        <label>Amount of people</label>
                        <input class=""form-control"" id=""area-amount"" disabled />
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6503, 247, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(6757, 63, true);
            WriteLiteral("\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n       load(");
            EndContext();
            BeginContext(6821, 5, false);
#line 145 "C:\Users\Indy\source\repos\IP-Project\IP-Project\Views\Area\Index.cshtml"
       Write(floor);

#line default
#line hidden
            EndContext();
            BeginContext(6826, 1045, true);
            WriteLiteral(@");
    });


    function load(x) {
        let src = """";
        let innerHtml = """";
        switch (x) {
            case 0:
                src = ""/img/floor0.png"";
                innerHtml = ""Ground Floor"";
                break;
            case 1:
                src = ""/img/floor1.png"";
                innerHtml = ""First Floor"";
                break;
            case 2:
                src = ""/img/floor2.png"";
                innerHtml = ""Second Floor"";
                break;
            case 3:
                src = ""/img/floor3.png"";
                innerHtml = ""Third Floor"";
                break;
        }
        $(""#groundfloor"").attr(""src"", src)
        $(""#floor-title"").text(innerHtml);
    }

    function setFloor(floor) {
        window.location.href = `/Area/Index/${floor}`;
    }

    function showDetails(amount, areanumber) {
        $(""#area-number"").val(areanumber);
        $(""#area-amount"").val(amount);
        $(""#details-camera"").modal('show');
 ");
            WriteLiteral("   }\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IP_Project.Models.FloorPlanViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
