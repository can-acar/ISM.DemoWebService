using System;
using ISM.Demo.Models;
using ISM.Demo.Providers;

namespace ISM.Demo.Services
{
    public class DemoService : IDemoService
    {
        private readonly IDemoProvider _provider;

        public DemoService(IDemoProvider provider)
        {
            if (provider == null)
                throw new ArgumentNullException("provider");

            _provider = provider;
        }


        public DemoModel GetText(string text)
        {
            return _provider.GetText(text);
        }
    }
}
