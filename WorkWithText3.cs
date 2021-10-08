using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{

    class WorkWithText3
    {
        public string NameFile { get; set; }
        public string RootFolder { get; set; }
        public WorkWithText3(string filePath)
        {
            NameFile = SearchFileName(filePath);
            RootFolder = SearchRootFolder(filePath);
        }
        private string SearchFileName(string filePath)
        {
            int index1= filePath.LastIndexOf(@"\");
            int index2= filePath.LastIndexOf(".");
            string nameFile = filePath.Substring(index1+1, index2 - index1-1);
            return nameFile;
        }
        private string SearchRootFolder(string filePath)
        {
            string temp = filePath;
            int index1 = temp.IndexOf(@"\");
            temp = temp.Remove(0, index1 + 1);
            int index2 = temp.IndexOf(@"\");
            string rootFolder = filePath.Substring(index1 + 1, index2);
            return rootFolder;
        }

        public override string ToString()
        {
            
                return $"Root folder - {RootFolder} | File name - {NameFile} ";
           
        }
    }
}
