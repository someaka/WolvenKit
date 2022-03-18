using System;

namespace WolvenKit.RED4.Types.Exceptions;

public class PropertyNotFoundException : Exception
{
    public PropertyNotFoundException() {}
    public PropertyNotFoundException(string message) : base(message) {}
}

public class RedNameMissingException : Exception
{
    public RedNameMissingException() { }
    public RedNameMissingException(string message) : base(message) { }
}
