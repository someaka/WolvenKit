using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SubCharacterSystem : gameScriptableSystem
	{
		private CArray<SSubCharacter> _uniqueSubCharacters;
		private CBool _scriptSpawnedFlathead;
		private CBool _isDespawningFlathead;

		[Ordinal(0)] 
		[RED("uniqueSubCharacters")] 
		public CArray<SSubCharacter> UniqueSubCharacters
		{
			get => GetProperty(ref _uniqueSubCharacters);
			set => SetProperty(ref _uniqueSubCharacters, value);
		}

		[Ordinal(1)] 
		[RED("scriptSpawnedFlathead")] 
		public CBool ScriptSpawnedFlathead
		{
			get => GetProperty(ref _scriptSpawnedFlathead);
			set => SetProperty(ref _scriptSpawnedFlathead, value);
		}

		[Ordinal(2)] 
		[RED("isDespawningFlathead")] 
		public CBool IsDespawningFlathead
		{
			get => GetProperty(ref _isDespawningFlathead);
			set => SetProperty(ref _isDespawningFlathead, value);
		}
	}
}
