using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class WorkWithText1
    {
        public string Text { get; set; }
        public WorkWithText1(string text)
        {
            Text=ReplaceGridWitnComparison(text);
        }
        public override string ToString()
        {
            return Text;
        }

        private int CountOfGrid(string text){
            string temp = text;
            int s;
            int countGrid = 0;
            while (temp != "")
            {

                if ((s = (temp.IndexOf('#'))) != -1) countGrid++;
                temp = temp.Remove(0, s + 1);
            }
            return countGrid;
        }
        private string ReplaceGridWitnComparison(string text)
        {
            int countGrid = CountOfGrid(text);
            text = text.Replace("#", "<"); ;
            for (int i = 0; i < countGrid / 2; i++)
            {
                char[] temp = text.ToCharArray();
                temp[text.LastIndexOf("<")] = '>';
                text = new string(temp);
            }
            return text;
        }

    }
}
