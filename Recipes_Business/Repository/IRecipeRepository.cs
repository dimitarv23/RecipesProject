using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Recipes_Models;

namespace Recipes_Business.Repository
{
    public interface IRecipeRepository
    {
        public RecipeDTO Create(RecipeDTO obj);
        public RecipeDTO Get(int id);
        public IEnumerable<RecipeDTO> GetAll();
    }
}
