namespace WolvenKit.RED4.Types;

public partial class scneventsSpawnEntityEventParams : RedBaseClass
{
	[Ordinal(0)] 
	[RED("performer")] 
	public scnPerformerId Performer
	{
		get => GetPropertyValue<scnPerformerId>();
		set => SetPropertyValue<scnPerformerId>(value);
	}

	[Ordinal(1)] 
	[RED("referencePerformer")] 
	public scnPerformerId ReferencePerformer
	{
		get => GetPropertyValue<scnPerformerId>();
		set => SetPropertyValue<scnPerformerId>(value);
	}

	[Ordinal(2)] 
	[RED("referencePerformerSlotId")] 
	public TweakDBID ReferencePerformerSlotId
	{
		get => GetPropertyValue<TweakDBID>();
		set => SetPropertyValue<TweakDBID>(value);
	}

	[Ordinal(3)] 
	[RED("referencePerformerItemId")] 
	public TweakDBID ReferencePerformerItemId
	{
		get => GetPropertyValue<TweakDBID>();
		set => SetPropertyValue<TweakDBID>(value);
	}

	public scneventsSpawnEntityEventParams()
	{
		Performer = new() { Id = 4294967040 };
		ReferencePerformer = new() { Id = 4294967040 };

		PostConstruct();
	}

	partial void PostConstruct();
}
