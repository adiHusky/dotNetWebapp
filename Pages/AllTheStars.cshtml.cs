using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace webapp.Pages
{
    public class AllTheStarsModel : PageModel
    {
        private readonly ILogger<AllTheStarsModel> _logger;

        public AllTheStarsModel(ILogger<AllTheStarsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
