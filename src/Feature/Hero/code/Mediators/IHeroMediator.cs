using HelixComponents.Feature.Hero.ViewModels;
using HelixComponents.Foundation.Core.Models;

namespace HelixComponents.Feature.Hero.Mediators
{
    public interface IHeroMediator
    {
        MediatorResponse<HeroViewModel> CreateHeroViewModel();
    }
}
