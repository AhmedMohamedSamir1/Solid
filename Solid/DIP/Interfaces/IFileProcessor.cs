using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Interfaces
{
    public interface IFileProcessor
    {
        public void ProcessFile(string inputFilePath, string outputFilePath);
    }
}
