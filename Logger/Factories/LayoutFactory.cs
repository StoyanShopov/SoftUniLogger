namespace Logger.Factories
{
    using System;

    using Layouts;

    public static class LayoutFactory
    {
        public static ILayout CreateLayout(string type)
            => type switch
            {
                "SimpleLayout" => new SimpleLayout(),
                "XmlLayout" => new XmlLayout(),
                _ => throw new InvalidOperationException("Missing type"),
            };
    }
}
