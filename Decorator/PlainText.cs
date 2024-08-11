using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class PlainText : IText
    {
        private string _text;

        internal PlainText(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }
    }
}
