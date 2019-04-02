using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Convert
    {

        private Dictionary<char, string> letters = new Dictionary<char, string>
        {
            ['ա'] = "a", ['բ'] = "b", ['գ'] = "g", ['դ'] = "d", ['ե'] = "e", ['զ'] = "z", ['է'] = "e", ['ը'] = "y",
            ['թ'] = "t", ['ժ'] = "j", ['ի'] = "i", ['լ'] = "l", ['խ'] = "x", ['ծ'] = "c", ['կ'] = "k", ['հ'] = "h",
            ['ձ'] = "dz",['ղ'] = "x", ['ճ'] = "ch",['մ'] = "m", ['յ'] = "y", ['ն'] = "n", ['շ'] = "sh",['ո'] = "o",
            ['չ'] = "ch",['պ'] = "p", ['ջ'] = "j", ['ռ'] = "r", ['ս'] = "s", ['վ'] = "v", ['տ'] = "t", ['ր'] = "r",
            ['ց'] = "c", ['ւ'] = "u", ['փ'] = "p", ['ք'] = "q", ['և'] = "ev",['օ'] = "o", ['ֆ'] = "f"
        };
        string newText = "";
        bool find = false;
        private string armenianText = "";

        public Convert(string text)
        {
            armenianText = text;
            Converting();
            Console.WriteLine(newText);
        }

        private void Converting()
        {
            char[] arm = armenianText.ToCharArray();
            for (int i = 0; i < arm.Length; i++)
            {
                find = false;
                foreach (var item in letters)
                {
                    if(arm[i] == item.Key)
                    {
                        newText += item.Value;
                        find = true;
                        break;
                    }
                }
                if (!find)
                {
                    newText += arm[i];
                }
            }
        }
    }
}
