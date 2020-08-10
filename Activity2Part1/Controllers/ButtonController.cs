using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Activity2Part1.Controllers
{
    public class ButtonController : Controller
    {
        static List<ButtonModel> buttons = new List<ButtonModel>();
        Random random = new Random();
        // GET: Button
        public ActionResult Index()
        {
            for(int i = 0; i < 2; i++)
            {
                if (random.Next(2) > 1)
                    buttons.Add(new ButtonModel(true));
                else
                    buttons.Add(new ButtonModel(false));
            }
            return View("Button", buttons);
        }

        public ActionResult HandleButtonClick(string mine)
        {
            int buttonNumber = Int32.Parse(mine);
            buttons[buttonNumber].State = !buttons[buttonNumber].State;
            return View("Button", buttons);
        }
    }
}