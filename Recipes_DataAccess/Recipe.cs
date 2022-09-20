using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_DataAccess
{
    public class Recipe
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageSource { get; set; }
        public string MeatType { get; set; }
        public string RecipeDescription { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
