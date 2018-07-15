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
        public static List<Tuple<string, string, string>> GetImages()
        {
            var imageList = SiteAssets.GetImages();
            return imageList;
        }

        public static List<Tuple<string, string, string>> GetResources() 
        {
            var resourceList = SiteAssets.GetResources();
            return resourceList;
        }
    }
}
