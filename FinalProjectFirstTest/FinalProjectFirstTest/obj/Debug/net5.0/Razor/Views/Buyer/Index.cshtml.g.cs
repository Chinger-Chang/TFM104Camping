#pragma checksum "C:\Users\user\Desktop\TFM104Camping\FinalProjectFirstTest\FinalProjectFirstTest\Views\Buyer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "098c3a91f2cbf12ebd2ffa798201564193f1aa23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buyer_Index), @"mvc.1.0.view", @"/Views/Buyer/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\TFM104Camping\FinalProjectFirstTest\FinalProjectFirstTest\Views\_ViewImports.cshtml"
using FinalProjectFirstTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\TFM104Camping\FinalProjectFirstTest\FinalProjectFirstTest\Views\_ViewImports.cshtml"
using FinalProjectFirstTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"098c3a91f2cbf12ebd2ffa798201564193f1aa23", @"/Views/Buyer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ff9cc218848b295820657762e15fb616568996", @"/Views/_ViewImports.cshtml")]
    public class Views_Buyer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProjectFirstTest.Models.Camping_Area>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-model", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-select w-25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098c3a91f2cbf12ebd2ffa798201564193f1aa234349", async() => {
                WriteLiteral(@"
	<style>
		.a {
			background-color: #212121;
		}

		body {
			background-color: #212121;
		}

		.myBtn {
			display: flex !important;
			justify-content: flex-end !important;
		}

		/*卡片高
		.v-card {
			height: 566px;
		}*/
		.custom-select {
			background-color: #BDBDBD;
			color: #424242;
			border: none;
		}

		/*字間行高
		.text-black {
			line-height:1.7rem;
		}*/
	</style>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098c3a91f2cbf12ebd2ffa798201564193f1aa235722", async() => {
                WriteLiteral(@"
	<div id=""mika"">
		<v-app>
			<template>
				<v-carousel class=""a""
							cycle
							height=""400""
							hide-delimiter-background
							show-arrows-on-hover>
					<v-carousel-item v-for=""(item,i) in aaa""
									 :key=""i""
									 :src=""item.src"">
						<v-sheet :color=""aaa[i]""
								 height=""100%"">
							<v-row class=""fill-height""
								   align=""center""
								   justify=""center"">

							</v-row>
						</v-sheet>
					</v-carousel-item>
				</v-carousel>
				<v-container fluid class=""a"">
");
                WriteLiteral("\t\t\t\t</v-container>\r\n\t\t\t\t<div class=\"a\" style=\"padding-bottom:30px\">\r\n\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098c3a91f2cbf12ebd2ffa798201564193f1aa236663", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098c3a91f2cbf12ebd2ffa798201564193f1aa236943", async() => {
                        WriteLiteral("選擇地區");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 73 "C:\Users\user\Desktop\TFM104Camping\FinalProjectFirstTest\FinalProjectFirstTest\Views\Buyer\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<Region>();

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("\t\t\t\t</div>\r\n\t\t\t\t<div class=\"row a\">\r\n");
                WriteLiteral("\t\t\t\t</div>\r\n\t\t\t\t<div class=\"row a\">\r\n");
                WriteLiteral(@"
				</div>
				<div class=""row a"">

					<div v-for=""x in IndexInfo"" v-if=""selected == '選擇地區' || selected == x.region"" class=""col-lg-3 col-md-4 col-sm-12"">
						<v-hover v-slot=""{ hover }"" close-delay=""200"">

							<v-card color=""#757575"" :elevation=""hover ? 16 : 2"" :class=""{ 'on-hover': hover }"" class=""mx-auto"" max-width=""344"">

								<v-img :src=""'/Camping_Area_Picture/' + x.picPath"" height=""200px""></v-img>

								<v-card-title class=""text-black text-h6 font-weight-black"">【{{RR[x.region]}}】{{x.campingAreaName}}</v-card-title>
								<v-card-subtitle class=""text-black font-weight-bold""><v-icon>mdi-star-face</v-icon> {{x.campingDes}}</v-card-subtitle>
								<v-card-text class=""text-danger text-h6 text-right font-weight-bold"">最低價格 : TWD {{x.lowerPrice}}</v-card-text>

								<div class=""myBtn"">
									<v-card-actions>
");
                WriteLiteral(@"										<v-btn v-on:click=""sendCAid(x.campingAreaId)"" color=""#212121""
											   dark>
											查看露營區<v-icon>mdi-cursor-pointer</v-icon>
										</v-btn>

										<v-spacer></v-spacer>
									</v-card-actions>
								</div>
							</v-card>
						</v-hover>
					</div>
				</div>
			</template>
		</v-app>
");
                WriteLiteral(@"	</div>


	<script>
        var v = new Vue({
            el: '#mika',
            vuetify: new Vuetify(),
            data: {
                aaa: [
                    {
                        src: 'https://lh3.googleusercontent.com/lJ_5-YTT9eoPpG5vBcr9IbfcOvWCbkPaTjxwn48PpL3ZZnEDO-UMHNRwM2xb_pI94Y7WnFFesk2Sj1xA5FkALAMafUY8Ktd9MZAqdPhiYr0QfztjGvNUYG98ZNAX1hlzgdc2A13azgUz1P_19vK7w7fPew3OmcmbE_eqxdLHxsfNumeKGdMpNTyCGCfCM08jYXLPMlqTbOZg9NgW8X3QAyV2SzWREhMZGqO7_ZTBbsKSk8yZpAzPYB_c4MH0YIqp_yrfLWw_ibstMFvsil94jlmWMYQ4jeBgha2zFACTs1YER-sXjtkSIEip6HwdTr3fcg-Jt_DEZP8FcDcxYyzAkP84-MgSmpY-kTWUQbwP-Ud1VBKn7kcUQrdtem1CO7xmyqyATKtlL0XXd-m-iaa6vPWkvneFrBCvWnQ7b_iQJRrbiEbOmxjX3zEd4qZdHDqvosCpLnIek9fzKao2fV6MHg6hj5uNDiRRtAq4COthRXsp_gMGbg3sslYY0JpCwc_OFcejMZT9jn7KtTVQkv01qwySpa3pLMaO0ErQJH5iYIrVFrKxq5oqAZ48v3XGMVoAmmxv-PzH1DAUInqafh3TW_S_uAQiBX1fgMMsLLoeRov22EReJxtHF7oIVIxa2jCC8Xol9C2Km2lQQEEf4NSqdBK1BS-H6Ua-HObXFKv5Pn3WSbM0KXgssl6uhtc36nvm8mkFm_NEiQZjfjymS12g1SlbI8cZLP0sJ0rRAeNDzWiUXw0DRqGdM9-oB_jYEnecwf79fOkDmc");
                WriteLiteral(@"i5KnAVXFo-Rj0bEQC_grZxCQA=w1023-h576-no?authuser=0',
                    },
                    {
                        src: 'https://lh3.googleusercontent.com/lJ_5-YTT9eoPpG5vBcr9IbfcOvWCbkPaTjxwn48PpL3ZZnEDO-UMHNRwM2xb_pI94Y7WnFFesk2Sj1xA5FkALAMafUY8Ktd9MZAqdPhiYr0QfztjGvNUYG98ZNAX1hlzgdc2A13azgUz1P_19vK7w7fPew3OmcmbE_eqxdLHxsfNumeKGdMpNTyCGCfCM08jYXLPMlqTbOZg9NgW8X3QAyV2SzWREhMZGqO7_ZTBbsKSk8yZpAzPYB_c4MH0YIqp_yrfLWw_ibstMFvsil94jlmWMYQ4jeBgha2zFACTs1YER-sXjtkSIEip6HwdTr3fcg-Jt_DEZP8FcDcxYyzAkP84-MgSmpY-kTWUQbwP-Ud1VBKn7kcUQrdtem1CO7xmyqyATKtlL0XXd-m-iaa6vPWkvneFrBCvWnQ7b_iQJRrbiEbOmxjX3zEd4qZdHDqvosCpLnIek9fzKao2fV6MHg6hj5uNDiRRtAq4COthRXsp_gMGbg3sslYY0JpCwc_OFcejMZT9jn7KtTVQkv01qwySpa3pLMaO0ErQJH5iYIrVFrKxq5oqAZ48v3XGMVoAmmxv-PzH1DAUInqafh3TW_S_uAQiBX1fgMMsLLoeRov22EReJxtHF7oIVIxa2jCC8Xol9C2Km2lQQEEf4NSqdBK1BS-H6Ua-HObXFKv5Pn3WSbM0KXgssl6uhtc36nvm8mkFm_NEiQZjfjymS12g1SlbI8cZLP0sJ0rRAeNDzWiUXw0DRqGdM9-oB_jYEnecwf79fOkDmci5KnAVXFo-Rj0bEQC_grZxCQA=w1023-h576-no?authuser=0',
                    },
   ");
                WriteLiteral(@"                 {
                        src: 'https://lh3.googleusercontent.com/lJ_5-YTT9eoPpG5vBcr9IbfcOvWCbkPaTjxwn48PpL3ZZnEDO-UMHNRwM2xb_pI94Y7WnFFesk2Sj1xA5FkALAMafUY8Ktd9MZAqdPhiYr0QfztjGvNUYG98ZNAX1hlzgdc2A13azgUz1P_19vK7w7fPew3OmcmbE_eqxdLHxsfNumeKGdMpNTyCGCfCM08jYXLPMlqTbOZg9NgW8X3QAyV2SzWREhMZGqO7_ZTBbsKSk8yZpAzPYB_c4MH0YIqp_yrfLWw_ibstMFvsil94jlmWMYQ4jeBgha2zFACTs1YER-sXjtkSIEip6HwdTr3fcg-Jt_DEZP8FcDcxYyzAkP84-MgSmpY-kTWUQbwP-Ud1VBKn7kcUQrdtem1CO7xmyqyATKtlL0XXd-m-iaa6vPWkvneFrBCvWnQ7b_iQJRrbiEbOmxjX3zEd4qZdHDqvosCpLnIek9fzKao2fV6MHg6hj5uNDiRRtAq4COthRXsp_gMGbg3sslYY0JpCwc_OFcejMZT9jn7KtTVQkv01qwySpa3pLMaO0ErQJH5iYIrVFrKxq5oqAZ48v3XGMVoAmmxv-PzH1DAUInqafh3TW_S_uAQiBX1fgMMsLLoeRov22EReJxtHF7oIVIxa2jCC8Xol9C2Km2lQQEEf4NSqdBK1BS-H6Ua-HObXFKv5Pn3WSbM0KXgssl6uhtc36nvm8mkFm_NEiQZjfjymS12g1SlbI8cZLP0sJ0rRAeNDzWiUXw0DRqGdM9-oB_jYEnecwf79fOkDmci5KnAVXFo-Rj0bEQC_grZxCQA=w1023-h576-no?authuser=0',
                    }
                ],
                //location: ['台北', '新竹', '台南', '高雄'],
          ");
                WriteLiteral(@"      IndexInfo: [],
                selected: '選擇地區',
                a: {
                    caId: ''
                },
                Region: [],
                R:'',
                RR: [""基隆"", ""新北市"", ""台北市"", ""桃園"", ""新竹"", ""苗栗"", ""台中"", ""彰化"",
                    ""南投"", ""雲林"", ""嘉義"", ""台南"", ""高雄"", ""屏東"", ""宜蘭"", ""花蓮"", ""台東""]
            },
            methods: {
                sendCAid: function (id) {
                    let self = this;
                    self.a.caId = id
                    //alert(self.a.caId);

                    window.location.href = ""/Buyer/RoomInfo/"" + self.a.caId;
                }
            },
            mounted: function () {
                var self = this;
                axios.get(""/Buyer/getIndexInfo"").then(function (res) {
                    self.IndexInfo = res.data;
                    console.log(res.data);
                }),
                    axios.get(""/Buyer/GetDisplayName"").then(function (res) {
                        self.Region = res.data");
                WriteLiteral(";\r\n                        console.log(res.data);\r\n                    })\r\n            }\r\n        })\r\n\t</script>\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectFirstTest.Models.Camping_Area> Html { get; private set; }
    }
}
#pragma warning restore 1591
