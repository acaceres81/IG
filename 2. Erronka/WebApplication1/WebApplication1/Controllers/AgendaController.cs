using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AgendaController : Controller
    {
        public ActionResult Details()
        {
            Contacto kontaktua = new Contacto("13456765", "izaskun", "Kortabitarte");
            kontaktua.Emaila = "ikortabitarte@uni.eus";
            return View(kontaktua);
        }

        public ActionResult Index()
        {
            List<Contacto> lstKontaktuak = new List<Contacto>();
            
            Contacto kontaktua1 = new Contacto("13456765", "izaskun", "Kortabitarte");
            kontaktua1.Emaila = "ikortabitarte@uni.eus";
            lstKontaktuak.Add(kontaktua1);
            
            Contacto kontaktua2 = new Contacto("13452345", "pepe", "Fernandez");
            kontaktua2.Emaila = "pfernandez@uni.eus";
            lstKontaktuak.Add(kontaktua2);
            
            Contacto kontaktua3 = new Contacto("14567874", "jon", "Perez");
            kontaktua3.Emaila = "jperez@uni.eus";
            lstKontaktuak.Add(kontaktua3);
            return View(lstKontaktuak);
        }
    }
}

