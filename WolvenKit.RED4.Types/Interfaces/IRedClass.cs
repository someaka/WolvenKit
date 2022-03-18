
namespace WolvenKit.RED4.Types
{
    public interface IRedCloneable
    {
        public object ShallowCopy();
        public object DeepCopy();
    }
}
