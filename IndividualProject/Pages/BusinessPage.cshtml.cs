using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IndividualProject.Pages
{
    [Authorize(Roles = "business")]
    public class BusinessPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
