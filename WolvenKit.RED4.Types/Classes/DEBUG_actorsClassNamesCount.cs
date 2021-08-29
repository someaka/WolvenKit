using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DEBUG_actorsClassNamesCount : IScriptable
	{
		private CName _className;
		private CInt32 _count;

		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		[Ordinal(1)] 
		[RED("count")] 
		public CInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}
	}
}
