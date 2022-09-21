using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Models
{
    public class RecipeDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a dish name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter image path [dishName.{extension}] (e.g. chickenNuggets.jpg")]
        public string ImageSource { get; set; }

        [Required(ErrorMessage = "Enter dish type (chicken, pork etc.)")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Enter recipe description")]
        public string RecipeDescription { get; set; }

        [Required(ErrorMessage = "Enter directions on how to create")]
        public string Directions { get; set; }

        [Required(ErrorMessage = "Enter the ingredients of the dish")]
        public string Ingredients { get; set; }
    }
}
