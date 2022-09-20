using Recipes_DataAccess;
using Recipes_DataAccess.Data;
using Recipes_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Business.Repository
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly ApplicationDbContext _db;

        public RecipeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public RecipeDTO Create(RecipeDTO obj)
        {
            Recipe recipe = new Recipe()
            {
                ID = obj.ID,
                Name = obj.Name,
                ImageSource = obj.ImageSource,
                MeatType = obj.MeatType,
                RecipeDescription = obj.RecipeDescription,
                CreatedOn = DateTime.Now
            };

            _db.Recipes.Add(recipe);
            _db.SaveChanges();
            return 
        }

        public RecipeDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RecipeDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
