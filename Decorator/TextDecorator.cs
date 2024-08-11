using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class TextDecorator : IText
    {
        protected IText _text;
        internal TextDecorator(IText text)
        {
            _text = text;
        }
        public abstract string GetText();
    }
}
