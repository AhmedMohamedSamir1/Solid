using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Interfaces
{
    public interface IFileWriter
    {
        public void WriteFile(string filePath, string content);
    }
}
