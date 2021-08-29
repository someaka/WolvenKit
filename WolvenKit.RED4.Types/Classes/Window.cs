using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Window : Door
	{
		private CHandle<entIComponent> _soloCollider;
		private CHandle<entMeshComponent> _strongSoloHandle;
		private CBool _duplicateDestruction;

		[Ordinal(140)] 
		[RED("soloCollider")] 
		public CHandle<entIComponent> SoloCollider
		{
			get => GetProperty(ref _soloCollider);
			set => SetProperty(ref _soloCollider, value);
		}

		[Ordinal(141)] 
		[RED("strongSoloHandle")] 
		public CHandle<entMeshComponent> StrongSoloHandle
		{
			get => GetProperty(ref _strongSoloHandle);
			set => SetProperty(ref _strongSoloHandle, value);
		}

		[Ordinal(142)] 
		[RED("duplicateDestruction")] 
		public CBool DuplicateDestruction
		{
			get => GetProperty(ref _duplicateDestruction);
			set => SetProperty(ref _duplicateDestruction, value);
		}
	}
}
