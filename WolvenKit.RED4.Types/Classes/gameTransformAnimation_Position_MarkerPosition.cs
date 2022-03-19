namespace WolvenKit.RED4.Types;

public partial class gameTransformAnimation_Position_MarkerPosition : gameTransformAnimation_Position
{
	[Ordinal(0)] 
	[RED("markerNode")] 
	public NodeRef MarkerNode
	{
		get => GetPropertyValue<NodeRef>();
		set => SetPropertyValue<NodeRef>(value);
	}

	[Ordinal(1)] 
	[RED("offset")] 
	public Vector3 Offset
	{
		get => GetPropertyValue<Vector3>();
		set => SetPropertyValue<Vector3>(value);
	}

	public gameTransformAnimation_Position_MarkerPosition()
	{
		Offset = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
