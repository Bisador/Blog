using FluentAssertions;
using NetArchTest.Rules;
using System.Reflection;

namespace CMS.Architecture.Tests;

public class ArchitectureTests
{
    private const string DomainNameSpace = nameof(Domain);
    private const string ApplicationNameSpace = nameof(Application);
    private const string InfrastructureNameSpace = nameof(Infrastructure);
    private const string PresentationNameSpace = nameof(Presentation);
    private const string WebNameSpace = nameof(Web);


    [Test]
    public void Domain_Should_Not_HaveDependenciesOnOtherProjects()
    {
        //Arrange
        var assembly = Assembly.GetAssembly(typeof(Domain.CMS.Article.Entities.Article));
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

    [Test]
    public void Handlers_Should_HaveDependencyOnDomain()
    {
        //Arrange
        var assembly = Assembly.GetAssembly(typeof(Application.Interfaces.IApplicationDbContext));

        //Act
        var testResult = Types
            .InAssembly(assembly)
            .That()
            .HaveNameEndingWith("Handler")
            .Should()
            .HaveDependencyOn(DomainNameSpace)
            .GetResult();

        //Assert
        testResult
            .IsSuccessful.Should().Be(true);
    }

    [Test]
    public void Application_Should_Not_HaveDependenciesOnOtherProjects()
    {
        //Arrange
        var assembly = Assembly.GetAssembly(typeof(Application.Interfaces.IApplicationDbContext));
        var otherProjects = new[] {
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

    [Test]
    public void Infrastructure_Should_Not_HaveDependenciesOnOtherProjects()
    {
        //Arrange
        var assembly = Assembly.GetAssembly(typeof(Infrastructure.Context.ApplicationDbContext));
        var otherProjects = new[] {
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

    [Test]
    public void Presentation_Should_Not_HaveDependenciesOnOtherProjects()
    {
        //Arrange
        var assembly = Assembly.GetAssembly(typeof(Presentation.Controllers.WeatherForecastController));
        var otherProjects = new[] {
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

    [Test]
    public void Application_Should_HaveDependencyOnDomain()
    {
        //Arrange
        var assembly = Assembly.GetAssembly(typeof(Application.Interfaces.IApplicationDbContext));
        //Act
        var testResult = Types
            .InAssembly(assembly)
            .Should()
            .HaveDependencyOn(DomainNameSpace)
            .GetResult();
        //Assert
        testResult
            .IsSuccessful.Should().Be(true);
    }

    [Test]
    public void Controllers_Should_HaveDependencyOnMediatR()
    {
        //Arrange
        var assembly = Assembly.GetAssembly(typeof(Presentation.Controllers.WeatherForecastController));
        //Act
        var testResult = Types
            .InAssembly(assembly)
            .That()
            .HaveNameEndingWith("Controller")
            .Should()
            .HaveDependencyOn("MediatR")
            .GetResult();
        //Assert
        testResult
            .IsSuccessful.Should().Be(true);
    }
}