using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsColliderCapsule : physicsICollider
	{
		private CFloat _radius;
		private CFloat _height;

		[Ordinal(8)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(9)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}
	}
}
