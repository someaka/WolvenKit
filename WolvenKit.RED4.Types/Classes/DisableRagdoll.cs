
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisableRagdoll : RagdollTask
	{
		public DisableRagdoll()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
