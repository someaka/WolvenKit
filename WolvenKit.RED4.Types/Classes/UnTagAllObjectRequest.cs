
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnTagAllObjectRequest : gameScriptableSystemRequest
	{
		public UnTagAllObjectRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
