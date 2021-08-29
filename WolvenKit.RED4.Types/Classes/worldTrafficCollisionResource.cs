using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficCollisionResource : CResource
	{
		private CHandle<worldTrafficStaticCollisionData> _data;

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<worldTrafficStaticCollisionData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
