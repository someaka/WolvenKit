
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterStructBuffer : CMaterialParameter
	{
		public CMaterialParameterStructBuffer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
