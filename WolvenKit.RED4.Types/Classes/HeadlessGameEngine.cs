
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HeadlessGameEngine : BaseGameEngine
	{
		public HeadlessGameEngine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
