
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceRagdoll : RagdollTask
	{
		public ForceRagdoll()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
