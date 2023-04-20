using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication_Razor.Models;

namespace WebApplication_Razor.Pages
{
    public class MyPageModel : PageModel
    {
        public List<Hobby> Hobbies { get; set; } = new List<Hobby>();


        public async Task OnGetAsync()
        {
            Hobbies.Add(new Hobby()
            {
                Id = 1,
                Name = "Family",
                Description = "Spending time with my family",
                Priority = "High",
                Image = "https://iotcdn.oss-ap-southeast-1.aliyuncs.com/2020-11/Family-Silhouette-3.jpg"

            });
            Hobbies.Add(new Hobby()
            {
                Id = 2,
                Name = "Reading",
                Description = "Reading books about space",
                Priority = "Medium",
                Image = "https://images.indianexpress.com/2022/07/book.jpg"

            });
            Hobbies.Add(new Hobby()
            {
                Id = 3,
                Name = "Travelling",
                Description = "Travelling by different countries",
                Priority = "Low",
                Image = "https://img.freepik.com/premium-photo/traveling-luggage-airport-terminal_34013-3.jpg?w=2000"

            });
        }
    }
}
