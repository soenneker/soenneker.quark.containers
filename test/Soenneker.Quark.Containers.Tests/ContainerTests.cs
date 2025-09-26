using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Containers.Tests;

[Collection("Collection")]
public sealed class ContainerTests : FixturedUnitTest
{
    public ContainerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Container is now a Razor component, so integration tests would be more appropriate
        // This test serves as a placeholder for future component testing
    }
}
