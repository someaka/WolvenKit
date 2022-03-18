
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redCallbackObject : IScriptable
	{
		public redCallbackObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
