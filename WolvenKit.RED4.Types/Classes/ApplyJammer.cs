
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyJammer : gameEffectExecutor_Scripted
	{
		public ApplyJammer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
