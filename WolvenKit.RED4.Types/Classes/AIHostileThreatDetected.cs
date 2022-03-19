namespace WolvenKit.RED4.Types;

public partial class AIHostileThreatDetected : AIAIEvent
{
	[Ordinal(2)] 
	[RED("owner")] 
	public CWeakHandle<entEntity> Owner
	{
		get => GetPropertyValue<CWeakHandle<entEntity>>();
		set => SetPropertyValue<CWeakHandle<entEntity>>(value);
	}

	[Ordinal(3)] 
	[RED("threat")] 
	public CWeakHandle<entEntity> Threat
	{
		get => GetPropertyValue<CWeakHandle<entEntity>>();
		set => SetPropertyValue<CWeakHandle<entEntity>>(value);
	}

	[Ordinal(4)] 
	[RED("status")] 
	public CBool Status
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public AIHostileThreatDetected()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
