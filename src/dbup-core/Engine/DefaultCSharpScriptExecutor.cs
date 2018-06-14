#if NET46
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Script = Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using DbUp.Builder;

namespace DbUp.Engine
{
    public class DefaultCSharpScriptExecutor : ICSharpScriptExecutor
    {
        private IDbConnection Connection;

        public void SetDBConnection(IDbConnection connection)
        {
            this.Connection = connection;
        }

        public void Execute(CSharpScript script, ScriptOptions options,UpgradeConfiguration config)
        {
            ExecutionContext context = new ExecutionContext();
            context.Connection = Connection;

            //ScriptOptions options = ScriptOptions.Default.AddImports("System.Data");                
            config.Log.WriteInformation("Executing C# script " + script.Name);
            Script.CSharpScript.EvaluateAsync(script.Contents, options, context);
            
        }
    }


    public class ExecutionContext
    {
        public IDbConnection Connection { get; set; }
    }
}
#endif