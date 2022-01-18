using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Author
    {
        private string text;

        public string Text { private get => (text != null ? text : "автор отсутствует..."); set => text = value; }

        public void Show()
        {
            Console.WriteLine(Text);
        }
    }
}
