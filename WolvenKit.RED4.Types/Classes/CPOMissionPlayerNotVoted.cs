
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CPOMissionPlayerNotVoted : CPOMissionPlayerVoted
	{
		public CPOMissionPlayerNotVoted()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
