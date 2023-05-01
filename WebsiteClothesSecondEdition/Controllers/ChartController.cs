using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebsiteClothesSecondEdition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly Website2Context _context;

        public ChartController(Website2Context context)
        {
            _context = context;
        }

        [HttpGet("JsonProductsByGDepartmentsData")]
        public async Task<JsonResult> JsonMoviesByGenresDataAsync()
        {
            var genres = await _context.Genres.Include(genre => genre.Movies).ToListAsync();

            List<object> genreMovie = new List<object>();

            genreMovie.Add(new[] { "Жанр", "Кількість фільмів" });

            foreach (var genre in genres)
            {
                genreMovie.Add(new object[] { genre.Name, genre.Movies.Count() });
            }

            return new JsonResult(genreMovie);
        }


        [HttpGet("JsonMoviesByCountryData")] //JsonProductsByCountryData
        public async Task<JsonResult> JsonMoviesByCountryData()
        {
            var countries = await _context.Countries.Include(country => country.ProductName).ToListAsync();

            List<object> countriesByProducts = new List<object>();

            countriesByProducts.Add(new[] { "Countries", "Products" });

            foreach (var county in countries)
            {
                countriesByProducts.Add(new object[] { county.Name, county.Products.Count() });
            }

            return new JsonResult(countriesByProducts);
        }
    }
}
