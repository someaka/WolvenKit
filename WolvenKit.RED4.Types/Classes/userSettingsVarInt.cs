
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class userSettingsVarInt : userSettingsVar
	{
		public userSettingsVarInt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
