using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    internal class CompositeGraphic : IGraphic
    {
        List<IGraphic> _graphicList = new List<IGraphic>();


        public void Add(IGraphic graphic) { _graphicList.Add(graphic); }

        public void Remove(IGraphic graphic) { _graphicList.Remove(graphic); }

        public void Clear() { _graphicList.Clear(); }

        public void Draw()
        {
            foreach (var item in _graphicList)
            {
                item.Draw();
            }
        }
    }
}
