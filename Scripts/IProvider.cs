using System;

namespace Bonwerk.Injection
{
    public interface IProvider
    {
        object Provide();
    }
}