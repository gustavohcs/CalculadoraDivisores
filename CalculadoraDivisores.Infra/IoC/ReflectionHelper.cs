using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CalculadoraDivisores.Infra.IoC
{
    /// <summary>
    /// Classe usada para auxiliar no uso de Reflection na criação ou acesso de propriedades das classes.
    /// </summary>
    public static class ReflectionHelper
    {
        /// <summary>
        /// Carrega os assemblys da aplicação para o funcionamento do reflection
        /// </summary>
        public static void LoadApplicationAssemblies()
        {
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().Where(w => w.FullName.StartsWith("CalculadoraDivisores")).ToList();
            var loadedPaths = loadedAssemblies.Select(a => a.Location).ToArray();

            var referencedPaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "CalculadoraDivisores*.dll");
            var toLoad = referencedPaths.Where(r => !loadedPaths.Contains(r, StringComparer.InvariantCultureIgnoreCase)).ToList();
            toLoad.ForEach(path => loadedAssemblies.Add(AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(path))));
        }
    }
}
