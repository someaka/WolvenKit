
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnAICommandFactory : IScriptable
	{
		public scnAICommandFactory()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
