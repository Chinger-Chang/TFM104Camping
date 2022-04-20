using FinalProjectFirstTest.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Controllers
{
    public class BuyerController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly FinalProjectDbContext _db;
        public BuyerController(IWebHostEnvironment environment, FinalProjectDbContext db)
        {
            _environment = environment;
            _db = db;
        }
        // 買家首頁
        public IActionResult Index()
        {
            return View();
        }
        // 拿首頁資訊
        public List<IndexInfo> getIndexInfo()
        {
            var s = _db.Camping_Areas.Select(x => new IndexInfo
            {
                CampingAreaId = x.Id,
                CampingAreaName = x.Name,
                PicPath = x.Camping_Area_Pictures.Any()? x.Camping_Area_Pictures.FirstOrDefault().Path:"", //Reds
                Region = x.Region
            }).ToList();
            return s;
        }
        // 首頁點露營區 ==> 看房型
        [Route("[controller]/[action]/{id}")]
        public IActionResult RoomInfo([FromRoute] int? id)
        {
            if(id!=null)
            {
                HttpContext.Session.SetString("caid", id.ToString());
            }
            return View();
        }
        // 拿某露營區的房型資訊
        [HttpGet]
        public RoomInfoViewModel getRoomInfo(RoomInfoViewModel model)
        {
            string caid = HttpContext.Session.GetString("caid");
            int CAid = Convert.ToInt32(caid);

            var camp = _db.Camping_Areas.Where(x => x.Id == CAid).FirstOrDefault();
            var service = _db.Services.Where(x => x.Camping_AreaId == camp.Id).FirstOrDefault();

            var s = new RoomInfoViewModel
            {
                CAId = camp.Id,
                CAname = camp.Name,
                CAaddress = camp.Address,
                CAphone = camp.Phone,
                CAdescription = camp.Description,
                CApicPath = _db.Camping_Area_Pictures.Where(x => x.Camping_AreaId == camp.Id).Select(s => s.Path).ToList(),
                Wifi = service.Wifi,
                Breakfast = service.Breakfast,
                Canopy = service.Canopy,
                Canteen = service.Canteen,
                Dinner = service.Dinner,
                IsCancel = service.IsCancel,
                Kitchen_Utensils = service.Kitchen_Utensils,
                Lunch = service.Lunch,
                Mattress = service.Mattress,
                Night_Lighting = service.Night_Lighting,
                No_Equipment = service.No_Equipment,
                Outdoor_Tables_Chairs = service.Outdoor_Tables_Chairs,
                Power_Supply = service.Power_Supply,
                Public_Refrigerator = service.Public_Refrigerator,
                Tent_Equipment = service.Tent_Equipment,
                Rooms = _db.Rooms.Where(x => x.Camping_AreaId == camp.Id).Select(z => new Myroom{
                    RoomId = z.Id,
                    RoomName = z.Name,
                    RoomType = z.RoomType.ToString(),
                    PriceOfWeekDay = z.Price_Of_Weekdays,
                    Room_Path = _db.Room_Pictures.Where(y => y.RoomId == z.Id).FirstOrDefault().Path
                }).ToList()
            };
            return s;
        }
        // 買家 註冊+登入
        public IActionResult register()
        {
            return View();
        }
        // 註冊 ==> 確認帳號使否用過
        [HttpPost]
        public bool registerCheck(UserViewModel model)
        {
            var user = _db.Users.FirstOrDefault(x => x.Email == model.Email);
            if(user == null)
            {
                //此帳號可使用
                _db.Users.Add(new Models.User()
                {
                    Email = model.Email,
                    Password = model.Password,
                    Name = model.Name,
                    Phone = model.Phone,
                    CreateDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                });
                _db.SaveChanges();
                return true;
            }
            else
            {
                //此帳號已被使用
                return false;
            }
        }
        // 登入 ==> 確認是否有這位使用者
        public async Task<IActionResult> LoginCheck(LoginViewModel model)
        {
            var user = _db.Users.FirstOrDefault(x => x.Email == model.Email);
            if(user == null)
            {
                //無此使用者
                return Json(Url.Action("register", "Buyer"));
            }
            else if(user.Email == model.Email && user.Password == model.Password)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,user.Name),
                    new Claim(ClaimTypes.Email,user.Email),
                    new Claim("User_Id",user.Id.ToString())
                };
                var claimIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                var claimPrincipal = new ClaimsPrincipal(claimIdentity);
                await HttpContext.SignInAsync(claimPrincipal);
                //return RedirectToAction("Index","Home");
                return Json(Url.Action("Index", "Buyer"));
            }
            else
            {
                //有此使用者 但密碼錯誤
                return Json(Url.Action("register", "Buyer"));
            }
        }
        //--------------------------------------------------------------------------
        // 訂房
        public IActionResult reservation()
        {
            return View();
        }
        // 傳 roomID + room平日/假日價錢
        public getRoomIdandPrice getRoomIdtoView(getRoomIdandPrice model)
        {
            // 拿roomId
            int roomId = 1;

            var room = _db.Rooms.FirstOrDefault(x => x.Id == roomId);
            var s = new getRoomIdandPrice
            {
                RoomId = room.Id,
                WeekDayPrice = room.Price_Of_Weekdays,
                WeekendPrice = room.Price_Of_Weekends
            };
            return s;
        }
        // 拿買家訂房資訊
        public void getReservation(getReservationViewModel model)
        {

        }
        //--------------------------------------------------------------------------
        // 買家訂單明細
        public IActionResult BOrderDetail()
        {
            return View();
        }
        // 取某User訂單明細
        public List<OrderDetailViewModel> GetOrderDetails()
        {
            var userId = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "User_Id").Value);
            //&& x.Status == Status.Success
            var s = (from od in _db.OrderDetails.Where(x => x.UserId == userId && x.Status != Status.Cancel)
                     join r in _db.Rooms on od.RoomId equals r.Id
                     join ca in _db.Camping_Areas on r.Camping_AreaId equals ca.Id
                     select new OrderDetailViewModel
                     {
                         OrderDetailId = od.Id,
                         CampingAreaName = ca.Name,
                         RoomName = r.Name,
                         CheckInDate = od.StartDate.ToString("yyyy-MM-dd"),
                         CheckOutDate = od.EndDate.ToString("yyyy-MM-dd"),
                         Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),
                         Status = od.Status.ToString()
                     }).ToList();
            return s;
        }
        // 取某User訂單明細 cancel
        public List<OrderDetailViewModel> GetCancelOrderDetails()
        {
            var userId = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "User_Id").Value);
            //&& x.Status == Status.Success
            var s = (from od in _db.OrderDetails.Where(x => x.UserId == userId && x.Status == Status.Cancel)
                     join r in _db.Rooms on od.RoomId equals r.Id  
                     join ca in _db.Camping_Areas on r.Camping_AreaId equals ca.Id
                     select new OrderDetailViewModel
                     {
                         OrderDetailId = od.Id,
                         CampingAreaName = ca.Name,
                         RoomName = r.Name,
                         CheckInDate = od.StartDate.ToString("yyyy-MM-dd"),
                         CheckOutDate = od.EndDate.ToString("yyyy-MM-dd"),
                         Price = CalPrice.CalDaysPrice(od.StartDate, od.EndDate, r.Price_Of_Weekdays, r.Price_Of_Weekends),
                         Status = od.Status.ToString(),
                         CancelDate = od.CancelDate.HasValue ? od.CancelDate.Value.ToString("yyyy-MM-dd") : ""
                     }).ToList();
            return s;
        }
        // 取消後 ==> 傳回指定OrderDetailsID ==> Status改為Refunding
        [HttpPost]
        public bool GetodID([FromBody] OdID model)
        {
            var od = _db.OrderDetails.Where(x => x.Id == model.odid).FirstOrDefault();

            if (od != null && od.Status == Status.Success)
            {
                od.Status = Status.Refunding;
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        // 買家基本資料
        public IActionResult userInfo()
        {
            return View();
        }
        // 取某User基本資料
        public BuyerInfo GetUserInfo()
        {
            //Console.WriteLine(User.Claims.FirstOrDefault(x => x.Type == "User_Id").Value);
            var userId = Int32.Parse(User.Claims.FirstOrDefault(x => x.Type == "User_Id").Value);
            var user = _db.Users.FirstOrDefault(x => x.Id == userId);

            var info = new BuyerInfo
            {
                id = user.Id,
                name = user.Name,
                email = user.Email,
                phone = user.Phone,
                password = user.Password
            };
            return info;
        }
        // 拿買家編輯後的資料
        [HttpPost]
        public bool GetNewUserInfo([FromBody]NewUserInfo model)
        {
            var newUser = _db.Users.Where(x => x.Id == model.Id).FirstOrDefault();
            newUser.Name = model.Name;
            newUser.Email = model.Email;
            newUser.Phone = model.Phone;
            newUser.Password = model.Password;
            _db.SaveChanges();
            return true;
            
        }
        //----------測試用-----------------------------------------
        public IActionResult test()
        {
            return View();
        }
        public IActionResult test2()
        {
            return View();
        }
        //----------ViewModel--------------------------------------
        public class NewUserInfo
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Password { get; set; }
        }
        public class UserViewModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }

        }
        public class LoginViewModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
        public class OrderDetailViewModel
        {
            public int OrderDetailId { get; set; }
            public string CampingAreaName { get; set; }
            public string RoomName { get; set; }
            public string CheckInDate { get; set; }
            public string CheckOutDate { get; set; }
            public decimal Price { get; set; }
            public string Status { get; set; }
            public string CancelDate { get; set; }
        }
        public class BuyerInfo
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string password { get; set; }
        }
        public class OdID
        {
            public decimal odid { get; set; }
        }
        public class IndexInfo
        {
            public int CampingAreaId { get; set; }
            public string CampingAreaName { get; set; }
            public string PicPath { get; set; }
            public Region Region { get; set; }

        }
        public class RoomInfoViewModel
        {
            public int CAId { get; set; }
            public string CAname { get; set; }
            public List<string> CApicPath { get; set; }
            public string CAdescription { get; set; }
            public string CAaddress { get; set; }
            public string CAphone { get; set; }
            public bool Wifi { get; set; }
            public bool Breakfast { get; set; }
            public bool Canopy { get; set; }
            public bool Canteen { get; set; }
            public bool Dinner { get; set; }
            public bool IsCancel { get; set; }
            public bool Kitchen_Utensils { get; set; }
            public bool Lunch { get; set; }
            public bool Mattress { get; set; }
            public bool Night_Lighting { get; set; }
            public bool No_Equipment { get; set; }
            public bool Outdoor_Tables_Chairs { get; set; }
            public bool Power_Supply { get; set; }
            public bool Public_Refrigerator { get; set; }
            public bool Tent_Equipment { get; set; }
            public List<Myroom> Rooms { get; set; }

        }
        public class Myroom
        {
            public int RoomId { get; set; }
            public decimal PriceOfWeekDay { get; set; }
            public string RoomName { get; set; }
            public string RoomType { get; set; }
            public string Room_Path { get; set; }
        }
        public class getReservationViewModel
        {
            public string Name { get; set; }
            public string Tel { get; set; }
            public string CheckInDate { get; set; }
            public string CheckOutDate { get; set; }
        }

        public class getRoomIdandPrice
        {
            public int RoomId { get; set; }
            public decimal WeekDayPrice { get; set; }
            public decimal WeekendPrice { get; set; }

        }


    }
}
