
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownAndDisposeBody : ActionDisposal
	{
		public TakedownAndDisposeBody()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
