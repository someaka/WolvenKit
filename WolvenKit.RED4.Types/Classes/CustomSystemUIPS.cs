
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomSystemUIPS : VirtualSystemPS
	{
		public CustomSystemUIPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
