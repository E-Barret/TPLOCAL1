using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPLOCAL1.Models;

//L'énoncé du tp et le logo hn sont livrés dans le répertoire /ressources de la solution
//--------------------------------------------------------------------------------------
//Attention, le modèle MVC est un modèle dit de convention plutot que configuration, 
//Le controller doit donc obligatoirement se nommer avec "Controller" à la fin!!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        // méthode appelée par la routeur "naturellement"
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //renvoie vers la vue Index (voir routage dans RouteConfig.cs)
                return View();
            else
            {
                //en fonction du paramètre id, on appelle les différentes pages
                switch (id)
                {
                    case "ListeAvis":
                        //Lien vers le fichier XML contenant les avis
                        string path = AppDomain.CurrentDomain.BaseDirectory + "FichierXML/DataAvis.xml";
                        //Création d'une nouvelle liste qui sera envoyer à la vue et qui contiendra les avis.
                        var listeAvis = new ListeAvis();
                        //Ouverture de la vue "ListeAvisé avec un paramètre : la liste contenant les avis
                        return View(id, listeAvis.GetAvis(path));
                    case "Formulaire":
                        return View(id);
                    default:
                        //renvoie vers Index (voir routage dans RouteConfig.cs)
                        return View();
                }
            }
        }


        //méthode pour envoyer les données du formulaire vers la page de validation
        [HttpPost]
        public ActionResult ValidationFormulaire(FormulaireModel form)
        {
            if (ModelState.IsValid) //Si aucune faute dans le formulaire
            {
                return View(form); //Affichage de la vue ValidationFormulaire

            }
            return View("Formulaire"); //Sinon, la vue Formulaire reste affichée avec la liste des erreurs à résoudre.                
        }
    }
}