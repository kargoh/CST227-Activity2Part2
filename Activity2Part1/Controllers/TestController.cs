using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel("Test Data 1", "Test1@gmail.com", "(121)-456-7890"));
            users.Add(new UserModel("Test Data 2", "Test2@gmail.com", "(122)-456-7890"));
            users.Add(new UserModel("Test Data 3", "Test3@gmail.com", "(123)-456-7890"));
            users.Add(new UserModel("Test Data 4", "Test4@gmail.com", "(124)-456-7890"));

            return View("Test", users);
        }

        

    }
}