using Reqnroll;

namespace SpecialChars;

[Binding]
public class Steps
{
	[Given("these special characters in a step argument: {string}")]
	public void GivenTheseSpecialCharactersInAStepArgument(string specialCharacters)
	{
		Console.WriteLine(specialCharacters); // all special characters replaced by � (replacement character)
	}

	[Given("these special characters € è • simply in a step")]
	public void GivenTheseSpecialCharactersESimplyInAStep()
	{
		throw new InvalidOperationException("This won't be hit, since Reqnroll doesn't recognize the binding");
	}
}
