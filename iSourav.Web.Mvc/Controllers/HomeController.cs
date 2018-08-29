using System.Web.Mvc;
using iSourav.Domain.Interfaces;
using iSourav.Domain.Interfaces.Repositories;
using iSourav.Domain.Entities;
using iSourav.Domain.Interfaces.Providers;

namespace iSourav.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITest _iTest;
        private readonly ICourseRepository _iCourse;
        private readonly ILoggerProvider _iLog;
        private readonly INotificationProvider _iNotification; 
        public HomeController(ITest iTest, ICourseRepository iCourse, ILoggerProvider iLog, INotificationProvider iNotification)
        {
            _iTest = iTest;
            _iCourse = iCourse;
            _iLog = iLog;
            _iNotification = iNotification;
        }
        public ActionResult Index()
        {
            //string name = _iTest.SayHello("Sourav");
            //return View(model: name);
            Course c = new Course();
            c = _iCourse.Get(1);
            _iLog.Info("Log from Index");
            _iNotification.Send("test@gmail.com", "Test", "Body message");

            return View(c);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}