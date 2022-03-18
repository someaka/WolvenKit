
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class populationModifier : ISerializable
	{
		public populationModifier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
