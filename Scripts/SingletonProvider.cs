namespace Bonwerk.Injection
{
    public class SingletonProvider : IProvider
    {
        public SingletonProvider(object singleton)
        {
            Singleton = singleton;
        }
        
        private object Singleton { get; }
        
        public object Provide()
        {
            return Singleton;
        }
    }
}