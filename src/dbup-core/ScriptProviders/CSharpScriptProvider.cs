using DbUp.Engine;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;
namespace DbUp.ScriptProviders
{
    public class CSharpScriptProvider
    {
        private readonly Assembly[] assemblies;

        public CSharpScriptProvider(Assembly[] assemblies)
        {
            this.assemblies = assemblies ?? throw new ArgumentNullException(nameof(assemblies));
        }

        public List<CSharpScript> GetScripts()
        {
            var scripts = assemblies.
                Select(assembly =>
                  new
                  {
                      Assembly = assembly,
                      ResourceNames = assembly.GetManifestResourceNames().Where(f => f.EndsWith(".csx")).ToArray()
                  }
                )
                .SelectMany(x => x.ResourceNames
                                .Select(resourceName =>
                                            CSharpScript.FromStream(resourceName, x.Assembly.GetManifestResourceStream(resourceName), DbUpDefaults.DefaultEncoding))
                                            )
                 .OrderBy(script => script.Name)
                 .ToList();

            return scripts;


        }
    }
}
