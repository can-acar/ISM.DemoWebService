using ISM.Demo.Models;

namespace ISM.Demo.Providers
{
    public interface IDemoProvider
    {

        DemoModel GetText(string text);

    }
}
