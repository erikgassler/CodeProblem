namespace Workspace;

public class DemoTests : TestFramework
{
	[Fact]
	public void Verify_ExamplePublicMethod_Returns_False()
	{
		IActions<Demo> actions = ArrangeUnitTest<Demo>(options => {});
		
		actions.Act(a =>
		{
			return a.Service.ExamplePublicMethod();
		});
		
		actions.Assert(a =>
		{
			bool result = a.GetResult<bool>();
			result.Should().BeFalse();
		});
	}
	
	[Fact]
	public void Verify_ExamplePrivateMethod_Returns_True()
	{
		IActions<Demo> actions = ArrangeUnitTest<Demo>(options => {});
		
		actions.Act(a =>
		{
			return a.Service.RunPrivateMethod<Demo, bool>("ExamplePrivateMethod");
		});
		
		actions.Assert(a =>
		{
			bool result = a.GetResult<bool>();
			result.Should().BeTrue();
		});
	}
}
