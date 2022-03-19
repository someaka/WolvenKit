using System;
using System.Reflection;
using System.Diagnostics;

namespace WolvenKit.RED4.Types;

public static class CHandle
{
    public static IRedBaseHandle Parse(Type handleType, RedBaseClass value)
    {
        var method = typeof(CHandle).GetMethod(nameof(Parse), BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(RedBaseClass) }, null);
        if (method == null)
        {
            throw new MissingMethodException("Method CHandle.Parse<T>() could not be found");
        }
        var generic = method.MakeGenericMethod(handleType);

        var result = generic.Invoke(null, new object[] { value });
        if (result == null)
        {
            throw new Exception();
        }

        return (IRedBaseHandle)result;
    }

    public static CHandle<T> Parse<T>(RedBaseClass value) where T : RedBaseClass => new((T)value);
}

[RED("handle")]
public class CHandle<T> : IRedHandle<T>, IEquatable<CHandle<T>>, IRedCloneable where T : RedBaseClass
{
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public T? Chunk { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public Type InnerType => typeof(T);


    public RedBaseClass? GetValue() => Chunk;
    public void SetValue(RedBaseClass? cls) => Chunk = (T?)cls;


    public CHandle(){}

    public CHandle(T chunk)
    {
        Chunk = chunk;
    }


    public static implicit operator CHandle<T>(T value) => new(value);
    public static implicit operator T?(CHandle<T> value) => value.Chunk;


    public bool Equals(CHandle<T>? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        if (!Equals(Chunk, other.Chunk))
        {
            return false;
        }

        return true;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((CHandle<T>)obj);
    }

    public override int GetHashCode() => Chunk != null ? Chunk.GetHashCode() : 0;

    public object ShallowCopy()
    {
        return MemberwiseClone();
    }

    public object DeepCopy()
    {
        if (Chunk != null)
        {
            return new CHandle<T>((T)Chunk.DeepCopy());
        }

        return new CHandle<T>();
    }
}
