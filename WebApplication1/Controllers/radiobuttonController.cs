using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class radiobuttonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }

    public class radiobutton
    {
        public submit_click(radiobuttonmodel vm)
        {
            if (radiobutton.checked == true)
            {
                    MessageBox.Show("selected yes");
                    return;
                }
                else
                {
                    MessageBox.Show("selected no");
                    return;
                }


                }
    }
}