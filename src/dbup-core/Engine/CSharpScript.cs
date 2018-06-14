using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DbUp.Engine
{
    [System.Diagnostics.DebuggerDisplay("{Name}")]
    public class CSharpScript 
    {
        private readonly string name;
        private readonly string contents;

        public CSharpScript(string name, string contents)
        {
            this.name = name;
            this.contents = contents;
        }

        public virtual string Name
        {
            get { return name; }
        }

        public virtual string Contents
        {
            get { return contents; }
        }

        public static CSharpScript FromStream(string fileName, Stream stream, Encoding encoding)
        {
            using (StreamReader reader = new StreamReader(stream, encoding))
                return new CSharpScript(fileName, reader.ReadToEnd());
        }

    }
}
