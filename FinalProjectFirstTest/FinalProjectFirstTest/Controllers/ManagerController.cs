using FinalProjectFirstTest.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly FinalProjectDbContext _db;
        public ManagerController(IWebHostEnvironment environment, FinalProjectDbContext db)
        {
            _environment = environment;
            _db = db;
        }
        // 管理者訂單
        public IActionResult ManagerOrderDetails()
        {
            return View();
        }
        // 拿所有訂單
        public List<MOrderDetailViewModel> GetAllOrderDetails()
        {
            //var a = _db.OrderDetailsTest.FirstOrDefault();

            var s = (from od in _db.OrderDetails.Where(x => x.Status != Status.Favority)
                     join r in _db.Rooms on od.RoomId equals r.Id
                     join ca in _db.Camping_Areas on r.Camping_AreaId equals ca.Id
                     orderby od.Id descending
                     select new MOrderDetailViewModel
                     {
                         MOrderDetailID = od.Id,
                         Name = od.Name,
                         Phone = od.Phone,
                         CampingAreaName = ca.Name,
                         RoomName = r.Name,
                         RoomType = r.RoomType.GetType().GetMember(r.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                         CheckInDate = od.StartDate.ToString("yyyy-MM-dd"),
                         CheckOutDate = od.EndDate.ToString("yyyy-MM-dd"),
                         Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),
                         Status = od.Status.GetType().GetMember(od.Status.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName()
                     }).ToList();
            return s;
        }
        // 拿退款中的訂單
        public List<MOrderDetailViewModel> GetReFundingOrderDetails()
        {
            //var a = _db.OrderDetailsTest.FirstOrDefault();

            var s = (from od in _db.OrderDetails.Where(x => x.Status == Status.Refunding)
                     join r in _db.Rooms on od.RoomId equals r.Id
                     join ca in _db.Camping_Areas on r.Camping_AreaId equals ca.Id
                     orderby od.Id descending
                     select new MOrderDetailViewModel
                     {
                         MOrderDetailID = od.Id,
                         Name = od.Name,
                         Phone = od.Phone,
                         CampingAreaName = ca.Name,
                         RoomName = r.Name,
                         RoomType = r.RoomType.GetType().GetMember(r.RoomType.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                         CheckInDate = od.StartDate.ToString("yyyy-MM-dd"),
                         CheckOutDate = od.EndDate.ToString("yyyy-MM-dd"),
                         Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),
                         Status = od.Status.GetType().GetMember(od.Status.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                         CancelDate = od.CancelDate.HasValue ? od.CancelDate.Value.ToString("yyyy-MM-dd") : ""   // 問 Reds:)
                     }).ToList();
            return s;
        }
        // 管理者確認退款後 ==> 傳回指定OrderDetailsID ==> 更改status為Cancel
        [HttpPost]
        public bool GetmodID([FromBody] mOdID model)
        {
            var od = _db.OrderDetails.Where(x => x.Id == model.modid).FirstOrDefault();

            if (od != null && od.Status == Status.Refunding)
            {
                od.Status = Status.Cancel;
                //od.CancelDate = 記得加取消時間
                od.CancelDate = DateTime.Now;
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //--------------- ViewModel -------------------------------
        public class MOrderDetailViewModel
        {
            public int MOrderDetailID { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string CampingAreaName { get; set; }
            public string RoomName { get; set; }
            public string RoomType { get; set; }
            public string CheckInDate { get; set; }
            public string CheckOutDate { get; set; }
            public decimal Price { get; set; }
            public string Status { get; set; }
            public string CancelDate { get; set; }
        }
        public class mOdID
        {
            public decimal modid { get; set; }
        }
    }
}
