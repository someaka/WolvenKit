using System;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

public class RedTypeManager
{
    public static RedBaseClass Create(Type type)
    {
        var result = System.Activator.CreateInstance(type);
        if (result is not RedBaseClass rbc)
        {
            throw new Exception($"Type \"{type.Name}\" needs to be derived from \"RedBaseClass\"");
        }

        return rbc;
    }

    public static RedBaseClass Create(string redTypeName)
    {
        var (type, _) = RedReflection.GetCSTypeFromRedType(redTypeName);
        if (type == null)
        {
            throw new TypeNotFoundException(redTypeName);
        }

        return Create(type);
    }

    public static IRedType CreateRedType(Type type, params object[] args)
    {
        var result = System.Activator.CreateInstance(type, args);
        if (result is not IRedType redType)
        {
            throw new Exception($"Type \"{type.Name}\" needs to implement from \"IRedType\"");
        }

        return redType;
    }

    public static IRedType CreateRedType(string redTypeName)
    {
        var (type, _) = RedReflection.GetCSTypeFromRedType(redTypeName);
        if (type == null)
        {
            throw new TypeNotFoundException(redTypeName);
        }

        return CreateRedType(type);
    }
}
