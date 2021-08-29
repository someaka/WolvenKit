using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CraftBook : IScriptable
	{
		private CArray<ItemRecipe> _knownRecipes;
		private CArray<TweakDBID> _newRecipes;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("knownRecipes")] 
		public CArray<ItemRecipe> KnownRecipes
		{
			get => GetProperty(ref _knownRecipes);
			set => SetProperty(ref _knownRecipes, value);
		}

		[Ordinal(1)] 
		[RED("newRecipes")] 
		public CArray<TweakDBID> NewRecipes
		{
			get => GetProperty(ref _newRecipes);
			set => SetProperty(ref _newRecipes, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
