using System.Diagnostics;
using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save.IO;

public class CyberpunkSaveReader
{
    private BinaryReader _reader;

    private CyberpunkSaveFile? _csavFile;

    private static readonly Dictionary<string, Type> _nodeParsers = new();
    static CyberpunkSaveReader()
    {
        _nodeParsers.Add(Constants.NodeNames.C_ATTITUDE_MANAGER, typeof(CAttitudeManagerParser));
        _nodeParsers.Add(Constants.NodeNames.C_COVER_MANAGER, typeof(CCoverManagerParser));
        _nodeParsers.Add(Constants.NodeNames.CHARACTER_CUSTOMIZATION_APPEARANCES_NODE, typeof(CharacterCustomizationAppearancesParser));
        _nodeParsers.Add(Constants.NodeNames.CHOICES, typeof(ChoicesParser));
        _nodeParsers.Add(Constants.NodeNames.COMMUNITY_SYSTEM, typeof(CommunitySystemParser));
        _nodeParsers.Add(Constants.NodeNames.CONTAINER_MANAGER, typeof(ContainerManagerParser));
        //_nodeParsers.Add(Constants.NodeNames.CONTAINER_MANAGER_INJECTED_LOOT, typeof(ContainerManagerInjectedLootParser));
        _nodeParsers.Add(Constants.NodeNames.CONTAINER_MANAGER_LOOT_SLOT_AVAILABILITY, typeof(ContainerManagerLootSlotAvailabilityParser));
        //_nodeParsers.Add(Constants.NodeNames.CONTAINER_MANAGER_NPC_LOOT_BAGS_VER2, typeof(ContainerManagerNPCLootBagsVer2Parser));
        _nodeParsers.Add(Constants.NodeNames.CONTAINER_MANAGER_NPC_LOOT_BAGS_VER3_LOOTED_IDS, typeof(ContainerManagerNPCLootBagsVer3LootedIDsParser));
        _nodeParsers.Add(Constants.NodeNames.CUSTOM_ARRAY, typeof(CustomArrayParser));
        //_nodeParsers.Add(Constants.NodeNames.DEVICE_SYSTEM, typeof(DeviceSystemParser));
        _nodeParsers.Add(Constants.NodeNames.DIRECTOR_SYSTEM, typeof(DirectorSystemParser));
        _nodeParsers.Add(Constants.NodeNames.DS_DYNAMIC_CONNECTIONS, typeof(DSDynamicConnectionsParser));
        _nodeParsers.Add(Constants.NodeNames.DYNAMIC_ENTITYID_SYSTEM, typeof(DynamicEntityIDSystemParser));
        _nodeParsers.Add(Constants.NodeNames.EVENT_MANAGER, typeof(EventManagerParser));
        _nodeParsers.Add(Constants.NodeNames.FACTS_TABLE, typeof(FactsTableParser));
        _nodeParsers.Add(Constants.NodeNames.FACTSDB, typeof(FactsDBParser));
        //_nodeParsers.Add(Constants.NodeNames.GAME_AUDIO, typeof(GameAudioParser));
        _nodeParsers.Add(Constants.NodeNames.GAME_SESSION_CONFIG_NODE, typeof(GameSessionConfigParser));
        _nodeParsers.Add(Constants.NodeNames.GOD_MODE_SYSTEM, typeof(PackageParser));
        //_nodeParsers.Add(Constants.NodeNames.INVENTORY, typeof(InventoryParser));
        //_nodeParsers.Add(Constants.NodeNames.ITEM_DATA, typeof(ItemDataParser));
        //_nodeParsers.Add(Constants.NodeNames.ITEM_DROP_STORAGE, typeof(ItemDropStorageParser));
        //_nodeParsers.Add(Constants.NodeNames.ITEM_DROP_STORAGE_MANAGER, typeof(ItemDropStorageManagerParser));
        //_nodeParsers.Add(Constants.NodeNames.JOURNAL_MANAGER, typeof(JournalManagerParser));
        _nodeParsers.Add(Constants.NodeNames.MOVING_PLATFORM_SYSTEM, typeof(PackageParser));
        _nodeParsers.Add(Constants.NodeNames.MUSIC_SYSTEM, typeof(MusicSystemParser));
        _nodeParsers.Add(Constants.NodeNames.PERSISTENCY_SYSTEM_2, typeof(PersistencySystem2Parser));
        //_nodeParsers.Add(Constants.NodeNames.PLAYER_SYSTEM, typeof(PlayerSystemParser));
        _nodeParsers.Add(Constants.NodeNames.QUEST_DEBUG_LOG_MANAGER, typeof(QuestDebugLogManagerParser));
        //_nodeParsers.Add(Constants.NodeNames.QUEST_MUSIC_HISTORY, typeof(QuestMusicHistoryParser));
        _nodeParsers.Add(Constants.NodeNames.RADIO_SYSTEM, typeof(RadioSystemParser));
        _nodeParsers.Add(Constants.NodeNames.RENDER_GAMEPLAY_EFFECTS_MANAGER_SYSTEM, typeof(PackageParser));
        _nodeParsers.Add(Constants.NodeNames.SCANNING_CONTROLLER, typeof(PackageParser));
        _nodeParsers.Add(Constants.NodeNames.SCRIPTABLE_SYSTEMS_CONTAINER, typeof(ScriptableSystemsContainerParser));
        _nodeParsers.Add(Constants.NodeNames.STAT_POOLS_SYSTEM, typeof(PackageParser));
        _nodeParsers.Add(Constants.NodeNames.STATS_SYSTEM, typeof(PackageParser));
        _nodeParsers.Add(Constants.NodeNames.TIER_SYSTEM, typeof(PackageParser));
        _nodeParsers.Add(Constants.NodeNames.TIME_CORE, typeof(TimeSystemCoreParser));
        _nodeParsers.Add(Constants.NodeNames.UNIQUE_ITEM_COUNTER, typeof(UniqueItemCounterParser));
        _nodeParsers.Add(Constants.NodeNames.WORKSPOT_INSTANCES_SAVEDATA, typeof(WorkspotInstancesSavedataParser));
    }

    public CyberpunkSaveReader(Stream input) : this(input, Encoding.UTF8, false)
    {
    }

    public CyberpunkSaveReader(Stream input, Encoding encoding) : this(input, encoding, false)
    {
    }

    public CyberpunkSaveReader(Stream input, Encoding encoding, bool leaveOpen)
    {
        _reader = new BinaryReader(input, encoding, leaveOpen);
    }

    public CyberpunkSaveReader(BinaryReader reader)
    {
        _reader = reader;
    }

    public BinaryReader BaseReader => _reader;
    public Stream BaseStream => _reader.BaseStream;

    public EFileReadErrorCodes ReadFileInfo(out CyberpunkSaveFileInfo? info)
    {
        var id = BaseStream.ReadStruct<uint>();
        if (id != CyberpunkSaveFile.MAGIC)
        {
            info = null;
            return EFileReadErrorCodes.NoCSav;
        }

        var result = new CyberpunkSaveFileInfo
        {
            FileHeader = BaseStream.ReadStruct<CyberpunkSaveHeaderStruct>()
        };

        info = result;
        return EFileReadErrorCodes.NoError;
    }

    public EFileReadErrorCodes ReadFile(out CyberpunkSaveFile? file)
    {
        var result = ReadFileInfo(out var info);
        if (result != EFileReadErrorCodes.NoError)
        {
            file = null;
            return result;
        }

        BaseStream.Seek(-8, SeekOrigin.End);
        var infoStart = BaseReader.ReadInt32();
        if (BaseReader.ReadUInt32() != CyberpunkSaveFile.DONE)
        {
            file = null;
            return EFileReadErrorCodes.NoCSav;
        }

        BaseStream.Seek(infoStart, SeekOrigin.Begin);
        if (BaseReader.ReadUInt32() != CyberpunkSaveFile.NODE)
        {
            file = null;
            return EFileReadErrorCodes.NoCSav;
        }

        _csavFile = new CyberpunkSaveFile();
        _csavFile.FileHeader = info;

        var flatNodes = new List<RawSaveNode>();
        var length = BaseReader.ReadVLQInt32();
        for (int i = 0; i < length; i++)
        {
            flatNodes.Add(new RawSaveNode
            {
                Name = BaseReader.ReadLengthPrefixedString(),
                NextId = BaseReader.ReadInt32(),
                ChildId = BaseReader.ReadInt32(),
                Offset = BaseReader.ReadInt32(),
                Size = BaseReader.ReadInt32()
            });
        }

        BaseStream.Position = 0;
        var dataStream = Compression.Decompress(_reader, out var compressionSettings);

        _csavFile.Nodes = BuildNodeTree(dataStream, flatNodes);

        foreach (var node in _csavFile.Nodes)
        {
            ParseNode(node);
        }
        
        file = _csavFile;
        return EFileReadErrorCodes.NoError;
    }

    private void ParseNode(SaveNode node)
    {
        if (_nodeParsers.ContainsKey(node.Name))
        {
            var parser = (INodeParser)System.Activator.CreateInstance(_nodeParsers[node.Name])!;
            parser.Read(node);
        }
        else
        {
            foreach (var childNode in node.Children)
            {
                ParseNode(childNode);
            }
        }
    }

    private List<SaveNode> BuildNodeTree(Stream stream, List<RawSaveNode> flatNodes)
    {
        using var reader = new BinaryReader(stream, Encoding.ASCII);

        var nodeDict = new Dictionary<int, RawSaveNode>();
        foreach (var node in flatNodes)
        {
            reader.BaseStream.Position = node.Offset;
            node.Id = reader.ReadInt32();

            nodeDict.Add(node.Id, node);
        }

        var nodeTree = new List<RawSaveNode>();
        BuildChildTree(flatNodes[0]);
        CalculateTrueSizes(nodeTree, (int)stream.Length);


        var saveNodes = new List<SaveNode>();
        reader.BaseStream.Position = nodeTree[0].Offset;
        foreach (var node in nodeTree)
        {
            saveNodes.Add(ReadData(node));
        }

        return saveNodes;

        void BuildChildTree(RawSaveNode node, RawSaveNode? parentNode = null)
        {
            if (parentNode == null)
            {
                nodeTree.Add(node);
            }
            else
            {
                parentNode.Children.Add(node);
                node.Parent = parentNode;
            }

            if (node.ChildId != -1)
            {
                BuildChildTree(nodeDict[node.ChildId], node);
            }

            if (node.NextId != -1)
            {
                node.NextNode = nodeDict[node.NextId];
                BuildChildTree(nodeDict[node.NextId], parentNode);
            }
        }

        SaveNode ReadData(RawSaveNode node)
        {
            Debug.Assert(reader.BaseStream.Position == node.Offset);

            var ret = new SaveNode { Name = node.Name };

            reader.ReadBytes(4); // skip nodeId
            ret.DataBytes = reader.ReadBytes(node.DataSize - 4);

            foreach (var child in node.Children)
            {
                ret.Children.Add(ReadData(child));
            }
            ret.TrailingDataBytes = reader.ReadBytes(node.TrailingSize);

            return ret;
        }
    }

    private void CalculateTrueSizes(IReadOnlyList<RawSaveNode> nodes, int maxLength)
    {
        for (var i = 0; i < nodes.Count; ++i)
        {
            var currentNode = nodes[i];
            var nextNode = i + 1 < nodes.Count ? nodes[i + 1] : null;

            if (currentNode.Children.Count > 0)
            {
                // Check if there is a blob before the first child
                var nextChild = currentNode.Children.First();
                var blobSize = nextChild.Offset - currentNode.Offset;
                currentNode.DataSize = blobSize;
                CalculateTrueSizes(currentNode.Children, maxLength);
            }
            else
            {
                currentNode.DataSize = currentNode.Size;
            }

            if (nextNode != null)
            {
                // There is a node after us. Check if there is a blob in between
                var blobSize = nextNode.Offset - (currentNode.Offset + currentNode.Size);
                if (blobSize < 0)
                {
                    throw new InvalidDataException("Found a datablob with negative size");
                }
                currentNode.TrailingSize = blobSize;
            }
            else
            {
                // There might be a blob that is part of the children due to the parents size, check for that
                if (currentNode.Parent == null)
                {
                    // This is the last node on the root list. Trailing data should have been cought by the last inner child and assigned here but check again.
                    var lastNodeEnd = currentNode.Offset + currentNode.Size;
                    Debug.Assert(lastNodeEnd <= maxLength);
                    if (lastNodeEnd < maxLength)
                    {
                        // There is a trailing blob
                        currentNode.TrailingSize = maxLength - lastNodeEnd;
                    }

                    continue;
                }
                nextNode = currentNode.Parent.NextNode;
                if (nextNode == null)
                {
                    // This is the last child on the last node. The next valid offset would be the end of the data
                    // Create a virtual node for this so the code below can grab the offset
                    nextNode = new RawSaveNode();
                    nextNode.Offset = maxLength;
                }
                var parentMax = currentNode.Parent.Offset + currentNode.Parent.Size;
                var childMax = currentNode.Offset + currentNode.Size;
                // The parent size should never be smaller than the end of the last child.
                Debug.Assert(parentMax >= childMax);
                var blobSize = nextNode.Offset - (currentNode.Offset + currentNode.Size);
                if (blobSize < 0)
                {
                    throw new InvalidDataException("Found a datablob with negative size");
                }
                if (parentMax > childMax)
                {
                    // Blob belongs to this child
                    currentNode.TrailingSize = blobSize;
                }
                else if (parentMax == childMax)
                {
                    // Blob belongs to the parent but as trailing.
                    currentNode.Parent.TrailingSize = blobSize;
                }
            }
        }
    }
}
