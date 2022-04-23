#pragma checksum "C:\Users\user\Desktop\TFM104Camping\FinalProjectFirstTest\FinalProjectFirstTest\Views\Buyer\BOrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "419d3326c9c53a78c32c1843b23492c80f5f8d7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buyer_BOrderDetail), @"mvc.1.0.view", @"/Views/Buyer/BOrderDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419d3326c9c53a78c32c1843b23492c80f5f8d7d", @"/Views/Buyer/BOrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ff9cc218848b295820657762e15fb616568996", @"/Views/_ViewImports.cshtml")]
    public class Views_Buyer_BOrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div id=""mika"">
    <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
        <li class=""nav-item"" role=""presentation"">
            <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">已預定</a>
        </li>
        <li class=""nav-item"" role=""presentation"">
            <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">歷史訂單</a>
        </li>
    </ul>
    <div class=""tab-content"" id=""myTabContent"">
        <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
");
            WriteLiteral(@"                        <th scope=""col"">露營區</th>
                        <th scope=""col"">房型</th>
                        <th scope=""col"">入住時間</th>
                        <th scope=""col"">退房時間</th>
                        <th scope=""col"">價錢</th>
                        <th scope=""col"">狀態</th>
                        <th scope=""col"">取消?</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="" (x,index) in OrderDetailsList"">
");
            WriteLiteral(@"                        <th scope=""row"">{{x.campingAreaName}}</th>
                        <td>{{x.roomName}}</td>
                        <td>{{x.checkInDate}}</td>
                        <td>{{x.checkOutDate}}</td>
                        <td>{{x.price}}</td>
                        <td>{{x.status}}</td>
                        <td>
                            <button v-show=""x.status == 'Success'"" v-on:click=""cancle(x.orderDetailId,x.status)"" type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#staticBackdrop"">
                                我想取消
                            </button>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th scope=""col"">露營區</th>
                        <th scop");
            WriteLiteral(@"e=""col"">房型</th>
                        <th scope=""col"">入住時間</th>
                        <th scope=""col"">退房時間</th>
                        <th scope=""col"">價錢</th>
                        <th scope=""col"">狀態</th>
                        <th scope=""col"">取消時間</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for=""(y,index) in CancelOrderDetailsList"">
                        <th scope=""row"">{{y.campingAreaName}}</th>
                        <td>{{y.roomName}}</td>
                        <td>{{y.checkInDate}}</td>
                        <td>{{y.checkOutDate}}</td>
                        <td>{{y.price}}</td>
                        <td>{{y.status}}</td>
                        <td>{{y.cancelDate}}</td>
                    </tr>
                </tbody>
            </table>
        </div>

    </div>

");
            WriteLiteral("\r\n");
            WriteLiteral(@"    <div class=""modal fade"" id=""staticBackdrop"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""staticBackdropLabel"">確定取消??</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    取消就救不回來了:)
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">關閉</button>
                    <button v-on:click=""sendodID"" type=""button"" class=""btn btn-primary"">確定</button>
                </div>
            </div>
        </div>
    </div>
    <p>Success + Ref");
            WriteLiteral(@"unding</p>
    <p>{{CancelOrderDetailsList}}</p>
    <p>Cancel</p>
    <p>{{OrderDetailsList}}</p>

</div>

<script>
    var a = new Vue({
        el: '#mika',
        data: {
            OrderDetailsList: [],
            CancelOrderDetailsList: [],
            a: {
                odID: 0
            }
        },
        methods: {
            cancle: function (i, s) {
                //alert(i);
                //alert(s);
                let self = this;
                self.a.odID = i;
                //alert(self.a.odID);
            },
            sendodID: function () {
                let self = this;

                //POST請求
                axios({
                    method: 'post',
                    url: '/Buyer/GetodID',
                    //API要求的資料
                    data: self.a,
                    headers: { ""Content-Type"": 'application/json' }
                })
                    .then(function (response) {
                        if (response.data");
            WriteLiteral(@" == true) {
                            //alert(""傳入成功"");
                            window.location.reload();

                        } else {
                            alert(""取消失敗"");
                        }
                    })
                    .catch(function (response) {
                        //handle error
                        //console.log(response.data);
                        window.location.href = response.data
                    });
            }
        },
        mounted: function () {
            var self = this;
            axios.get(""/Buyer/GetOrderDetails"").then(function (res) {
                self.OrderDetailsList = res.data;
            }),
                axios.get(""/Buyer/GetCancelOrderDetails"").then(function (res) {
                self.CancelOrderDetailsList = res.data;
            })
        }
    });
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
