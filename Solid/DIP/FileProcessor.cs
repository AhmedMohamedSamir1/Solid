using Solid.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP
{
    public class FileProcessor : IFileProcessor
    {
        private readonly IFileReader _fileReader;
        private readonly IFileWriter _fileWriter;

        public FileProcessor(IFileReader fileReader, IFileWriter fileWriter)
        {
            _fileReader = fileReader;
            _fileWriter = fileWriter;
        }

        public void ProcessFile(string inputFilePath, string outputFilePath)
        {
            string fileContent = _fileReader.ReadFile(inputFilePath);
            // Process the file content
            _fileWriter.WriteFile(outputFilePath, fileContent);
        }
    }
}
