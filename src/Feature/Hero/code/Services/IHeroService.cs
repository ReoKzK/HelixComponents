using HelixComponents.Feature.Hero.Models;
using HelixComponents.Foundation.Search.Models;

namespace HelixComponents.Feature.Hero.Services
{
    public interface IHeroService
    {
        IHero GetHeroItems();
        BaseSearchResultItem GetHeroImagesSearch();
        bool IsExperienceEditor { get; }
    }
}
