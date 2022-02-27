using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class QuestDebugLogManager : IParseableBuffer
    {
        public string[] Lines { get; set; }
    }


    public class QuestDebugLogManagerParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new QuestDebugLogManager();
            var text = br.ReadLengthPrefixedString();
            data.Lines = text.Split('\n');
            node.Data = data;
        }
    }

}
