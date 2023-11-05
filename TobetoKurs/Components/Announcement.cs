using Microsoft.AspNetCore.Mvc;

namespace TobetoKurs.Components
{
    public class Announcement:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
