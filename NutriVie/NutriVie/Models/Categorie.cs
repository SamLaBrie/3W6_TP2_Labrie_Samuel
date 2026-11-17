using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace NutriVie.Models
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }

        public string Nom { get; set; }
        [ValidateNever]
        public virtual IEnumerable<Recette> Recettes { get; set; }

    }
}
