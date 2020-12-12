using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParser
{
    public static class Factory
    {
       
            public static IFileGenerator GetFileInstance(string extension)
            {
                switch (extension)
                {
                    case "xml":
                        return new XMLGenerator();
                    case "txt":
                        return new TxtGenerator();
                    case "json":
                       return new JSONGenerator();
                
                    default:
                        return null;
                }
            }
        
    }
}
