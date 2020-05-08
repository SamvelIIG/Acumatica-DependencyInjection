using DependencyInjection.Interfaces;
using System;

namespace DependencyInjection.Engines
{
    public class RestServiceProvider : IRestServiceProvider
    {
        public RestServiceProvider(IRestServiceConfiguration serviceConfiguration)
        {
            serviceConfiguration.Configure(this);
        }

        public string URL { get; set; }

        public bool CreateRecord(object rec)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRecord(object rec)
        {
            throw new NotImplementedException();
        }

        public object[] GetRecords()
        {
            throw new NotImplementedException();
        }

        public bool UpdateRecord(object rec)
        {
            throw new NotImplementedException();
        }
    }
}
