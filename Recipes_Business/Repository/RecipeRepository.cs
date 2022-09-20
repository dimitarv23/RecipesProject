using AutoMapper;
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
        private readonly IMapper _mapper;

        public RecipeRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public RecipeDTO Create(RecipeDTO obj)
        {
            var recipe = _mapper.Map<RecipeDTO, Recipe>(obj);
            recipe.CreatedOn = DateTime.Now;

            _db.Recipes.Add(recipe);
            _db.SaveChanges();

            return _mapper.Map<Recipe, RecipeDTO>(recipe);
        }

        public RecipeDTO Get(int id)
        {
            var obj = _db.Recipes.FirstOrDefault(u => u.ID == id);

            if (obj != null)
            {
                return _mapper.Map<Recipe, RecipeDTO>(obj);
            }

            return new RecipeDTO();
        }

        public IEnumerable<RecipeDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<Recipe>, IEnumerable<RecipeDTO>>(_db.Recipes);
        }
    }
}
