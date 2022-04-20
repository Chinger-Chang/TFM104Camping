using System.ComponentModel.DataAnnotations;

namespace FinalProjectFirstTest.Models
{
	public enum Status
	{
		[Display(Name = "已付款")]
		Success,
		[Display(Name = "退款中")]
		Refunding,
		[Display(Name = "已取消")]
		Cancel
	}
}