using System.Xml.Linq;

namespace CompositeV6.BL
{
    public class PrimitiveElement : BaseElement
    {
        public PrimitiveElement(string name) : base(name)
        {
        }

        public override void Add(BaseElement e)
        {
            Console.WriteLine("Cannot add an element into a Primitive Element");
        }

        public override void Remove(BaseElement e)
        {
            Console.WriteLine("Cannot remove an element from a Primitive Element");
        }

        public override void Display(int indent)
        {
            Console.WriteLine($"{new string('-', indent)}+ {name}");
        }
    }
}