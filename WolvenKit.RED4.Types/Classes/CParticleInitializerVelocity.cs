using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleInitializerVelocity : IParticleInitializer
	{
		private CHandle<IEvaluatorVector> _velocity;
		private CFloat _scale;
		private CBool _worldSpace;

		[Ordinal(4)] 
		[RED("velocity")] 
		public CHandle<IEvaluatorVector> Velocity
		{
			get => GetProperty(ref _velocity);
			set => SetProperty(ref _velocity, value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(6)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetProperty(ref _worldSpace);
			set => SetProperty(ref _worldSpace, value);
		}
	}
}
