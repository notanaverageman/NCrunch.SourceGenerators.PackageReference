using Microsoft.CodeAnalysis;
using Newtonsoft.Json;

namespace CodeGeneration
{
	[Generator]
	public class Generator : ISourceGenerator
	{
		public void Initialize(GeneratorInitializationContext context)
		{
		}

		public void Execute(GeneratorExecutionContext context)
		{
			string json = "{'Name': 'test'}";
			JsonConvert.DeserializeObject(json);

			context.AddSource("Test", "class Test {}");
		}
	}

	public class Person
	{
		public string Name { get; set; }
	}
}