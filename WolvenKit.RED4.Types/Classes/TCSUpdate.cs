
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TCSUpdate : gameScriptableSystemRequest
	{
		public TCSUpdate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
