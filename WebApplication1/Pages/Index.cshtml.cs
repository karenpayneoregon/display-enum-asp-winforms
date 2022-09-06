using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        private readonly ILogger<IndexModel> _logger;
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
        }
        [BindProperty]
        public Customer Customer { get; set; }
        public int Id { get; set; }
        public void OnGet()
        {
            Message = "Ready";
            Customer = new Customer
            {
                Name = "Karen", 
                Type = CustomerType.Select
            };
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Message = $"Posted {Customer.Name}";
            }
            
        }
    }
}