using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using FluentAssertions;
using HelixComponents.Feature.Hero.Controllers;
using HelixComponents.Feature.Hero.Mediators;
using HelixComponents.Feature.Hero.ViewModels;
using HelixComponents.Foundation.Core.Exceptions;
using HelixComponents.Foundation.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Ploeh.AutoFixture;
using ErrorMessages = HelixComponents.Foundation.Core.Exceptions.Constants;

namespace HelixComponents.Feature.Hero.Tests.Controllers
{
    [TestClass]
    [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
    public class HeroControllerTests
    {
        private HeroController _controller;
        private IHeroMediator _heroMediator;

        [TestInitialize]
        public void Setup()
        {
            _heroMediator = Substitute.For<IHeroMediator>();

            _controller = new HeroController(_heroMediator);
        }

        [TestMethod]
        public void Hero_Action_GivenDataSourceError_ReturnsErrorView()
        {
            var fixture = new Fixture();
            var createViewModelResponse = fixture.Build<MediatorResponse<HeroViewModel>>()
                .With(x => x.Code, MediatorCodes.HeroResponse.DataSourceError)
                .Create();

            _heroMediator.CreateHeroViewModel().Returns(createViewModelResponse);

            var result = _controller.Hero() as ViewResult;

            result.ViewName.Should().Be("~/views/Hero/Error.cshtml");
        }

        [TestMethod]
        public void Hero_Action_Throws_InvalidMediatorResponseCodeException()
        {
            var fixture = new Fixture();
            var createViewModelResponse = fixture.Build<MediatorResponse<HeroViewModel>>()
                .With(x => x.Code, "Unknown code")
                .Create();

            _heroMediator.CreateHeroViewModel().Returns(createViewModelResponse);

            Action act = () => _controller.Hero();
            act.ShouldThrow<InvalidMediatorResponseCodeException>().Where(e =>
                e.Message.Equals(
                    $"{ErrorMessages.InvalidMediatorResponse.InvalidCodeReturned}: {createViewModelResponse.Code}"));
        }
    }
}
