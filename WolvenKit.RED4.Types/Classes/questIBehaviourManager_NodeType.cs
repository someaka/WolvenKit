using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIBehaviourManager_NodeType : questIRetNodeType
	{
		private gameEntityReference _puppetRef;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}
	}
}
