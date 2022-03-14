namespace Logger.Layouts
{
    public abstract class Layout : ILayout
    {
        protected Layout(string format)
        {
            this.Format = format;
        }

        public string Format { get; }
    }
}
