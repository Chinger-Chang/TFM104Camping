#pragma checksum "C:\Users\user\Desktop\TFM104Camping\FinalProjectFirstTest\FinalProjectFirstTest\Views\Buyer\register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a535b8b96312b3b9fb90795f5d165fef1fa8b816"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buyer_register), @"mvc.1.0.view", @"/Views/Buyer/register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a535b8b96312b3b9fb90795f5d165fef1fa8b816", @"/Views/Buyer/register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ff9cc218848b295820657762e15fb616568996", @"/Views/_ViewImports.cshtml")]
    public class Views_Buyer_register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-on:submit.prevent", new global::Microsoft.AspNetCore.Html.HtmlString("register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-on:submit.prevent", new global::Microsoft.AspNetCore.Html.HtmlString("login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div id=""mika"">
    <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
        <li class=""nav-item"" role=""presentation"">
            <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">註冊</a>
        </li>
        <li class=""nav-item"" role=""presentation"">
            <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">登入</a>
        </li>
    </ul>

    <div class=""tab-content"" id=""myTabContent"">
        <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a535b8b96312b3b9fb90795f5d165fef1fa8b8164780", async() => {
                WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""emailID"">帳號(email)</label>
                    <input required type=""email"" class=""form-control"" id=""emailID"" v-model.trim=""email"" v-on:blur=""emailCheck"">
                </div>
                <div class=""form-group"">
                    <label for=""passwordID"">密碼</label>
                    <input required type=""password"" class=""form-control"" id=""passwordID"" v-model.trim=""password"" v-on:blur=""pwCheck"">
                </div>
                <div class=""form-group"">
                    <label for=""nameID"">姓名</label>
                    <input required type=""text"" class=""form-control"" id=""nameID"" v-model.trim=""name"" v-on:blur=""nameCheck"">
                </div>
                <div class=""form-group"">
                    <label for=""telID"">手機</label>
                    <input required type=""tel"" class=""form-control"" id=""telID"" v-model.trim=""phone"" v-on:blur=""phoneCheck"">
                </div>

                <button");
                WriteLiteral(@" type=""submit"" class=""btn btn-primary"">註冊</button>

                <div v-show=""isEmail"" class=""alert alert-danger"" role=""alert"">
                    Email格式錯誤
                </div>
                <div v-show=""isUse"" class=""alert alert-danger"" role=""alert"">
                    帳號已被使用
                </div>
                <div v-show=""isSuccess"" class=""alert alert-primary"" role=""alert"">
                    註冊成功
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"tab-pane fade\" id=\"profile\" role=\"tabpanel\" aria-labelledby=\"profile-tab\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a535b8b96312b3b9fb90795f5d165fef1fa8b8167829", async() => {
                WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""LoginEmailID"">帳號(email)</label>
                    <input required type=""email"" class=""form-control"" id=""LoginEmailID"" v-model.trim=""LoginEmail"" v-on:blur=""LoginEmailCheck"">
                </div>
                <div class=""form-group"">
                    <label for=""LoginPasswordID"">密碼</label>
                    <input required type=""password"" class=""form-control"" id=""LoginPasswordID"" v-model.trim=""LoginPassword"" v-on:blur=""LoginPasswordCheck"">
                </div>

");
                WriteLiteral(@"
                <!-- Button trigger modal -->
                <button type=""button"" class=""btn btn-link"" data-toggle=""modal"" data-target=""#exampleModal"">
                    忘記密碼
                </button>

                <!-- Modal -->
                <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog modal-dialog-centered"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title"" id=""exampleModalLabel"">忘記密碼</h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            <div class=""modal-body"">
                                ...
                        ");
                WriteLiteral(@"    </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">關閉</button>
                                <button type=""button"" class=""btn btn-primary"">確定</button>
                            </div>
                        </div>
                    </div>
                </div>

                <button type=""submit"" class=""btn btn-primary"">登入</button>

                <div v-show=""isFalse"" class=""alert alert-danger"" role=""alert"">
                    帳號或密碼錯誤
                </div>
                <div v-show=""isLogin"" class=""alert alert-primary"" role=""alert"">
                    登入成功
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<script>
    var v = new Vue({
        el: '#mika',
        data: {
            email: '',
            password: '',
            name: '',
            phone: '',
            isUse: false,
            isSuccess: false,
            LoginEmail: '',
            LoginPassword: '',
            isFalse: false,
            isLogin: false,
            isEmail: false

        },
        methods: {
            emailCheck: function () {
                let self = this;
                var emailRule = /^\w+((-\w+)|(\.\w+))*\");
            WriteLiteral(@"@[A-Za-z0-9]+((\\.|-)[A-Za-z0-9]+)*\.[A-Za-z]+$/;
                if (self.email == '') {
                    self.email = '';
                    self.isEmail = false; //格式錯誤 直接清空欄位
                } else if (self.email.search(emailRule) != -1)
                {
                    self.isEmail = false; //格式正確
                } else
                {
                    self.isEmail = true;//格式錯誤
                }
            },
            pwCheck: function () {
                let self = this;
                if (self.password == '') {
                    self.password = '';
                }
            },
            nameCheck: function () {
                let self = this;
                if (self.name == '') {
                    self.name = '';
                }
            },
            phoneCheck: function () {
                let self = this;
                if (self.phone == '') {
                    self.phone = '';
                }
            },
            Login");
            WriteLiteral(@"EmailCheck: function () {
                let self = this;
                if (self.LoginEmail == '') {
                    self.LoginEmail = '';
                }
            },
            LoginPasswordCheck: function () {
                let self = this;
                if (self.LoginPassword == '') {
                    self.LoginPassword = '';
                }
            },
            register: function () {

                let self = this;

                let data = new FormData();
                data.append('Email', this.email);
                data.append('Password', this.password);
                data.append('Name', this.name);
                data.append('Phone', this.phone);


                //POST請求
                axios({
                    method: 'post',
                    url: '/Buyer/registerCheck',
                    //API要求的資料
                    data: data,
                    headers: { ""Content-Type"": 'multipart/form-data' }
                })
  ");
            WriteLiteral(@"                  .then(function (response) {
                        if (response.data == true) {
                            self.isSuccess = true;
                            self.isUse = false;
                            //alert(""註冊成功"");
                        } else {
                            self.isUse = true;
                            self.isSuccess = false;
                            self.email = '';
                            //alert(""註冊失敗"");
                        }

                    })
                    .catch(function (response) {
                        //handle error
                        console.log(response);
                    });

            },
            login: function () {
                let self = this;

                let data = new FormData();
                data.append('Email', self.LoginEmail);
                data.append('Password', self.LoginPassword);


                //POST請求
                axios({
                    method: ");
            WriteLiteral(@"'post',
                    url: '/Buyer/LoginCheck',
                    //API要求的資料
                    data: data,
                    headers: { ""Content-Type"": 'multipart/form-data' }
                })
                    .then(function (response) {
                        //if (response.data == true) {
                        //    self.isLogin = true;
                        //    self.isFalse = false;
                        //    //alert(""登入成功"");
                        //} else {
                        //    self.isFalse = true;
                        //    self.isLogin = false;
                        //    self.LoginEmail = '';
                        //    self.LoginPassword = '';
                        //    //alert(""登入失敗"");
                        //}
                        //console.log(response);
                        //console.log(response.data);
                        window.location.href = response.data
                    })
                    .catch(function");
            WriteLiteral(@" (response) {
                        //handle error
                        //console.log(response.data);
                        alert(""失敗"")
                        window.location.href = response.data
                    });
            }
        },
        computed: {

        }
    })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
