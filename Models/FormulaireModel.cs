using System;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class FormulaireModel
    {
        //Nom
        [Required(ErrorMessage = "Nom manquant")]
        [RegularExpression(@"[a-zA-Z\-\s]{3,80}", ErrorMessage = "Nom non correct")]
        public string Nom { get; set; }

        //Prénom
        [Display(Name = "Prénom")]
        [Required(ErrorMessage = "Prénom manquant")]
        [RegularExpression(@"[a-zA-Z\-\s]{3,80}", ErrorMessage = "Prénom non correct")]
        public string Prenom { get; set; }

        //Genre
        [Required(ErrorMessage = "Genre manquant")]
        public string Sexe { get; set; }

        //Adresse
        [Required(ErrorMessage = "Adresse manquante")]
        [RegularExpression(@"[\w\-\s]{5,100}", ErrorMessage = "Adresse non correcte")]
        public string Adresse { get; set; }

        //Code Postale
        [Display(Name = "Code Postal")]
        [Required(ErrorMessage = "Code Postal manquant"), RegularExpression(@"^[0-9]{5}$", ErrorMessage = "5 chiffres attendus")]
        public int CodePostal { get; set; }

        //Ville
        [Required(ErrorMessage = "Ville manquante"), RegularExpression(@"[a-zA-Z\-\s]{1,80}", ErrorMessage = "Ville non correcte")]
        public string Ville { get; set; }

        //Adresse mail
        [Display(Name = "Adresse mail")]
        [Required(ErrorMessage = "Adresse mail manquante")]
        [RegularExpression(@"^([\w\-\.]+)@([\w]+)\.([\w]+)$", ErrorMessage = "Adresse mail non valide")]
        public string AdresseMail { get; set; }

        //Date de début de formation
        [Display (Name = "Date début formation")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date de début de formation manquante")]
        [Range(typeof(DateTime), "1989/01/16", "2021/01/01", ErrorMessage = "Date entre 1989 et 2021")]
        public DateTime DateDebutFormation { get; set; }

        //Type de formation
        [Display (Name = "Formation suivie")]
        [Required(ErrorMessage = "Faire un choix")]
        public string TypeFormation { get; set; }

        //Avis Formation Cobol
        [Display (Name = "Formation Cobol")]
        [StringLength(100, ErrorMessage = "Taille d'avis maximum (100) dépassé")]
        public string AvisCobol { get; set; }

        //Avis Formation Objet
        [Display (Name = "Formation C#")]
        [StringLength(100, ErrorMessage = "Taille d'avis maximum (100) dépassé")]
        public string AvisObjet { get; set; }
    }
}