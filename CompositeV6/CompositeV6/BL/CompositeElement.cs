using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositeV6.BL
{
    public class CompositeElement : DrawingElement
    {
        private IList<DrawingElement> elements = new List<DrawingElement>();

        public CompositeElement(string name) : base(name) {}

        public override void Add(DrawingElement e)
        {
            elements.Add(e);
        }
        
        public override void Remove(DrawingElement e)
        {
            elements.Remove(e);
        }
        public override void Display(int indent)
        {
            // Display the level and name for the element
            Console.WriteLine($"{new string('-', indent)}+ {name}");

            // Display each child element on this node
            elements.ToList().ForEach(el => el.Display(indent + 2));
        }
    }
}
