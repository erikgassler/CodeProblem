namespace Workspace;

public class SolutionTests : TestFramework
{
	[Fact]
	public void UnitTest_Template()
	{
		IActions<Solution> actions = ArrangeUnitTest<Solution>(options => {});
		
		actions.Act(a =>
		{
		});
		
		actions.Assert(a =>
		{
		});
	}
}
