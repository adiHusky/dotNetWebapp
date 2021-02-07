using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace webapp.Pages
{
    public class NotAfraidModel : PageModel
    {
        private readonly ILogger<NotAfraidModel> _logger;

        public NotAfraidModel(ILogger<NotAfraidModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
