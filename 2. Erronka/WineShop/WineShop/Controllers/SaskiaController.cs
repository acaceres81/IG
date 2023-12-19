using Microsoft.AspNetCore.Mvc;
using Wineshop.ViewModels;
using WineShop.Models;
using WineShop.Services;
using WineShop.ViewModels;

namespace WineShop.Controllers
{
    public class SaskiaController : Controller
    {
        private readonly ISaskiaService _saskiaService;
        private readonly IArdoaService _ardoaService;
        public SaskiaController(ISaskiaService saskiaService, IArdoaService ardoaService)
        {
            _saskiaService = saskiaService;
            _ardoaService = ardoaService;
        }
        public async Task<IActionResult> Index(string id)
        {
            IList<SaskiaAlea> saskiaAleaList = new List<SaskiaAlea>();
            saskiaAleaList = await _saskiaService.SaskiaLortuAleak(id);
            //Ardo bakoitzaren datuak hartu eta ViewModel bezala sortu
            IList<SaskiaAleaViewModelbi> saskiaAleaVMList = new List<SaskiaAleaViewModelbi>();
            foreach (var saskiaAlea in saskiaAleaList)
            {
                var ardoa = await _ardoaService.GetArdoa(saskiaAlea.ArdoaId);
                SaskiaAleaViewModelbi saskiaAleaViewModel = new SaskiaAleaViewModelbi()
                {
                    ArdoaId = ardoa.Id,
                    Irudia = ardoa.Irudia,
                    Izena = ardoa.Izena,
                    Kantitatea = saskiaAlea.Kantitatea,
                    Salneurria = ardoa.Salneurria
                };
                saskiaAleaVMList.Add(saskiaAleaViewModel);
            }
            var saskiaViewModel = new SaskiaViewModel();
            saskiaViewModel.SaskiaAleaVMList = saskiaAleaVMList;
            return View(saskiaViewModel);
        }
    }
}
