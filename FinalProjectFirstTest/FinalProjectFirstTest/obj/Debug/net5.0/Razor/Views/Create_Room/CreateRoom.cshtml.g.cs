#pragma checksum "C:\Project TFM104\TFM104Camping\FinalProjectFirstTest\FinalProjectFirstTest\Views\Create_Room\CreateRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3903d350d5985cb24d6792d485efd49272a64199"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Create_Room_CreateRoom), @"mvc.1.0.view", @"/Views/Create_Room/CreateRoom.cshtml")]
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
#line 1 "C:\Project TFM104\TFM104Camping\FinalProjectFirstTest\FinalProjectFirstTest\Views\_ViewImports.cshtml"
using FinalProjectFirstTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project TFM104\TFM104Camping\FinalProjectFirstTest\FinalProjectFirstTest\Views\_ViewImports.cshtml"
using FinalProjectFirstTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3903d350d5985cb24d6792d485efd49272a64199", @"/Views/Create_Room/CreateRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ff9cc218848b295820657762e15fb616568996", @"/Views/_ViewImports.cshtml")]
    public class Views_Create_Room_CreateRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/test/tent2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dot"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:125px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/test/tent.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("roomtype in roomtypes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-bind:value", new global::Microsoft.AspNetCore.Html.HtmlString("roomtype.value"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("n in 30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-bind:value", new global::Microsoft.AspNetCore.Html.HtmlString("n"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-on:submit.prevent", new global::Microsoft.AspNetCore.Html.HtmlString("send"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n\t.border-right {\r\n\t\tborder-style: solid;\r\n\t\tcolor: rgb(56 191 245 / 0.80);\r\n\t\theight: 300px;\r\n\t\tposition: fixed;\r\n\t\tborder-width: 3px;\r\n\t}\r\n\r\n\t.dot {\r\n\t\twidth: 45px;\r\n\t\theight: 45px;\r\n\t\tposition: fixed;\r\n\t\ttext-align: center;\r\n\t}\r\n\r\n\t");
            WriteLiteral("@media (max-width:770px) and (min-width:481px) {\r\n\t\t.myimg {\r\n\t\t\twidth: 200px !important;\r\n\t\t\theight: 120px !important;\r\n\t\t}\r\n\t}\r\n\r\n\t");
            WriteLiteral("@media (max-width:480px) {\r\n\t\t.myimg {\r\n\t\t\twidth: 100px !important;\r\n\t\t\theight: 60px !important;\r\n\t\t}\r\n\t}\r\n</style>\r\n\r\n<div class=\"float-right\" style=\"display:flex;justify-content:center;\">\r\n\r\n\t<div class=\"border-right \"></div>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3903d350d5985cb24d6792d485efd49272a641998315", async() => {
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
            WriteLiteral("\r\n\t<p style=\"margin-top: 50px; position: fixed;\">建露營區</p>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3903d350d5985cb24d6792d485efd49272a641999493", async() => {
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
            WriteLiteral("\r\n\t<p style=\"margin-top: 175px; position: fixed;\">建房型</p>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3903d350d5985cb24d6792d485efd49272a6419910754", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t<p style=\"margin-top: 300px; position: fixed;\">完成</p>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3903d350d5985cb24d6792d485efd49272a6419912027", async() => {
                WriteLiteral(@"
	<div class=""container"">
		<div class=""row"">
			<h3 class=""col-8 mt-5 ml-5 mb-3"">房型資訊</h3>

			<div class=""col-8 mx-auto my-2"">
				<div class=""border p-5 shadow "" style=""background-color:#e6e4e4"">
					<div class="" form-group row mb-4"">
						<label for=""name"" class=""form-label"">房間名稱</label>
						<input type=""text"" class=""form-control"" id=""name"" v-model=""hello.name"" required>
					</div>
					<div class=""form-group row mb-4"">
						<label for=""selected"" class=""form-label"">房型類別</label>
						<select v-model=""selected"">
							");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3903d350d5985cb24d6792d485efd49272a6419912865", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t{{ roomtype.text }}\r\n\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t</select>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"form-group row mb-4\">\r\n\t\t\t\t\t\t<label for=\"count\" class=\"form-label\">房型數量</label>\r\n\t\t\t\t\t\t<select v-model=\"count\">\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3903d350d5985cb24d6792d485efd49272a6419914325", async() => {
                    WriteLiteral("{{ n }}");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
						</select>
					</div>
					<div class=""form-group row mb-4"">
						<label for=""description"" class=""form-label"">敘述</label>
						<textarea class=""form-control"" id=""description"" v-model=""hello.description""></textarea>
					</div>
				</div>
			</div>
			<h3 class=""col-8 ml-5 my-4"">房型價錢</h3>
			<div class=""col-8 mx-auto mt-2 mb-4"">
				<div class=""border p-5 shadow "" style=""background-color:#e6e4e4"">
					<div class=""form-group row mb-4"">
						<label for=""priceofweekdays"" class=""form-label"">平日價錢</label>
						<input type=""number"" class=""form-control"" id=""priceofweekdays"" v-model=""hello.priceofweekdays"" required>
					</div>
					<div class=""form-group row mb-4"">
						<label for=""priceofweekends"" class=""form-label"">假日價錢</label>
						<input type=""number"" class=""form-control"" id=""priceofweekends"" v-model=""hello.priceofweekends"" required>
					</div>
				</div>
			</div>
			<h3 class=""col-8 ml-5 mb-4"">房型照片</h3>
			<div class=""col-8 mx-auto my-2"">
				<div class=""border p-5 shadow "" ");
                WriteLiteral(@"style=""background-color:#e6e4e4"">
					<div class=""form-group row"">
						<label for=""pic"" class=""form-label"">房型照片</label>
						<input type=""file"" class=""form-control"" id=""pic"" v-on:change=""up"">
						<p class=""text-center"">(最少三張，最多六張)</p>
					</div>
					<div class=""form-group row"">
						<p>preview here:</p>
						<template v-if=""picture.preview_list.length"">
							<div class=""container"">
								<div class="" mt-2 px-2 mx-auto"" style=""display:inline-block"" v-for=""item, index in picture.preview_list"" :key=""index"">
									<button type=""button"" class=""btn btn-danger rounded"" v-on:click=""deletepreviewpic(index)"" style=""position: absolute;"">x</button>
									<img :src=""item"" style=""width:290px; height: 180px; object-fit: cover;"" class=""myimg"" />
								</div>
							</div>
						</template>
					</div>
				</div>
			</div>


		</div>
	</div>
	<div class=""d-flex justify-content-end"">
		<button type=""submit"" class=""btn btn-dark text-white btn-lg mt-5 mb-5"">新增</button>
	</div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div id=""myModal"" class=""modal"" tabindex=""-1"">
	<div class=""modal-dialog"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<h5 class=""modal-title"">Modal title</h5>
				<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
					<span aria-hidden=""true"">&times;</span>
				</button>
			</div>
			<div class=""modal-body"">
				<p>Modal body text goes here.</p>
			</div>
			<div class=""modal-footer"">
				<button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
				<button type=""button"" class=""btn btn-primary"">Save changes</button>
			</div>
		</div>
	</div>
</div>



<script>
	var app = new Vue(
		{
			el: ""#form1"",
			data: {
				hello: {
					name: """",
					priceofweekdays: """",
					priceofweekends: """",
					description: """"
				},
				picture: {
					preview: null,
					preview_list: [],
					image_list: []
				},
				count: '1',
				selected: 'Single_Room',
				roomtypes: [
					{ text: '單人房', value: 'Si");
            WriteLiteral(@"ngle_Room' },
					{ text: '雙人房', value: 'Double_Room' },
					{ text: '四人房', value: 'Quad_Room' },
					{ text: '六人房', value: 'Six_Person_Room' },
					{ text: '八人房', value: 'Eight_Person_Room' },
					{ text: '十人房', value: 'Ten_Person_Room' },
					{ text: '露營車(二人)', value: 'Campervan_2' },
					{ text: '露營車(四人)', value: 'Campervan_4' },
					{ text: '露營車(六人)', value: 'Campervan_6' },
					{ text: '露營區(二人)', value: 'Campsite_2' },
					{ text: '露營區(四人)', value: 'Campsite_4' },
					{ text: '露營區(六人)', value: 'Campsite_6' },
					{ text: '豪華露營(二人)', value: 'Glamping_2' },
					{ text: '豪華露營(四人)', value: 'Glamping_4' },
					{ text: '豪華露營(六人)', value: 'Glamping_6' }
				]
			},
			methods: {
				up: function (a) {
					//console.log(a);
					//console.log(a.target.files[0]);
					var input = a.target;
					var count = input.files.length;
					var index = 0;
					if (input.files) {
						while (count--) {
							if (this.picture.preview_list.length < 6) {
								var reader = new File");
            WriteLiteral(@"Reader();
								reader.onload = (e) => {
									this.picture.preview_list.push(e.target.result);
								}
								this.picture.image_list.push(input.files[index]);
								reader.readAsDataURL(input.files[index]);
								index++;
								alert(""上傳了!!!"");
								console.log(this.selected);
							}
							else {
								alert(""!!!"");
							}
						}

					}

				},
				deletepreviewpic: function (a) {

					this.picture.preview_list.splice(a, 1);
					this.picture.image_list.splice(a, 1);
					//window.location.reload();


				},
				send: function () {
					if (this.picture.preview_list.length < 3) {
						$('#myModal').modal('show');
					}
					else {
						var bodyFormData = new FormData();

						bodyFormData.append(""Name"", this.hello.name);
						bodyFormData.append(""Price_Of_Weekdays"", this.hello.priceofweekdays);
						bodyFormData.append(""Price_Of_Weekends"", this.hello.priceofweekends);
						bodyFormData.append(""Description"", this.hello.description);
					");
            WriteLiteral(@"	bodyFormData.append(""RoomType"", this.selected);
						bodyFormData.append(""Count"", this.count);


						for (let index = 0; index < this.picture.image_list.length; index++) {
							bodyFormData.append(""Path"", this.picture.image_list[index]);
						}

						//let urlParams = new URLSearchParams(window.location.search);
						//console.log(urlParams.get('id')); // ""abc""
						//let id = urlParams.get('id');
						axios({
							method: ""post"",
							url: ""/Create_Room/Room_IntoDB"",
							data: bodyFormData,
							headers: { ""Content-Type"": ""multipart/form-data"" },
						})
							.then(function (response) {
								if (response.data == true) {
									alert(""success"");
									window.location.href = ""/Camping_Information/CampingInformation""
								}
								else {
									alert(""失敗"");
								}
								//	//handle success
								//alert(response.data);
								//window.location.href=""https://localhost:5001/Create_Room/CreateRoom?id="" + response.data;
							})
							.catc");
            WriteLiteral("h(function (response) {\r\n\t\t\t\t\t\t\t\t//handle error\r\n\t\t\t\t\t\t\t\tconsole.log(response);\r\n\t\t\t\t\t\t\t});\r\n\t\t\t\t\t}\r\n\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t}\r\n\t);\r\n</script>\r\n\r\n\r\n\r\n");
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
