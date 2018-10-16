using System.Collections.Generic;
using Glass.Mapper.Sc.Fields;
using HelixComponents.Foundation.ORM.Models;

namespace HelixComponents.Feature.Hero.Models
{
    public interface IHero : IGlassBase
    {
        string HeroTitle { get; set; }
        IEnumerable<Image> HeroImages { get; set; }
    }
}
