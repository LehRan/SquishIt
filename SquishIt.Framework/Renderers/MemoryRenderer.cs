namespace SquishIt.Framework.Renderers
{
    public class MemoryRenderer: IRenderer
    {
        private string content;

        public void Render(string content, string outputFile)
        {
            this.content = content;
        }

        public string Get()
        {
            return this.content;
        }
    }
}