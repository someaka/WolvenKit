namespace WolvenKit.RED4.Types;

public partial class ForceShootCommandTask : AIbehaviortaskScript
{
	[Ordinal(0)] 
	[RED("inCommand")] 
	public CHandle<AIArgumentMapping> InCommand
	{
		get => GetPropertyValue<CHandle<AIArgumentMapping>>();
		set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
	}

	[Ordinal(1)] 
	[RED("currentCommand")] 
	public CWeakHandle<AIForceShootCommand> CurrentCommand
	{
		get => GetPropertyValue<CWeakHandle<AIForceShootCommand>>();
		set => SetPropertyValue<CWeakHandle<AIForceShootCommand>>(value);
	}

	[Ordinal(2)] 
	[RED("threatPersistenceSource")] 
	public CHandle<gamedataAIThreatPersistenceSource_Record> ThreatPersistenceSource
	{
		get => GetPropertyValue<CHandle<gamedataAIThreatPersistenceSource_Record>>();
		set => SetPropertyValue<CHandle<gamedataAIThreatPersistenceSource_Record>>(value);
	}

	[Ordinal(3)] 
	[RED("activationTimeStamp")] 
	public CFloat ActivationTimeStamp
	{
		get => GetPropertyValue<CFloat>();
		set => SetPropertyValue<CFloat>(value);
	}

	[Ordinal(4)] 
	[RED("commandDuration")] 
	public CFloat CommandDuration
	{
		get => GetPropertyValue<CFloat>();
		set => SetPropertyValue<CFloat>(value);
	}

	[Ordinal(5)] 
	[RED("target")] 
	public CWeakHandle<gameObject> Target
	{
		get => GetPropertyValue<CWeakHandle<gameObject>>();
		set => SetPropertyValue<CWeakHandle<gameObject>>(value);
	}

	[Ordinal(6)] 
	[RED("targetID")] 
	public entEntityID TargetID
	{
		get => GetPropertyValue<entEntityID>();
		set => SetPropertyValue<entEntityID>(value);
	}

	public ForceShootCommandTask()
	{
		TargetID = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
