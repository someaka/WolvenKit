using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameSessionDataModule : IScriptable
	{
		[Ordinal(0)] 
		[RED("moduleType")] 
		public CEnum<EGameSessionDataType> ModuleType
		{
			get => GetPropertyValue<CEnum<EGameSessionDataType>>();
			set => SetPropertyValue<CEnum<EGameSessionDataType>>(value);
		}
	}
}
