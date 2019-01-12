using Library.Models.Catalog;
using LibraryData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace Library.Pages
{
    public class CatalogModel : PageModel
    {
        public void OnGet()
        {

        }

        private ILibraryAsset _assets;
        public CatalogModel(ILibraryAsset assets)
        {
            _assets = assets;
        }

        public IActionResult Index()
        {
            var assetModels = _assets.GetAll();

            var listingResult = assetModels
                .Select(result => new AssetIndexListingModel
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    AuthorOrDirector = _assets.GetAuthorOrDirector(result.Id),
                    DeweyCallNumber = _assets.GetDeweyIndex(result.Id),
                    Title = result.Title,
                    Type = _assets.GetType(result.Id)
                });

            var model = new AssetIndexModel()
            {
                Assets = listingResult
            };
            //Find Razor equivilent of  returning to view
        }
    }
}