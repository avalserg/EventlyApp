using FluentAssertions;
using TestResult = NetArchTest.Rules.TestResult;

namespace Evently.Modules.Ticketing.ArchitectureTests.Abstractions;

internal static class TestResultExtensions
{
    internal static void ShouldBeSuccessful(this TestResult testResult)
    {
        testResult.FailingTypes?.Should().BeEmpty();
    }
}
