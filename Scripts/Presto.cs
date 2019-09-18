using System;
using System.Collections.Generic;

namespace Bonwerk.Injection
{
    public static class Presto
    {
        private static Dictionary<Type, IProvider> Providers { get; } = new Dictionary<Type, IProvider>();
        
        public static void Bind<T>(IProvider provider) where T : class
        {
            var type = typeof(T);
            if (Providers.ContainsKey(type))
            {
                throw new Exception($"Type {type.Name} is already bound");
            }

            Providers[type] = provider;
        }

        public static T Provide<T>() where T : class
        {
            var type = typeof(T);
            if (!Providers.TryGetValue(type, out var provider))
            {
                throw new Exception($"Type {type.Name} has no bound provider");
            }

            return provider.Provide() as T;
        }
    }
}