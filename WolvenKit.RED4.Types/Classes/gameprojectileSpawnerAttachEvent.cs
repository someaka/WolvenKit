namespace WolvenKit.RED4.Types;

public partial class gameprojectileSpawnerAttachEvent : redEvent
{
	[Ordinal(0)] 
	[RED("owner")] 
	public CWeakHandle<gameObject> Owner
	{
		get => GetPropertyValue<CWeakHandle<gameObject>>();
		set => SetPropertyValue<CWeakHandle<gameObject>>(value);
	}

	public gameprojectileSpawnerAttachEvent()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
