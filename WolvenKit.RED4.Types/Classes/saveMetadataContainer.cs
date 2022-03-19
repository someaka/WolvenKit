namespace WolvenKit.RED4.Types;

public partial class saveMetadataContainer : ISerializable
{
	[Ordinal(0)] 
	[RED("metadata")] 
	public saveMetadata Metadata
	{
		get => GetPropertyValue<saveMetadata>();
		set => SetPropertyValue<saveMetadata>(value);
	}

	public saveMetadataContainer()
	{
		Metadata = new() { SaveVersion = 220, GameVersion = 1500 };

		PostConstruct();
	}

	partial void PostConstruct();
}
