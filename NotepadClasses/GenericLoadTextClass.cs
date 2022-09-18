using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadClasses
{
    public class GenericLoadTextClass : System.IO.TextReader
    {
        readonly string s;
        public string S { get; set; }

        public GenericLoadTextClass()
        {
            s = "";
        }

        public string GenericLoadTextOther(TextReader readFile)
        {
            if (readFile == TextReader.Null)
            {
                throw new FileNotFoundException();
            }
            string s = readFile.ReadToEnd().ToString();

            try
            {
                readFile.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Failed to dispose.");
            }
            return s;
        }
    }
}
