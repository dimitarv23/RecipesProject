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
        public Task<RecipeDTO> Create(RecipeDTO obj);
        public Task<RecipeDTO> Get(int id);
        public Task<IEnumerable<RecipeDTO>> GetAll();
    }
}
