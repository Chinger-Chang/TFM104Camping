#pragma checksum "C:\Users\user\Downloads\FinalProjectFirstTest\FinalProjectFirstTest\Views\Buyer\reservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4e6b12f0226c76c7bced91ed4f1604a88189431"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buyer_reservation), @"mvc.1.0.view", @"/Views/Buyer/reservation.cshtml")]
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
#line 1 "C:\Users\user\Downloads\FinalProjectFirstTest\FinalProjectFirstTest\Views\_ViewImports.cshtml"
using FinalProjectFirstTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Downloads\FinalProjectFirstTest\FinalProjectFirstTest\Views\_ViewImports.cshtml"
using FinalProjectFirstTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e6b12f0226c76c7bced91ed4f1604a88189431", @"/Views/Buyer/reservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ff9cc218848b295820657762e15fb616568996", @"/Views/_ViewImports.cshtml")]
    public class Views_Buyer_reservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mika"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-on:submit.prevent", new global::Microsoft.AspNetCore.Html.HtmlString("send"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4e6b12f0226c76c7bced91ed4f1604a881894313974", async() => {
                WriteLiteral(@"
    <div class=""form-row"">
        <div class=""col-3"">
            <div class=""form-group"">
                <label for=""myNameId"">姓名</label>
                <input required v-bind:placeholder=""phName"" type=""text"" class=""form-control"" id=""myNameId"" v-model.trim=""reservationData.name"" v-on:blur=""checkName"">
");
                WriteLiteral(@"            </div>
        </div>
        <div class=""col-3"">
            <div class=""form-group"">
                <label for=""myTelId"">電話</label>
                <input required v-bind:placeholder=""phTel"" type=""tel"" class=""form-control"" id=""myTelId"" v-model.trim=""reservationData.tel"" v-on:blur=""checkTel"">
            </div>
        </div>
    </div>
    <div class=""form-row"">
        <div class=""col-3"">
            <div class=""form-group"">
                <label for=""myDate1"">入住時間</label>
                <input required v-bind:placeholder=""phName"" type=""date"" class=""form-control"" id=""myDate1"" v-model=""reservationData.date1"">
            </div>
        </div>
        <div class=""col-3"">
            <div class=""form-group"">
                <label for=""myDate2"">退房時間</label>
                <input required type=""date"" class=""form-control"" id=""myDate2"" v-model=""reservationData.date2"">
            </div>
        </div>
    </div>
    <div class=""form-row"">
        <div class=""col-6"">
     ");
                WriteLiteral(@"       <div class=""form-group"">
                <label>天數</label>
                <input v-model=""calDays"" readonly type=""number"" class=""form-control"">
            </div>
        </div>
    </div>
    <div class=""form-row"">
        <div class=""col-6"">
            <div class=""form-group"">
                <label>總價</label>
                <input readonly v-model=""calPrice"" type=""text"" class=""form-control"">
            </div>
        </div>
    </div>

    <button type=""submit"" class=""btn btn-primary"">下一步</button>
    <p>{{reservationData.name}}</p>
    <p>{{reservationData.tel}}</p>
    <p>{{reservationData.date1}}</p>
    <p>{{reservationData.date2}}</p>
    <p>getRoomIdtoView</p>
    <p>{{getRoomIdtoView}}</p>
    <p>{{getRoomIdtoView.weekDayPrice}}</p>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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

<script>
    var v = new Vue({
        el: '#mika',
        data: {
            reservationData: {
                name: '',
                tel: '',
                date1: '',
                date2: ''
            },
            phName: '姓名',
            phTel: '電話號碼',
            getRoomIdtoView: []
        },
        methods: {
            checkName: function () {
                if (this.reservationData.name === '') {
                    this.phName = '不可為空';
                }
            },
            checkTel: function () {
                if (this.reservationData.tel === '') {
                    this.phTel = '不可為空';
                }
            },
            send: function () {

                let data = new FormData();
                data.append('Name', this.reservationData.name);
                data.append('Tel', this.reservationData.tel);
                data.append('CheckInDate', this.reservationData.date1);
                data.append('CheckOutDate', this.");
            WriteLiteral(@"reservationData.date2);


                //POST請求
                axios({
                    method: 'post',
                    url: '/Buyer/getReservation',
                    //API要求的資料
                    data: data,
                    headers: { ""Content-Type"": 'multipart/form-data' }
                })
                    .then(function (response) {
                        if (response.data == true) {
                            alert(""訂房成功"");
                        } else {
                            alert(""訂房失敗"");
                        }

                    })
                    .catch(function (response) {
                        //handle error
                        console.log(response);
                    });

            }
        },
        computed: {
            calDays() {
                var d1 = new Date(this.reservationData.date1);
                var d2 = new Date(this.reservationData.date2);
                var sub = (d2.getTime() - d1.getTime())");
            WriteLiteral(@" / (1000 * 3600 * 24);
                if (sub > 0) {
                    return sub;
                } else if (sub <= 0) {
                    this.reservationData.date1 = '';
                    this.reservationData.date2 = '';
                    alert('請重新填寫');
                }
            },
			CalPrice() {
                var d1GetDay = new Date(this.reservationData.date1).getDay(); // 星期幾0-6 // typeof(d1)=number
                var d2GetDay = new Date(this.reservationData.date2).getDay(); // 星期幾0-6 // typeof(d1)=number

                var d1Format = new Date(this.reservationData.date1)
                var d2Format = new Date(this.reservationData.date2)

                var weekdayP = this.getRoomIdtoView.weekDayPrice; // typeof(weekday)=number
                var weekendP = this.getRoomIdtoView.weekendPrice;

                var temp = d1GetDay; // 星期幾
                var xxx = d1GetDay; // addDay
                var total = 0;
                while (xxx < d2GetDay) {
        ");
            WriteLiteral(@"            if (temp > 6) {
                        temp = temp - 7;
                    }
                    if (temp == 0) {
                        total = total + weekendP;
                    } else if (temp == 6){
                        total = total + weekendP;
                    }else {
                        total = total + weekdayP;
                    }
                    temp = temp + 1;
                    xxx = xxx + 1;
                }




                return total;
            }
        },
        mounted: function () {
            var self = this;
            axios.get(""/Buyer/getRoomIdtoView"").then(function (res) {
                self.getRoomIdtoView = res.data;
            })
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
