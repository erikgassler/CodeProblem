namespace Workspace;

public class Demo
{
	public bool ExamplePublicMethod()
	{
		return !ExamplePrivateMethod();
	}

	private bool ExamplePrivateMethod()
	{
		return true;
	}
}
