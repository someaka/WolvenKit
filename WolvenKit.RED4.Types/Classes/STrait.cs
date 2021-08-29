using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class STrait : RedBaseClass
	{
		private CEnum<gamedataTraitType> _type;
		private CBool _unlocked;
		private CInt32 _currLevel;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataTraitType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("unlocked")] 
		public CBool Unlocked
		{
			get => GetProperty(ref _unlocked);
			set => SetProperty(ref _unlocked, value);
		}

		[Ordinal(2)] 
		[RED("currLevel")] 
		public CInt32 CurrLevel
		{
			get => GetProperty(ref _currLevel);
			set => SetProperty(ref _currLevel, value);
		}
	}
}
