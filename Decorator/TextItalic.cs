using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class TextItalic : TextDecorator
    {
        public TextItalic(IText text) : base(text)
        {
        }

        public override string GetText()
        {
            return "<i>" + _text.GetText() + "</i>";
        }
    }
}
