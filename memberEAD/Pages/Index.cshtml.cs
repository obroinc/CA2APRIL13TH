using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace memberEAD.Pages
{
    public class IndexModel : PageModel

    {

        public string Message = "Hi this is my home apge";

        public void OnGet()
        {
            Response.Cookies.Append("tEST cOOKIE", "yOURE BACK ");//Writing a cookie
            
            if(Request.Cookies["tEST cOOKIE"]!=null) //reteievig a cookie
            {
                Message = Request.Cookies["tEST cOOKIE"];
            }


        }
    }
}