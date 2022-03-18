
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AndroidTurnOffEffector : gameEffector
	{
		public AndroidTurnOffEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
