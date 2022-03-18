
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class attrAttribute : ISerializable
	{
		public attrAttribute()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
