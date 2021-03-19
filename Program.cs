using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Json.Net;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;

namespace IdealWorld
{
    class Program
    {
        class SomeClass
        {
            string wow = "hah";
            private string rootFolderPath = @"C:\REPO\TvardLab\File_system\Peer's_files";
            private string editorBatchFilePath = @"C:\REPO\TvardLab\File_system\Environment";

            public void someDifficultLogic()
            {
                Process writeFileProcess = new Process();
                string editingFile = rootFolderPath + @"\" + @"Vasya" + @"\" + @"file1.txt";

                writeFileProcess.StartInfo.WorkingDirectory = editorBatchFilePath;
                writeFileProcess.StartInfo.FileName = editorBatchFilePath + @"\writeBatchFile.cmd";

                writeFileProcess.StartInfo.Arguments = editingFile;
                writeFileProcess.StartInfo.CreateNoWindow = true;
                writeFileProcess.Start();
                writeFileProcess.WaitForExit();
            }
        }


        static void Main(string[] args)
        {
            SomeClass sClass = new SomeClass();
            string jsonString = JsonNet.Serialize(sClass);
            Console.WriteLine(jsonString);
        }
    }
}

