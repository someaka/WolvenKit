
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EMP : gameEffectExecutor_Scripted
	{
		public EMP()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
