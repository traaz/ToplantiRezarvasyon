#pragma checksum "C:\Fabrika Yazilimlari\Web\CalendarAppMVC\CalendarAppMVC\Views\CalendarPage\CalendarView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e3bb62cafa03b3c1362c976f554d0278138c453"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalendarPage_CalendarView), @"mvc.1.0.view", @"/Views/CalendarPage/CalendarView.cshtml")]
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
#line 1 "C:\Fabrika Yazilimlari\Web\CalendarAppMVC\CalendarAppMVC\Views\_ViewImports.cshtml"
using CalendarAppMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Fabrika Yazilimlari\Web\CalendarAppMVC\CalendarAppMVC\Views\_ViewImports.cshtml"
using CalendarAppMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3bb62cafa03b3c1362c976f554d0278138c453", @"/Views/CalendarPage/CalendarView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c6ec39ecdb684fa48dd97d0804b157662cf8da5", @"/Views/_ViewImports.cshtml")]
    public class Views_CalendarPage_CalendarView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CalendarAppMVC.Data.Appointment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/timegrid/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/bootstrap/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/core/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/moment/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/moment-timezone/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/timegrid/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/interaction/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/package/src/xml2json.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/bootstrap/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/core/locales/tr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Fabrika Yazilimlari\Web\CalendarAppMVC\CalendarAppMVC\Views\CalendarPage\CalendarView.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"

    <link href=""/lib/fullcalendar/core/main.css"" rel=""stylesheet"" />
    <link href=""https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" integrity=""sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN"" crossorigin=""anonymous"">
    <link href=""/lib/fullcalendar/daygrid/main.css"" rel=""stylesheet"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e3bb62cafa03b3c1362c976f554d0278138c4538278", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e3bb62cafa03b3c1362c976f554d0278138c4539456", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/tempusdominus-bootstrap-4/5.39.0/css/tempusdominus-bootstrap-4.min.css"" integrity=""sha512-3JRrEUwaCkFUBLK1N8HehwQgu8e23jTH4np5NHOmQOobuC4ROQxFwFgBLTnhcnQRMs84muMh0PnnwXlPq5MGjg=="" crossorigin=""anonymous"" />





");
            }
            );
            WriteLiteral(@"

<div class=""modal fade"" id=""detailModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Randevu Detaylar??</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3bb62cafa03b3c1362c976f554d0278138c45311533", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""form-group col-md-6"">
                            <label class=""form-control-label"">Ba??lang???? Tarihi :</label>

                            <div class=""input-group date"" id=""datetimepicker1"" data-target-input=""nearest"">
                                <input disabled id=""inputStartDateDetail"" type=""text"" class=""form-control datetimepicker-input"" data-target=""#datetimepicker1"" />
                                <div class=""input-group-append"" data-target=""#datetimepicker1"" data-toggle=""datetimepicker"">
                                    <div class=""input-group-text""><i class=""fa fa-calendar""></i></div>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group col-md-6"">
                            <label class=""form-control-label"">Biti?? Tarihi :</label>

                            <div class=""input-group date"" id=""datetimepicke");
                WriteLiteral(@"r2"" data-target-input=""nearest"">
                                <input disabled id=""inputEndDateDetail"" type=""text"" class=""form-control datetimepicker-input"" data-target=""#datetimepicker2"" />
                                <div class=""input-group-append"" data-target=""#datetimepicker2"" data-toggle=""datetimepicker"">
                                    <div class=""input-group-text""><i class=""fa fa-calendar""></i></div>
                                </div>
                            </div>
                        </div>



                    </div>
                    <div class=""column"">
                        <div class=""form-group"">
                            <label class=""col-form-label"">Ba??l??k :</label>

                            <input disabled id=""inputTitleDetail"" type=""text"" class=""form-control "" />

                        </div>
                        <div class=""form-group"">
                            <label class=""col-form-label"">A????klama :</label>

                   ");
                WriteLiteral(@"         <input disabled id=""inputDescriptionDetail"" type=""text"" class=""form-control "" />

                        </div>
                        <div class=""form-group"">
                            <label class=""col-form-label"">D???? Firma Ad?? :</label>
                            <input disabled id=""inputCompanyDetail"" type=""text"" class=""form-control"" />

                        </div>
                        <div class=""form-group"">
                            <label class=""col-form-label"">Rezervasyon Sahibi :</label>
                            <input disabled id=""inputOwnerDetail"" type=""text"" class=""form-control""></input>

                        </div>
                        <div class=""form-group"">
                            <label class=""col-form-label"">Kategori :</label>
                            <select disabled id=""inputCategoryDetail"" type=""text"" class=""form-control""></select>

                        </div>


                    </div>


                ");
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
            WriteLiteral(@"

            </div>
            <div class=""modal-footer"">

                <button id=""btnDelete"" type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Sil</button>
                <button id=""btnUpdate"" type=""button"" class=""btn btn-primary"" style=""background-color: #dc3c3c"">G??ncelle</button>
            </div>
        </div>
    </div>
</div>

<div>

");
#nullable restore
#line 108 "C:\Fabrika Yazilimlari\Web\CalendarAppMVC\CalendarAppMVC\Views\CalendarPage\CalendarView.cshtml"
      
        var id = @Context.Request.RouteValues["id"];


        switch (id)
        {
            case "1":

                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h2>Toplant?? Odas?? - 2 (U Masa)</h2>\r\n                    <br />\r\n                ");
#nullable restore
#line 119 "C:\Fabrika Yazilimlari\Web\CalendarAppMVC\CalendarAppMVC\Views\CalendarPage\CalendarView.cshtml"
                       
                break;
            case "2":
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h2>Toplant?? Odas?? - 1 (K????e)</h2>\r\n                    <br />\r\n                ");
#nullable restore
#line 125 "C:\Fabrika Yazilimlari\Web\CalendarAppMVC\CalendarAppMVC\Views\CalendarPage\CalendarView.cshtml"
                       
                break;
            case "3":
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h2>Ofis Toplant?? Odas??</h2>\r\n                    <br />\r\n                ");
#nullable restore
#line 131 "C:\Fabrika Yazilimlari\Web\CalendarAppMVC\CalendarAppMVC\Views\CalendarPage\CalendarView.cshtml"
                       
                break;
            case "4":
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h2>E??itim Odas??</h2>\r\n                    <br />\r\n                ");
#nullable restore
#line 137 "C:\Fabrika Yazilimlari\Web\CalendarAppMVC\CalendarAppMVC\Views\CalendarPage\CalendarView.cshtml"
                       
                break;
            case "5":
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h2>Seminer Salonu - 2</h2>\r\n                    <br />\r\n                ");
#nullable restore
#line 143 "C:\Fabrika Yazilimlari\Web\CalendarAppMVC\CalendarAppMVC\Views\CalendarPage\CalendarView.cshtml"
                       
                break;
            case "6":
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h2>Seminer Salonu - 1</h2>\r\n                    <br />\r\n                ");
#nullable restore
#line 149 "C:\Fabrika Yazilimlari\Web\CalendarAppMVC\CalendarAppMVC\Views\CalendarPage\CalendarView.cshtml"
                       
                break;

            default:
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h1>\r\n                        /h1>\r\n                ");
#nullable restore
#line 156 "C:\Fabrika Yazilimlari\Web\CalendarAppMVC\CalendarAppMVC\Views\CalendarPage\CalendarView.cshtml"
                       
                break;
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div id=\"calendar\">\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.24.0/moment.min.js\"></script>\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/moment-timezone/0.5.28/moment-timezone-with-data-10-year-range.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3bb62cafa03b3c1362c976f554d0278138c45319931", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3bb62cafa03b3c1362c976f554d0278138c45321031", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3bb62cafa03b3c1362c976f554d0278138c45322131", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"/lib/fullcalendar/daygrid/main.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3bb62cafa03b3c1362c976f554d0278138c45323298", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3bb62cafa03b3c1362c976f554d0278138c45324398", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3bb62cafa03b3c1362c976f554d0278138c45325502", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3bb62cafa03b3c1362c976f554d0278138c45326606", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3bb62cafa03b3c1362c976f554d0278138c45327706", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tempusdominus-bootstrap-4/5.39.0/js/tempusdominus-bootstrap-4.min.js"" integrity=""sha512-k6/Bkb8Fxf/c1Tkyl39yJwcOZ1P4cRrJu77p83zJjN2Z55prbFHxPs9vN7q3l3+tSMGPDdoH51AEU8Vgo1cgAA=="" crossorigin=""anonymous""></script>


    <script>

        document.addEventListener('DOMContentLoaded', function () {

            var calendarE1 = document.getElementById('calendar');
            var selectedEvent = null;
            var events1 = [];

            var calendar = new FullCalendar.Calendar(calendarE1, {


                plugins: ['interaction', 'dayGrid', 'timeGrid', 'bootstrap', 'momentTimezone'],
                timeZone: 'Europe/Istanbul',
                themeSystem: 'bootstrap4',
                bootstrapFontAwesome: {

                },
                locale: ""tr"",
                header: {

                    left: 'prev, next',

                    center: '',
                    right: 'today, timeGridDay, timeGridThreeDay'");
                WriteLiteral(@"



                },
                footer: {
                    center: 'addEventButton'
                },


                minTime: '09:00:00',
                maxTime: '18:00:00',
                contentHeight: 500,

                handleWindowResize: true,
                slotDuration: '00:30:00',
                slotLabelFormat: {
                    hour: '2-digit',
                    minute: '2-digit'
                },
                allDaySlot: false,
                eventStartEditable: true,
                snapDuration: '00:15:00',
                eventTextColor: 'White',
                eventBackgroundColor: '#dc3c3c',
                eventBorderColor: 'white',
                businessHours: [
                    {
                        daysOfWeek: [1, 2, 3, 4, 5],
                        startTime: '09:00',
                        endTime: '18:00'
                    },
                    {
                        daysOfWeek: [6],
                    ");
                WriteLiteral(@"    startTime: '09:00',
                        endTime: '12:30',

                    }, {
                        daysOfWeek: [0],
                        endTime: '09:00'

                    }
                ],
                selectConstraint: ""businessHours"",

                views: {

                    timeGridThreeDay: {

                        type: 'timeGrid',


                        duration: { days: 3 },



                    },

                    timeGridOneDay: {

                        type: 'timeGrid',

                        duration: { days: 1 },



                    }

                },
                events: events1

                ,
                eventClick: function (info) {
                    $('#inputStartDateDetail').val(moment(info.event.start).format('DD/MM/YY HH:mm'));
                    $('#inputEndDateDetail').val(moment(info.event.end).format('DD/MM/YY HH:mm'));
                    $('#inputTitleDetail').val(info.event");
                WriteLiteral(@".extendedProps.Title);
                    $('#inputDescriptionDetail').val(info.event.extendedProps.Description);
                    $('#inputCompanyDetail').val(info.event.extendedProps.Company);
                    $('#inputOwnerDetail').val(info.event.extendedProps.Owner);
                    $('#inputOwnerCategory').val(info.event.extendedProps.Category);
                    $('#detailModal').modal();
                },
                selectable: true,
                select: function (selectionInfo) {

                    selectedEvent = {
                        id: 0,
                        start: moment(selectionInfo.start),
                        end: moment(selectionInfo.end),
                        Title: """",
                        Description: """",
                        Company: """",
                        Owner: """",
                        Category: """"


                    }
                    openAddOrUpdateModal();

                },
                eventStar");
                WriteLiteral(@"tEditable : false,
                eventDurationEditable : false,
                editable: false,
                buttonText: {



                    today: 'B',

                    month: 'Ay',

                    week: 'Hafta',

                    day: '1 G??n',

                    list: 'Liste',

                    timeGridThreeDay: ""3 G??n"",

                    timeGridOneDay: ""1 G??n""



                },
                titleFormat: {

                    month: 'numeric',
                    day: 'numeric',
                    weekday: 'short'

                },
                columnHeaderFormat: {
                    day: 'numeric',
                    month: 'numeric',
                    weekday: 'long'

                },
                defaultView: 'timeGridDay',




                eventOverlap: function (stillEvent, movingEvent) {
                    return stillEvent.allDay && movingEvent.allDay;
                },
                eventConst");
                WriteLiteral(@"raint: {
                    startTime: '09:00',
                    endTime: '18:00'

                },
                //eventAllow: function (dropInfoEvent, draggedEvent) {

                //},
                //eventDragStart: function (info) {
                //    console.log('ba??lad??.');
                //},
                //eventDragStop: function (info) {
                //    alert(""Emin Misiniz ? "");

                //},
                //drop: function (eventDropInfo) {
                //    console.log(""droped"");
                //}



            });




            calendar.render();

            getAppointments();


            function getAppointments() {
                var url = window.location.pathname;
                var id = url.substring(url.lastIndexOf('/') + 1);
                $.ajax({
                    type: 'GET',
                    url: 'http://korteksdev/PortalWebApi/RezervasyonListesi/Getir/',
                    data: { id: id },
  ");
                WriteLiteral(@"                  ContentType: ""application/rss+xml"",
                    dataType: ""xml"",
                    success: function (xml) {

                        var bast = $(xml).find(""RezervasyonListesi"");
                        console.log(typeof (bast));
                        console.log(bast.length);

                        $.each(bast, function (index, event) {



                            var bastarihi = $(this).find(""BasTarih"").text();
                            var bittarihi = $(this).find(""BitTarih"").text();
                            var baslik = $(this).find(""Baslik"").text();
                            var aciklama = $(this).find('Aciklama').text();
                            var disfirma = $(this).find(""DisFirma"").text();
                            var rsahibi = $(this).find(""RezervasyonSahibi"").text();


                            events1.push({
                                start: bastarihi,
                                end: bittarihi,
                   ");
                WriteLiteral(@"             title: baslik,
                                Title: baslik,
                                Company: disfirma,
                                Description: aciklama,
                                Owner: rsahibi
                            });



                        });

                        calendar.addEventSource(events1);











                        //console.log(response);
                        //json = $.xml2json(response);
                        //console.log(json);

                        //$('#document').each(function (index, item) {

                        //    // each iteration
                        //    var result = item.Aciklama;

                        //    console.log(result);
                        //});

                    },
                    error: function (req, status, error) {
                        console.log(status);
                    }

                });
            }

            //function s");
                WriteLiteral(@"aveAppointment() {
            //    var dateStr = document.getElementById('inputStartDate').value;
            //    var date = new Date(dateStr + 'T09:00:00'); // will be in local time

            //    if (!isNaN(date.valueOf())) { // valid?
            //        calendar.addEvent({
            //            title: 'dynamic event',
            //            start: date,

            //        });
            //        alert('Great. Now, update your database...');
            //    } else {
            //        alert('Invalid date.');
            //    }

            //}



            $('#btnSave').click(function () {
                if (document.getElementById('inputTitle').value == """" || document.getElementById('inputDescription').value == """") {
                    console.log(document.getElementById('inputStartDate').value);
                    var error1 = alertify.error(""Zorunlu Alanlar?? Doldurunuz !"");
                    error1.delay(1.5);
                } else if (documen");
                WriteLiteral(@"t.getElementById('inputStartDate').value > document.getElementById('inputEndDate').value) {
                    var error2 = alertify.error(""Toplant??n??n sona erme zaman??, ba??lang???? zaman??ndan erken olamaz. "");
                    error2.delay(1.5);


                } else {
                    saveAppointment();

                }

            });


            function openAddOrUpdateModal() {

                if (selectedEvent != null) {
                    $('#inputStartDate').val(selectedEvent.start.format('DD/MM/YY HH:mm'));
                    $('#inputEndDate').val(selectedEvent.end.format('DD/MM/YY HH:mm'));
                    $('#inputTitle').val(selectedEvent.Title);
                    $('#inputDescription').val(selectedEvent.Description);
                    $('#inputCompany').val(selectedEvent.Company);
                    $('#inputOwner').val(selectedEvent.Owner);
                }

                $('#saveModal').modal();
            }



        });





  ");
                WriteLiteral("      $(function () {\r\n            $(\'#datetimepicker1,#datetimepicker2\').datetimepicker({\r\n                locale: \'tr\',\r\n                format: \'DD/MM/YY HH:mm\',\r\n            });\r\n        });\r\n\r\n\r\n\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CalendarAppMVC.Data.Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
