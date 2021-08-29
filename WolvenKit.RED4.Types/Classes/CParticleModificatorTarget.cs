using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleModificatorTarget : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _position;
		private CHandle<IEvaluatorFloat> _forceScale;
		private CHandle<IEvaluatorFloat> _killRadius;
		private CFloat _maxForce;

		[Ordinal(4)] 
		[RED("position")] 
		public CHandle<IEvaluatorVector> Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(5)] 
		[RED("forceScale")] 
		public CHandle<IEvaluatorFloat> ForceScale
		{
			get => GetProperty(ref _forceScale);
			set => SetProperty(ref _forceScale, value);
		}

		[Ordinal(6)] 
		[RED("killRadius")] 
		public CHandle<IEvaluatorFloat> KillRadius
		{
			get => GetProperty(ref _killRadius);
			set => SetProperty(ref _killRadius, value);
		}

		[Ordinal(7)] 
		[RED("maxForce")] 
		public CFloat MaxForce
		{
			get => GetProperty(ref _maxForce);
			set => SetProperty(ref _maxForce, value);
		}
	}
}
