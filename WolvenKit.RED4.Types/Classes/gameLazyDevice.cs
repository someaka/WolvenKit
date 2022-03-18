
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLazyDevice : IScriptable
	{
		public gameLazyDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
