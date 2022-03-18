
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entGameEntity : entEntity
	{
		public entGameEntity()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
