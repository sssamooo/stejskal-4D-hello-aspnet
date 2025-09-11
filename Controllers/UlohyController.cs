using Microsoft.AspNetCore.Mvc;
using stejskal_4D_hello_aspnet.Models;

namespace stejskal_4D_hello_aspnet.Controllers
{
    public class UlohyController : Controller
    {
        public IActionResult Uloha1()
        {
            return View();
        }

        public IActionResult Uloha2()
        {
            return View();
        }
        public IActionResult Uloha3()
        {
            return View();
        }

        public IActionResult Uloha4()
        {
            var userInfoList = new List<UserInfo>()
            {
                new UserInfo {
                    Name = "Jude",
                    Email = "test@gmail.com",
                    Tel = "0910358423",
                    UserName = "Belligoal"
                },
                new UserInfo {
                    Name = "Samo",
                    Email = "test123@gmail.com",
                    Tel = "0910546423",
                    UserName = "Dybala"
                }

            };
            return View(userInfoList);
        } 

        public IActionResult Uloha5()
        {
            var userInfoList = new List<UserInfo>()
            {
                new UserInfo {
                    Name = "Jude",
                    Email = "test@gmail.com",
                    Tel = "0910358423",
                    UserName = "Belligoal"
                },
                new UserInfo {
                    Name = "Samo",
                    Email = "test123@gmail.com",
                    Tel = "0910546423",
                    UserName = "Dybala"
                },new UserInfo {
                    Name = "Jano",
                    Email = "jano@gmail.com",
                    Tel = "09105766323",
                    UserName = "Janci"
                }

            };
            return View(userInfoList);
        } 

    }
}