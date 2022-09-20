using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_DataAccess
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageSource { get; set; }
        public string MeatType { get; set; }
        public string ReceptionDescription { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
