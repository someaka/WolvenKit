using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEntityManagerSetAttachment_NodeType : questIEntityManager_NodeType
	{
		private CHandle<questIEntityManagerSetAttachment_NodeSubType> _subtype;

		[Ordinal(0)] 
		[RED("subtype")] 
		public CHandle<questIEntityManagerSetAttachment_NodeSubType> Subtype
		{
			get => GetProperty(ref _subtype);
			set => SetProperty(ref _subtype, value);
		}
	}
}
