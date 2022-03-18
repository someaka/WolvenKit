
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisassembleOwnedJunkEffector : gameEffector
	{
		public DisassembleOwnedJunkEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
