namespace WolvenKit.RED4.Types;

public partial class RegisterInputListenerRequest : gameScriptableSystemRequest
{
	[Ordinal(0)] 
	[RED("object")] 
	public CWeakHandle<gameObject> Object
	{
		get => GetPropertyValue<CWeakHandle<gameObject>>();
		set => SetPropertyValue<CWeakHandle<gameObject>>(value);
	}

	public RegisterInputListenerRequest()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
