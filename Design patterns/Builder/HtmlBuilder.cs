﻿namespace Design_patterns.Builder
{
    public class HtmlBuilder
    {
        HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            root.Name = rootName;
        }

        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement() {Name = root.Name};
        }
    }
}