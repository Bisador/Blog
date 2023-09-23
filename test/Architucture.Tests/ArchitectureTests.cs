using NetArchTest.Rules;
using System.Reflection; 
using Xunit;
using FluentAssertions;

namespace Architecture.Tests
{
    public class ArchitectureTests
    {
        private const string DomainNameSpace = "Domain";
        private const string ApplicationNameSpace = "Application";
        private const string InfrastructureNameSpace = "Infrastructure";
        private const string PresentationNameSpace = "Presentation";
        private const string WebNameSpace = "Web";

        [Fact]
        public void Domain_Should_Not_HaveDependenciesOnOtherProjects()
        {
            //var result = Types
            //    .InCurrentDomain()
            //    .That()
            //    .ResideInNamespace("Application.Interfaces")
            //    .ShouldNot()
            //    .HaveDependencyOn("NetArchTest.SampleLibrary.Data")
            //    .GetResult().IsSuccessful;

            //Arrange
            var assembly = Assembly.GetAssembly(typeof(Domain.Common.BaseEntity));
            var otherProjects = new[] {
                ApplicationNameSpace,
                InfrastructureNameSpace,
                PresentationNameSpace,
                WebNameSpace,
            };
            //Act
            var testResult = Types
                .InAssembly(assembly)
                .ShouldNot()
                .HaveDependencyOnAny(otherProjects)
                .GetResult();
            //Assert
            testResult
                .IsSuccessful.Should().Be(true);
        }
    }
}