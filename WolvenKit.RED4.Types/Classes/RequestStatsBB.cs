
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestStatsBB : gamePlayerScriptableSystemRequest
	{
		public RequestStatsBB()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
