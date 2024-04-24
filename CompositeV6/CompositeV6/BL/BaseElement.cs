namespace CompositeV6.BL
{
    public abstract class BaseElement
    {
        protected string name = "";

        public BaseElement(string name)
        {
            this.name = name;
        }

        public abstract void Add(BaseElement e);

        public abstract void Remove(BaseElement e);

        public abstract void Display(int indent);
    }
}