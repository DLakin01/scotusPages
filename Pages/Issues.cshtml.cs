using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using scotusPages.Pages.Shared;

namespace scotusPages.Pages
{
    public class IssuesModel : PageModel
    {

        public string Issue = "";

        public void OnGet()
        {
            Issue = Request.Query["i"];
        }
    }
}
