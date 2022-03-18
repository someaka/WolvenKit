
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterPoliceCaller : gameScriptableSystemRequest
	{
		public UnregisterPoliceCaller()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
