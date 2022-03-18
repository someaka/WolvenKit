
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitReceivedCallback : HitCallback
	{
		public HitReceivedCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
