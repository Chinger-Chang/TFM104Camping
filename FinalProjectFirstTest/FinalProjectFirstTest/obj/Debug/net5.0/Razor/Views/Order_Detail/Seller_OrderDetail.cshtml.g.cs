#pragma checksum "C:\Users\user\Desktop\TFM104Camping\FinalProjectFirstTest\FinalProjectFirstTest\Views\Order_Detail\Seller_OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27af19c006d8c377d548cd834b50b87bf913a58e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Detail_Seller_OrderDetail), @"mvc.1.0.view", @"/Views/Order_Detail/Seller_OrderDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27af19c006d8c377d548cd834b50b87bf913a58e", @"/Views/Order_Detail/Seller_OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ff9cc218848b295820657762e15fb616568996", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Detail_Seller_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>

	/*tbody > tr:nth-child(odd) {
		background-color: white;
	}*/

	tbody > tr:nth-child(even) {
		background-color: #cbcaca;
		
	}

</style>
<div class=""mt-5"" id=""mika"">
	<ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
		<li class=""nav-item"" role=""presentation"">
			<a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">訂單</a>
		</li>
		<li class=""nav-item"" role=""presentation"">
			<a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">歷史訂單</a>
		</li>
		<li class=""nav-item"" role=""presentation"">
			<input type=""text"" v-model=""search"" placeholder=""搜尋關鍵字""/>
		</li>
	</ul>
	<div class=""tab-content"" id=""myTabContent"">
		<div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
			<table class=""table bordered"" >
				<thead class=""thead-dark"">
					<tr>
						<th scope=""col"">露營區</th>
						<th scope=""c");
            WriteLiteral(@"ol"">房型</th>
						<th scope=""col"">訂購人</th>
						<th scope=""col"">電話</th>
						<th scope=""col"">入住時間</th>
						<th scope=""col"">退房時間</th>
						<th scope=""col"">價錢</th>
						<th scope=""col"">狀態</th>
						<th scope=""col"">取消</th>
					</tr>
				</thead>
				<tbody>
					<tr v-for="" (item,index) in searchOrderDetail"">
						<td>{{item.campingAreaName}}</td>
						<td>{{item.roomType}}</td>
						<td>{{item.name}}</td>
						<td>{{item.phone}}</td>
						<td>{{item.checkInDate}}</td>
						<td>{{item.checkOutDate}}</td>
						<td>{{item.price}}</td>
						<td>{{item.status}}</td>
						<td>
							<button v-show=""item.status == '已付款'"" v-on:click=""cancle(index)"" type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#staticBackdrop"">
								取消訂單
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
	");
            WriteLiteral(@"					<th scope=""col"">露營區</th>
						<th scope=""col"">房型</th>
						<th scope=""col"">訂購人</th>
						<th scope=""col"">電話</th>
						<th scope=""col"">入住時間</th>
						<th scope=""col"">退房時間</th>
						<th scope=""col"">價錢</th>
						<th scope=""col"">狀態</th>
						<th scope=""col"">取消時間</th>
					</tr>
				</thead>
				<tbody>
					<tr v-for=""(item,index) in searchCancelOrderDetailsList"">
						<td>{{item.campingAreaName}}</td>
						<td>{{item.roomType}}</td>
						<td>{{item.name}}</td>
						<td>{{item.phone}}</td>
						<td>{{item.checkInDate}}</td>
						<td>{{item.checkOutDate}}</td>
						<td>{{item.price}}</td>
						<td>{{item.status}}</td>
						<td>{{item.cancelDate}}</td>
					</tr>
				</tbody>
			</table>
		</div>
	</div>


	<div class=""modal fade"" id=""staticBackdrop"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
		<div class=""modal-dialog"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<");
            WriteLiteral(@"h5 class=""modal-title"" id=""staticBackdropLabel"">確定取消??</h5>
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
</div>

<script>
    var a = new Vue({
        el: '#mika',
        data: {
			OrderDetailsList: {},
			CancelOrderDetailsList: {},
			search:"""",
				odID: 0
			
        },
        methods: {
            cancle: function (a) {
                let self = this;
				self.odID = self.OrderDetailsList[a].orderDetailId;
				console.log(self.odID);
            },
			sendodID: function () {
				console.log(""aaa"");
                let self = this;
                //POST請求
         ");
            WriteLiteral(@"       axios({
                    method: 'post',
					url: '/Order_Detail/Delete_Order_Detail',
					data: self.odID,
                    headers: { ""Content-Type"": 'application/json' }
                })
                    .then(function (response) {
                        if (response.data == true) {
                            alert(""傳入成功"");
                            window.location.reload();

                        } else {
                            alert(""取消失敗"");
                        }
                    })
                    .catch(function (response) {
                        //handle error
                        console.log(response.data);
                       // window.location.href = response.data
                    });
            }
		},
		computed: {
			searchOrderDetail() {
				let se = []
				if (this.search !== '') {
					se = this.OrderDetailsList.filter(p =>
						p.campingAreaName.toLowerCase().includes(this.search.toLowerCase()) ||
						p.roomT");
            WriteLiteral(@"ype.toLowerCase().includes(this.search.toLowerCase()) ||
						p.name.toLowerCase().includes(this.search.toLowerCase()) ||
						p.phone.toLowerCase().includes(this.search.toLowerCase()) ||
						p.checkInDate.toLowerCase().includes(this.search.toLowerCase()) ||
						p.checkOutDate.toLowerCase().includes(this.search.toLowerCase()) ||
						p.status.toLowerCase().includes(this.search.toLowerCase()) ||
						p.cancelDate.toLowerCase().includes(this.search.toLowerCase()) ||
						p.price === Number(this.search)
					)
				} else {
					se = this.OrderDetailsList;
				}
				return se
			},
			searchCancelOrderDetailsList() {
				let se = []
				if (this.search !== '') {
					se = this.CancelOrderDetailsList.filter(p =>
						p.campingAreaName.toLowerCase().includes(this.search.toLowerCase()) ||
						p.roomType.toLowerCase().includes(this.search.toLowerCase()) ||
						p.name.toLowerCase().includes(this.search.toLowerCase()) ||
						p.phone.toLowerCase().includes(this.search.toLowerCase()) ");
            WriteLiteral(@"||
						p.checkInDate.toLowerCase().includes(this.search.toLowerCase()) ||
						p.checkOutDate.toLowerCase().includes(this.search.toLowerCase()) ||
						p.status.toLowerCase().includes(this.search.toLowerCase()) ||
						p.cancelDate.toLowerCase().includes(this.search.toLowerCase()) ||
						p.price === Number(this.search)
					)
				} else {
					se = this.CancelOrderDetailsList;
				}
				return se
			}
		},
        mounted: function () {
            var self = this;
			axios.get(""/Order_Detail/Get_Order_Details"").then(function (res) {
				self.OrderDetailsList = res.data;
				console.log(self.OrderDetailsList);
				
			});
			axios.get(""/Order_Detail/Get_Cancel_Order_Details"").then(function (res) {
					self.CancelOrderDetailsList = res.data;
					//console.log(res.data);
				});
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
