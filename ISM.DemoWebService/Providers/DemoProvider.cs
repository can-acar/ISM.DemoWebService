using ISM.Demo.Models;

namespace ISM.Demo.Providers
{
    public class DemoProvider : IDemoProvider
    {
        public DemoModel GetText(string text)
        {
            return new DemoModel
            {
                Test = string.Format("Demo Service Response: {0}", text)
            };
        }
    }
}