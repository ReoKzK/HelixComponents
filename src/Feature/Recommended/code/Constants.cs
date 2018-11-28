namespace HelixComponents.Feature.Recommended
{
    public struct Constants
    {
        public class MediatorCodes
        {
            public struct RecommendedPagesResponse
            {
                public const string DataSourceError = "FeaturedContentMediator.CreateRecommendedPagesViewModel.DataSourceError";
                public const string RenderingParamError = "FeaturedContentMediator.CreateRecommendedPagesViewModel.RenderingParamError";

                public const string Ok = "FeaturedContentMediator.CreateRecommendedPagesViewModel.Ok";
            }
        }

        public class Logging
        {
            public struct Error
            {
                public const string DataSourceError = "The datasource was empty";
                public const string RenderingParametersError = "The rendering parameters was empty";
            }
        }
    }
}