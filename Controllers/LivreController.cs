using GestionLivres.Data;
using GestionLivres.Models;
using Microsoft.AspNetCore.Mvc;


namespace GestionLivres.Controllers
{
    public class LivreController : Controller
    {
        private static List<Livre> livres = LivreRepo.GetLivre();
        private static int Id = 2;

        public IActionResult Index()
        {
            ViewBag.Livreslist = livres;
            
            return View();
        }

        [HttpGet]//an3ayet 3liha b httpGet
        public ActionResult Ajouter()//pour afficher la page ajouter
        { 
            return View();
        }

        [HttpPost]//an3ayet 3liha b httpPost
        public IActionResult Ajouter(Livre livre)//ajoute le livre dans la liste
        {
            livres.Add(livre);
            return RedirectToAction("Index");//if I did * return View("Index") * it'll display index before adding livre to the liste
            
        }

        [HttpGet]//an3ayet 3liha b httpGet
        public ActionResult Modifier(int id)
        {
            Livre livre = livres.Find(lv=>lv.ISBN == id);
            return View(livre);
        }

        [HttpPost]//an3ayet 3liha b httpPost
        public IActionResult Modifier(Livre livre)
        {
            Livre l = livres.Find(lv => lv.ISBN == livre.ISBN);
            l.Auteur= livre.Auteur;
            return RedirectToAction("Index");
        }

        public ActionResult Supprimer(int id)
        {
            Livre livre = livres.Find(lv => lv.ISBN == id);
            return View(livre);
        }

        [HttpPost]//an3ayet 3liha b httpPost
        public IActionResult Supprimer(Livre livre)
        {
            Livre l = livres.Find(lv => lv.ISBN == livre.ISBN);
            l.Auteur = livre.Auteur;
            return RedirectToAction("Index");
        }

    }
}
