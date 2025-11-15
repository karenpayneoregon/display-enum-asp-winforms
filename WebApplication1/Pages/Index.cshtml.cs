using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Classes;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public string? Message { get; set; }
        private readonly ILogger<IndexModel> _logger;
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public Customer? Customer { get; set; }

        public int Id { get; set; }
        public void OnGet()
        {
            Message = "Ready";

            // get a different customer each time
            Customer = BogusOperations.Customers().FirstOrDefault();
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                // This is the selected enum value from the <select>
                var selectedType = Customer!.Type;

                // If you need the underlying int:
                var selectedIndex = (int)selectedType;

                /*
                 * Security note: only do this with content you generate on the server (like your formatted message).
                 * Never feed untrusted user input through Html.Raw unless you sanitize it first, or you’re asking for XSS trouble.
                 *
                 * @Html.Raw(Model.Message)
                 * 
                 */
                Message = $"Posted <strong>{Customer.Name}</strong> with type " +
                          $"<strong>{selectedType}</strong> " +
                          $"(index <strong>{selectedIndex}</strong>)";
            }
        }
    }
}