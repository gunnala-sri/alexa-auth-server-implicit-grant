using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImplictGrant.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var request = HttpContext.Request;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //https://pitangui.amazon.com/spa/skill/account-linking-status.html?vendorId=M2AAAAAAAAAAAA#state=xyz&access_token=2YotnFZFEjr1zCsicMWpAA&token_type=Bearer

            var url = request.Query["redirect_uri"] + "#state=" + request.Query["state"] + "&access_token=2YotnFZFEjr1zCsicMWpAA&token_type=Bearer";
            return Redirect(url);
        }
    }
}
