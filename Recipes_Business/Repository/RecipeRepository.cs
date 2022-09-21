using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public async Task<RecipeDTO> Create(RecipeDTO obj)
        {
            var recipe = _mapper.Map<RecipeDTO, Recipe>(obj);
            recipe.CreatedOn = DateTime.Now;

            _db.Recipes.Add(recipe);
            await _db.SaveChangesAsync();

            return _mapper.Map<Recipe, RecipeDTO>(recipe);
        }

        public async Task<RecipeDTO> Get(int id)
        {
            var obj = await _db.Recipes.FirstOrDefaultAsync(u => u.ID == id);

            if (obj != null)
            {
                return _mapper.Map<Recipe, RecipeDTO>(obj);
            }

            return new RecipeDTO();
        }

        public async Task<IEnumerable<RecipeDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Recipe>, IEnumerable<RecipeDTO>>(_db.Recipes);
        }
    }
}
