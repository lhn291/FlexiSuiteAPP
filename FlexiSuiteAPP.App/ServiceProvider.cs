namespace FlexiSuiteAPP.App
{
    public sealed class ServiceProvider
    {
        private static readonly Lazy<ServiceProvider> _instance = new Lazy<ServiceProvider>(() => new ServiceProvider());
        public static ServiceProvider Instance => _instance.Value;

        private readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

        private ServiceProvider() { }

        public void RegisterService(Type serviceType, Type implementationType)
        {
            _services[serviceType] = Activator.CreateInstance(implementationType)!;
        }

        public TService GetService<TService>()
        {
            if (_services.TryGetValue(typeof(TService), out var service))
            {
                return (TService)service;
            }
            throw new KeyNotFoundException($"Service of type {typeof(TService)} is not registered.");
        }
    }
}
