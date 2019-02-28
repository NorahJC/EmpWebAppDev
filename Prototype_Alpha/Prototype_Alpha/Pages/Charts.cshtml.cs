using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Prototype_Alpha.Pages
{
    public class ChartsModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            ViewData["confirmation"] = $"{Name}, information will be sent to {Email}";
        }
    }
}