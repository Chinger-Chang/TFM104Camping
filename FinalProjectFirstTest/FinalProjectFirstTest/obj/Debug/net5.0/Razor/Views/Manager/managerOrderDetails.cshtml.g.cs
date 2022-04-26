#pragma checksum "C:\Users\user\Desktop\TFM104Camping\FinalProjectFirstTest\FinalProjectFirstTest\Views\Manager\managerOrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c084b93fff840fcd6d8430324c3061d4b1887892"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_managerOrderDetails), @"mvc.1.0.view", @"/Views/Manager/managerOrderDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c084b93fff840fcd6d8430324c3061d4b1887892", @"/Views/Manager/managerOrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ff9cc218848b295820657762e15fb616568996", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_managerOrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
	.a {
		background-color: #000000;
	}

	body {
		background-color: #424242;
	}

	#contact-tab {
		color: white;
		background-color: black;
	}

	#home-tab {
		color: white;
		background-color: black;
	}

	#profile-tab {
		color: white;
		background-color: black;
	}


	#contact-tab:focus {
		color: black;
		background-color: white;
	}


	#home-tab:focus {
		color: black;
		background-color: white;
	}

	#profile-tab:focus {
		color: black;
		background-color: white;
	}

	#myTab {
		background-color: #424242;
	}

	.active {
		background-color: white !important;
		color: black !important;
	}
</style>

<div id=""mika"">
	<ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
		<li class=""nav-item"" role=""presentation"">
			<a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">待確認</a>
		</li>
		<li class=""nav-item"" role=""presentation"">
			<a class=""nav-link"" id=""profile-tab"" data-toggle=""t");
            WriteLiteral(@"ab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">所有訂單</a>
		</li>
	</ul>
	<div class=""tab-content"" id=""myTabContent"">
		<div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
			<template>
				<v-simple-table dark>
					<template v-slot:default>
						<thead>
							<tr>
");
            WriteLiteral(@"								<th scope=""col"">訂單編號</th>
								<th scope=""col"">露營區</th>
								<th scope=""col"">房名</th>
								<th scope=""col"">房型</th>
								<th scope=""col"">訂購人</th>
								<th scope=""col"">電話</th>
								<th scope=""col"">入住時間</th>
								<th scope=""col"">退房時間</th>
								<th scope=""col"">價錢</th>
								<th scope=""col"">狀態</th>
								<th scope=""col"">取消時間</th>
								<th scope=""col"">確認中</th>
							</tr>
						</thead>
						<tbody>
							<tr v-for=""(y,index) in ReOrderDetailsList"">
");
            WriteLiteral(@"								<th scope=""row"">{{y.mOrderDetailID}}</th>
								<th scope=""row"">{{y.campingAreaName}}</th>
								<td>{{y.roomName}}</td>
								<td>{{y.roomType}}</td>
								<th>{{y.name}}</th>
								<th>{{y.phone}}</th>
								<td>{{y.checkInDate}}</td>
								<td>{{y.checkOutDate}}</td>
								<td>{{y.price}}</td>
								<td>{{y.status}}</td>
								<td>{{y.cancelDate}}</td>
								<td>
");
            WriteLiteral("\t\t\t\t\t\t\t\t\t<v-btn v-on:click=\"checkAndSend(y.mOrderDetailID)\" color=\"#8D6E63\" dark ");
            WriteLiteral(@"@click.stop=""dialog = true"">
										確認退款<v-icon right>mdi-emoticon-confused-outline</v-icon>
									</v-btn>
								</td>
							</tr>
						</tbody>
					</template>
				</v-simple-table>
			</template>
		</div>
		<div class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
			<template>
				<v-simple-table dark>
					<template v-slot:default>
						<thead>
							<tr>
");
            WriteLiteral(@"								<th scope=""col"">訂單編號</th>
								<th scope=""col"">露營區</th>
								<th scope=""col"">房名</th>
								<th scope=""col"">房型</th>
								<th scope=""col"">訂購人</th>
								<th scope=""col"">電話</th>
								<th scope=""col"">入住時間</th>
								<th scope=""col"">退房時間</th>
								<th scope=""col"">價錢</th>
								<th scope=""col"">狀態</th>
							</tr>
						</thead>
						<tbody>
							<tr v-for=""(x,index) in AllOrderDetailsList"">
");
            WriteLiteral(@"								<th scope=""row"">{{x.mOrderDetailID}}</th>
								<th scope=""row"">{{x.campingAreaName}}</th>
								<td>{{x.roomName}}</td>
								<td>{{x.roomType}}</td>
								<th>{{x.name}}</th>
								<th>{{x.phone}}</th>
								<td>{{x.checkInDate}}</td>
								<td>{{x.checkOutDate}}</td>
								<td>{{x.price}}</td>
								<td>{{x.status}}</td>
							</tr>
						</tbody>
					</template>
				</v-simple-table>
			</template>
		</div>

	</div>

");
            WriteLiteral("\r\n");
            WriteLiteral("\t<div class=\"modal fade\" id=\"staticBackdrop\" data-backdrop=\"static\" data-keyboard=\"false\" tabindex=\"-1\" aria-labelledby=\"staticBackdropLabel\" aria-hidden=\"true\">\r\n");
            WriteLiteral("\t</div>\r\n\r\n");
            WriteLiteral(@"</div>

<script>
    var a = new Vue({
        el: '#mika',
        data: {
            AllOrderDetailsList: [],
            ReOrderDetailsList: [],
            a: {
                modID:0
            }
        },
        methods: {
            checkAndSend: function (i) {
                //alert(i);
                let self = this;
                self.a.modID = i;
                //alert(self.a.modID);

                //POST請求
                axios({
                    method: 'post',
                    url: '/Manager/GetmodID',
                    //API要求的資料
                    data: self.a,
                    headers: { ""Content-Type"": 'application/json' }
                })
                    .then(function (response) {
                        if (response.data == true) {
                            //alert(""傳入成功"");
                            window.location.reload();

                        } else {
                            alert(""確認退款失敗"");
                  ");
            WriteLiteral(@"      }
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
            axios.get(""/Manager/GetAllOrderDetails"").then(function (res) {
				self.AllOrderDetailsList = res.data;
				console.log(res.data);
            }),
                axios.get(""/Manager/GetReFundingOrderDetails"").then(function (res) {
					self.ReOrderDetailsList = res.data;
					console.log(res.data);
            })
        }
    });
</script>

");
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
