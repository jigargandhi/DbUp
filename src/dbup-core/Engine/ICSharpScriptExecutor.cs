using DbUp.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbUp.Engine
{
    public interface ICSharpScriptExecutor
    {
#if NET46


        void Execute(CSharpScript script, Microsoft.CodeAnalysis.Scripting.ScriptOptions options, UpgradeConfiguration config);
#endif
    }
}
