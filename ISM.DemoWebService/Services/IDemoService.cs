using System.ServiceModel;
using ISM.Demo.Models;

namespace ISM.Demo.Services
{
    [ServiceContract]
    public interface IDemoService
    {

        [OperationContract]
        DemoModel GetText(string text);
    }
}