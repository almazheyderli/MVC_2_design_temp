using Microsoft.AspNetCore.Mvc;
using mvcDesignTemp.DAL;
using mvcDesignTemp.Models;
using mvcDesignTemp.ViewModels;

namespace mvcDesignTemp.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext)
        {
            _dbContext=dbContext;
        }

        public IActionResult Index()
        {


            //Services service1 = new Services()
            //{
            //    Name = "UI/UX design",
            //    Description = "service1",
            //    Image="services-01.jpg"
            //};
            //Services service2 = new Services()
            //{
            //    Name = "Sosial Media",
            //    Description = "service2",
            //    Image="services-02.jpg"
            //};
            //Services service3 = new Services()
            //{
            //    Name = "Marketing",
            //    Description = "service3",
            //    Image="services-03.jpg"
            //};
            //Services service4 = new Services()
            //{
            //    Name = "Graphic",
            //    Description = "service4",
            //    Image="services-04.jpg"

            //};
            //Services service5 = new Services()
            //{
            //    Name = "Digital Marketing",
            //    Description = "service5",
            //    Image="services-05.jpg"
            //};
            //Services service6 = new Services()
            //{
            //    Name = "Market Research",
            //    Description = "service6",
            //    Image="services-06.jpg"
            //};
            //Services service7 = new Services()
            //{
            //    Name = "Business",
            //    Description = "service7",
            //    Image="services-07.jpg"
            //};
            //Services service8 = new Services()
            //{
            //    Name = "Branding",
            //    Description = "service8",
            //    Image="services-08.jpg"
            //};
            //List<Services> services = new List<Services>();
            //services.Add(service1);
            //services.Add(service2);
            //services.Add(service3);
            //services.Add(service4);
            //services.Add(service5);
            //services.Add(service6);
            //services.Add(service7);
            //services.Add(service8);
            HomeVM homeVM = new HomeVM()
            {
                Services = _dbContext.Services.ToList(),

            };

            //_dbContext.Add(service1);
            //_dbContext.Add(service2);
            //_dbContext.Add(service3);
            //_dbContext.Add(service4);
            //_dbContext.Add(service5);
            //_dbContext.Add(service6);
            //_dbContext.Add(service7);
            //_dbContext.Add(service8);
            //_dbContext.SaveChanges();


            return View(homeVM);
        }
    }
}
