
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workMotionAnimClip : workAnimClip
	{
		public workMotionAnimClip()
		{
			Flags = 32770;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
