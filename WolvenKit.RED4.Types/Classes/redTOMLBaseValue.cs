
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redTOMLBaseValue : ISerializable
	{
		public redTOMLBaseValue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
