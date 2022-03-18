
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisposeBody : ActionDisposal
	{
		public DisposeBody()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
