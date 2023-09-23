using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Nicole Bayhon", StudentId = "21-1471", StudentAge = "20" },
            new StudentInfoModel { Name = "Marilou Bayhon", StudentId = "21-2342", StudentAge = "55" },
            new StudentInfoModel { Name = "Vicente Bayhon", StudentId = "21-4578", StudentAge = "60" }
    
            
        };

        return View(studentInfoArray);
    }
}
