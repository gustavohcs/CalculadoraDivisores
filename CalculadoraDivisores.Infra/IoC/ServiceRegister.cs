using System;
using System.Linq;

namespace CalculadoraDivisores.Infra.IoC
{
    public class ServiceRegister
    {
        public static void Register()
        {
            DependencyInjection.Container.Options.EnableAutoVerification = false;
            RegisterServices();
        }

        private static void RegisterServices()
        {
            Register("IDivisorService");
        }

        private static void Register(string interfaceName)
        {
            ReflectionHelper.LoadApplicationAssemblies();

            var services = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(x => x.Name.Equals(interfaceName)).ToList();

            services.ForEach(serviceType =>
            {
                var implementacoes = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => p.GetInterfaces().Any(a => a.Name == serviceType.Name) && !p.IsInterface)
                    .ToList();

                switch (implementacoes.Count)
                {
                    case 1:
                        DependencyInjection.Container.Register(serviceType, implementacoes.Single());
                        break;
                    default:
                        DependencyInjection.Container.Collection.Register(serviceType, implementacoes);
                        break;
                }
            });
        }

        
    }
}
