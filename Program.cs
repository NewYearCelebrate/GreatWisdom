using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Json.Net;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using GreatWisdom.DataBase;

namespace GreatWisdom
{
    class BaseClass
    {
        int number = 4;
    }
    class SomeClass
    {
        string un;
        string wow = "hah";
        private string rootFolderPath = @"C:\REPO\TvardLab\File_system\Peer's_files";
        private string editorBatchFilePath = @"C:\REPO\TvardLab\File_system\Environment";

        public SomeClass(string un)
        {
            this.un = un;
            someDifficultLogic();
        }

        public SomeClass()
        {
            this.un = "lol";
            someDifficultLogic();
        }

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

    class Program
    {
        


        static void Main(string[] args)
        {
            SomeClass objectToSerialize = new SomeClass();

            JsonParser parser = new JsonParser();

            //энивевй какую бы строку ты не написал - можно мксимум изменить форму JSON ДОКУМЕНТА. Добавить доп поля. Можно сделать изменение поля по умолчанию
            // what is default typeNamehandling?
            string jsonString = JsonConvert.SerializeObject(objectToSerialize, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });

            Console.WriteLine(jsonString);


            //BaseClass sClass = new BaseClass();
            //string jsonString = JsonNet.Serialize(sClass);

            //BaseClass newBuildedClass = JsonNet.Deserialize<BaseClass>("{\"number\":123,\"wow\":\"haha\"}");
            
            //Console.WriteLine(jsonString);
        }
    }
}

