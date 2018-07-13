using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace scotusPages.Pages
{
    public class IndexModel : PageModel
    {
        public static List<Tuple<string, string>> OnGet()
        {
            var imageList = ImageList.GetList();
            return imageList;
        }
    }
}
