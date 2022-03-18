
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerSocket : RedBaseClass
	{
		public gamePlayerSocket()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
