using System.Xml.Linq;

namespace CompositeV6.BL
{
    public class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement e)
        {
            Console.WriteLine("Cannot add an element into a Primitive Element");
        }

        public override void Remove(DrawingElement e)
        {
            Console.WriteLine("Cannot remove an element from a Primitive Element");
        }

        public override void Display(int indent)
        {
            Console.WriteLine($"{new string('-', indent)}+ {name}");
        }
    }
}