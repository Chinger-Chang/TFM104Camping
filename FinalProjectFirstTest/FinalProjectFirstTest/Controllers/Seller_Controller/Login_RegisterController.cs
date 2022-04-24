﻿using FinalProjectFirstTest.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Controllers.Seller_Controller
{
	public class Login_RegisterController : Controller
	{
        private readonly FinalProjectDbContext _db;

        public Login_RegisterController(FinalProjectDbContext db)
        {
            _db = db;
        }
        public IActionResult LoginRegister()
		{
			return View();
		}

        [HttpPost]
        public bool Register(RegisterViewModel model)
        {
            var seller = _db.Sellers.FirstOrDefault(x => x.Email == model.Email);
            if (seller == null)
            {
                string salt = Guid.NewGuid().ToString();

                byte[] passwordAndSaltBytes = System.Text.Encoding.UTF8.GetBytes(model.Password + salt);

                byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);

                string hashString = Convert.ToBase64String(hashBytes);
                //此帳號可使用
                _db.Sellers.Add(new Seller()
                {
                    Email = model.Email,
                    Password = hashString,
                    Name = model.Name,
                    Phone = model.Phone,
                    CreateDate = DateTime.Now,
                    IsMailConfirm = false,
                    Salt = salt
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

        [HttpPost]
        public async Task<IActionResult> LoginCheck(LoginViewModel model)
        {
            var seller = _db.Sellers.FirstOrDefault(x => x.Email == model.Email);
            if (seller == null)
            {
                //無此使用者
                return BadRequest("400");
            }
            else
            {
                string salt = seller.Salt;
                byte[] passwordAndSaltBytes = System.Text.Encoding.UTF8.GetBytes(model.Password + salt);
                byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
                string hashString = Convert.ToBase64String(hashBytes);

                if(seller.Password == hashString)
				{
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name,seller.Name),
                        new Claim(ClaimTypes.Email,seller.Email),
                        new Claim("Seller_Id",seller.Id.ToString())
                    };
                    if(seller.Email == "tfm104manager@gmail.com")
					{
                        claims.Add(new Claim(ClaimTypes.Role, "Manager"));
                    }
					else
					{
                        claims.Add(new Claim(ClaimTypes.Role, "Seller"));
					}
                    
                    var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimPrincipal = new ClaimsPrincipal(claimIdentity);
                    await HttpContext.SignInAsync(claimPrincipal);
                    return Json(Url.Action("Seller_OrderDetail", "Order_Detail"));
				    }
                else
                {
                    //有此使用者 但密碼錯誤
                    return BadRequest("401");
                }
            }
        }

        public IActionResult Facebook_Login()
        {
            var fb = new AuthenticationProperties()
            {
                RedirectUri = Url.Action("Facebook_Response")
            };
            return Challenge(fb,FacebookDefaults.AuthenticationScheme);
        }

        public async Task<IActionResult> Facebook_ResponseAsync()
        {
            string email = "";
            string name = "";
            var response = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var data = response.Principal.Claims.Select(x => new
            {
                x.Type,
                x.Value,
                x.Issuer,
                x.OriginalIssuer
            });

            foreach (var item in data)
            {
                if (item.Type.ToLower().Contains("emailaddress"))
                {
                    email = item.Value;
                }
                else if(item.Type.ToLower().Contains("name") && !item.Type.ToLower().Contains("givenname")&& !item.Type.ToLower().Contains("surname"))
				{
                    name = item.Value;
                }
            }

            var seller = _db.Sellers.FirstOrDefault(x => x.Email == email);
            if (seller == null)
            {
                //此帳號可使用
                _db.Sellers.Add(new Seller()
                {
                    Email = email,
                    Name = name,
                    CreateDate = DateTime.Now,
                    IsMailConfirm = true
                });
                _db.SaveChanges();
            }
            Console.WriteLine(email);
            Console.WriteLine(name);

            var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name,name),
                        new Claim(ClaimTypes.Email,email),
                        new Claim(ClaimTypes.Role,"Seller"),

                    }; 

            var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimPrincipal = new ClaimsPrincipal(claimIdentity);
            await HttpContext.SignInAsync(claimPrincipal);
            //return RedirectToAction("login", "Account");

            return RedirectToAction("Seller_OrderDetail", "Order_Detail");
        }

        //[Route("google-login")]
        public IActionResult Google_Login()
        {
            //跟Google拿資料
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("Google_Response") };

            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }

        //[Route("google-response")]
        public async Task<IActionResult> Google_Response()
        {
            string email = "";
            //拿回來的資料 做接收 並作為登入依據
            var response = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            var data = response.Principal.Identities.FirstOrDefault()
                .Claims.Select(claim => new
                {
                    claim.Issuer,
                    claim.OriginalIssuer,
                    claim.Type,
                    claim.Value
                });

            foreach (var item in data)
            {
                if (item.Type.ToLower().Contains("emailaddress"))
                {
                    email = item.Value;
                }
                //else if (item.Type.ToLower().Contains("name") && !item.Type.ToLower().Contains("givenname") && !item.Type.ToLower().Contains("surname"))
                //{
                //    name = item.Value;
                //}
            }

            var seller = _db.Sellers.FirstOrDefault(x => x.Email == email);
            if (seller == null)
            {
                //此帳號可使用
                _db.Sellers.Add(new Seller()
                {
                    Email = email,
                    Name = "Chinger",
                    CreateDate = DateTime.Now,
                    IsMailConfirm = true
                });
                _db.SaveChanges();
            }
            Console.WriteLine(email);
            //Console.WriteLine(name);

            var claims = new List<Claim>()
                    {
                        //new Claim(ClaimTypes.Name,name),
                        new Claim(ClaimTypes.Email,email),
                        new Claim(ClaimTypes.Role,"Seller"),

                    };

            var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimPrincipal = new ClaimsPrincipal(claimIdentity);
            await HttpContext.SignInAsync(claimPrincipal);
            //return RedirectToAction("login", "Account");

            //return RedirectToAction("Seller_OrderDetail", "Order_Detail");

            return Json(claims);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Buyer");//導至登入頁
        }
        public class RegisterViewModel
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
    }
}
