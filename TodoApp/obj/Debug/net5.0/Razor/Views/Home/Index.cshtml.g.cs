#pragma checksum "D:\TT\TodoApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc41d7a20bdba0a29eca68eeab94d64e546a7e00"
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
#line 1 "D:\TT\TodoApp\Views\_ViewImports.cshtml"
using TodoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TT\TodoApp\Views\_ViewImports.cshtml"
using TodoApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc41d7a20bdba0a29eca68eeab94d64e546a7e00", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e792f848ddb1c77f0fb0ebf2bd3f0066a55b0d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/img/eth.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:30px; height:30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/img/BNB.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/img/AC3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/img/alqo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/img/Aion.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TT\TodoApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"">
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""></script>

<div class=""text-center"">
    <div class=""container"" style=""background-color: #F8F8F9; width: 700px; border: none; "">
        <div class=""d-flex"">
            <span>SWAP </span>
            <div style=""flex-grow: 1""></div>

            <!--Button setting-->
            <button type=""button"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#mySetting"" style=""background-color: #f2f2f2"">
                <i class=""bi bi-gear"" style=""font-size:20px;color:black; ""></i>
            </button>
            <!--0000-->

        </div>
        <div class=""container"" style=""border: none; background-color:#FFFFFF"">
            <div class=""d-flex"">
                <span>From</span>
                <div style=""flex-grow:");
            WriteLiteral(@"1""></div>
                <span>Use Max</span>
            </div>
            <div class=""d-flex"">
                <span>
                    0
                </span>

                <div style=""flex-grow:1""></div>
                <!--Button Select Token-->
                <div class=""bn-input-md "">
                    <button type=""button"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#myToken"" style=""background-color: #f2f2f2"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc41d7a20bdba0a29eca68eeab94d64e546a7e006861", async() => {
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
            WriteLiteral(@"
                    </button>
                 <!--00000000-->  
                    <input data-bn-type=""input"" value=""ETH"" style=""text-align:left; width:70px;border:none"" />

                </div><br />


            </div>
            <p style=""text-align: left; color: darkgray"">Balance:0.00</p>

        </div>
        <div>
            <button style=""border: none; border-radius: 30px/80px; position:absolute; top:calc(29% - 40px/2) ; height:40px;width:56px""> <i class=""bi bi-arrow-down-up"" style=""font-size:20px;color:black; ""></i></button>
        </div>
        <div class=""container"" style=""border: none; background-color: #FFFFFF"">
            <div class=""d-flex"">
                <span>To</span>
                <div style=""flex-grow:1""></div>
                <span></span>
            </div>
            <div class=""d-flex"">
                <span>
                    0
                </span>

                <div style=""flex-grow:1""></div>
                <div class=""bn-input-md");
            WriteLiteral(" \">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc41d7a20bdba0a29eca68eeab94d64e546a7e009082", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <input data-bn-type=""input"" value=""BNB"" style=""text-align:left; width:70px ; border:none"" />
                </div><br />
            </div>
            <p style=""text-align: left; color: darkgray"">Balance:0.00</p>

        </div>
        <div class=""d-flex"">
            <span>slippage Tolerance</span>
            <div style=""flex-grow:1""></div>
            <span>1%</span>

        </div>
        <div>
            <button onclick=""alert('Hello ')"" style=""color:darkgray; width: 650px; height: 70px; border: none"">Enter A Mount</button>
        </div><br />

    </div>
    <br /><br />


 <!--Modal Setting-->
    <div class=""modal"" id=""mySetting"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-body"">
                    <!--Transaction Setting-->
                    <p style=""font-size:20px; text-align:left"">Transaction Setting</p>
                    <div class=""container d-flex "">
                   ");
            WriteLiteral(@"     <div>
                            <p style="" margin-right: 200px"">Slippage tolerance</p>
                        </div>
                        <div>
                            <a data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Your transaction will revert if the price changes
                               unfavorably"">
                                <i class='far fa-question-circle' style='font-size:24px'></i>
                            </a>
                        </div>
                    </div>

                    <div class=""container d-flex"" style=""width:100%"">
                        <button style=""margin-right: 10px; border-radius: 10px; position: static; border: none;"">0.1%</button>
                        <button style=""margin-right: 10px; border-radius: 10px; position: static; border: none;"">0.5%</button>
                        <button style=""margin-right: 10px; border-radius: 10px; position: static; border: none;""> 1%</button>
                        <input ty");
            WriteLiteral(@"pe=""text"" placeholder=""1.00%"" style=""width: 70px; margin-right: 10px; border-radius: 10px; position: static; border: none;"">
                    </div>
                    <br />
                    <!--Transaction dealine-->
                    <div class=""container d-flex"">
                        <div>
                            <p style="" margin-right: 200px"">Transaction dealine</p>
                        </div>
                        <div>
                            <a data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Your transaction will revert if it is pending
                               for more than this long"">
                                <i class='far fa-question-circle' style='font-size:24px'></i>
                            </a>
                        </div>

                    </div>
                    <div class=""container d-flex"" style=""width:100%"">
                        <input class=""btn-st"" type=""text"" placeholder=""20"" style=""width:100px; height:30px");
            WriteLiteral(@"""> &nbsp;
                        <p>minutes</p>
                    </div>

                    <!--Interface Setting-->
                    <p style=""font-size:20px; text-align:left""> Interface Setting</p>
                    <!--Transaction dealine-->
                    <div class=""container d-flex"">
                        <div>
                            <p style="" margin-right: 200px"">Transaction dealine</p>
                        </div>
                        <div>
                            <a data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Bypasses confirmation modals and allows
                               high slippage trades. Use at your own risk"">
                                <i class='far fa-question-circle' style='font-size:24px'></i>
                            </a>
                        </div>
                        &nbsp;
                        <label class=""switch"">
                            <input type=""checkbox"">
                            <");
            WriteLiteral(@"span class=""slider round""></span>
                        </label>
                    </div>

                    <!--Disable multihops-->
                    <div class=""container d-flex"">
                        <div>
                            <p style="" margin-right: 200px"">Disable multihops</p>
                        </div>
                        <div>
                            <a data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Restricts swaps to direct pairt only"">
                                <i class='far fa-question-circle' style='font-size:24px;'></i>
                            </a>
                        </div>
                        &nbsp;
                        <label class=""switch"">
                            <input type=""checkbox"">
                            <span class=""slider round""></span>
                        </label>
                    </div>
                </div>
                <!--Tooltip-->
                <script>
                 ");
            WriteLiteral(@"   // Initialize tooltips
                    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle=""tooltip""]'))
                    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
                        return new bootstrap.Tooltip(tooltipTriggerEl)
                    })
                </script>
                <!--0000000000-->
            </div>
        </div>
    </div>
</div>

<!--Select a Token -->
<div class=""modal"" id=""myToken"">
    <div class=""modal-dialog"">
        <div class=""modal-content"" style=""background-color: #e6e6e6"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Select a Token</h4>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal""></button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body"">
                <!--Search-->
                <div class=""mt-3 inputs"">
               ");
            WriteLiteral(@"     <input type=""text"" class=""form-control "" placeholder=""Search "">
                </div>
                <!--List Token-->
                <!--ETH-->
                <div class=""mt-3"" style=""background-color: #FFFFFF; border-radius: 8px; align-items: center; position: static; height: auto"">
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""d-flex flex-row align-items-center"">
                            <span class=""star"">  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc41d7a20bdba0a29eca68eeab94d64e546a7e0017189", async() => {
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
            WriteLiteral(@" </span>
                            <div class=""d-flex flex-column"">
                                <span>ETH</span>
                            </div>
                        </div>
                        <div class=""d-flex flex-column"">
                            <span>4.8729</span>
                            <div class=""d-flex flex-row align-items-center time-text"">
                                <small>ETH</small>
                            </div>
                        </div>

                    </div>
                </div>
                <!--AC3-->
                <div class=""mt-3"" style=""background-color: #FFFFFF; border-radius: 8px; align-items: center; position: static; height: auto"">
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""d-flex flex-row align-items-center"">
                            <span class=""star"">  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc41d7a20bdba0a29eca68eeab94d64e546a7e0019255", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </span>
                            <div class=""d-flex flex-column"">
                                <span>AC3</span>
                            </div>
                        </div>
                        <div class=""d-flex flex-column"">
                            <span>0</span>
                            <div class=""d-flex flex-row align-items-center time-text"">
                                <small>AC3</small>
                            </div>
                        </div>
                    </div>
                </div>
                <!--ALQO-->
                <div class=""mt-3"" style=""background-color: #FFFFFF; border-radius: 8px; align-items: center; position: static; height: auto"">
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""d-flex flex-row align-items-center"">
                            <span class=""star"">  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc41d7a20bdba0a29eca68eeab94d64e546a7e0021315", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </span>
                            <div class=""d-flex flex-column"">
                                <span>ALQO</span>
                            </div>
                        </div>
                        <div class=""d-flex flex-column"">
                            <span>0</span>
                            <div class=""d-flex flex-row align-items-center time-text"">
                                <small>XLQ</small>
                            </div>
                        </div>
                    </div>
                </div>
                <!--Aion-->
                <div class=""mt-3"" style=""background-color: #FFFFFF; border-radius: 8px; align-items: center; position: static; height: auto"">
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""d-flex flex-row align-items-center"">
                            <span class=""star"">  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc41d7a20bdba0a29eca68eeab94d64e546a7e0023376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </span>
                            <div class=""d-flex flex-column"">
                                <span>Aion</span>
                            </div>
                        </div>
                        <div class=""d-flex flex-column"">
                            <button style=""border-radius: 8px; position: static; margin: 0px 23px; color: #F5FA80; border: none; width: 70%; background-color: #000000; height: 29px "">Import</button>
                        </div>
                    </div>
                </div>
                <!--Ampl-->
                <div class=""mt-3"" style=""background-color: #FFFFFF; border-radius: 8px; align-items: center; position: static; height: auto"">
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""d-flex flex-row align-items-center"">
                            <span class=""star"">  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc41d7a20bdba0a29eca68eeab94d64e546a7e0025417", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </span>
                            <div class=""d-flex flex-column"">
                                <span>AMPL (Ampleoforth) </span>
                                <div class=""d-flex flex-row align-items-center time-text"">
                                    <small>via Coid Geko</small>
                                </div>
                            </div>
                            
                        </div>
                        <div class=""d-flex flex-column"">
                            <button style=""border-radius: 8px; position: static; margin: 0px 23px; color: #F5FA80; border: none; width: 70%; background-color: #000000; height: 29px "">Import</button>
                        </div>
                    </div>
                </div>
                <!-- Modal footer -->
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn"" data-bs-dismiss=""modal""><i class='fas fa-pen'>&nbsp;Manage</i></button>
                </div>

            ");
            WriteLiteral("</div>\r\n    </div>\r\n</div>");
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
