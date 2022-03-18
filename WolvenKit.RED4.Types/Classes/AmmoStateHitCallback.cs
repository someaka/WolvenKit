
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AmmoStateHitCallback : HitCallback
	{
		public AmmoStateHitCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
