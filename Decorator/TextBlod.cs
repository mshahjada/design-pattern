using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class TextBlod : TextDecorator
    {
        public TextBlod(IText text) : base(text)
        {
        }

        public override string GetText()
        {
            return "<b>" + _text.GetText() + "</b>";
        }
    }
}
