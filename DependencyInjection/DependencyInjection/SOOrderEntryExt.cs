using DependencyInjection.Interfaces;
using PX.Data;
using PX.Objects.SO;
using System.Collections;

namespace DependencyInjection
{
    public class SOOrderEntryExt : PXGraphExtension<SOOrderEntry>
    {
        //Acumatica is using InjectDependencyAttribute for marking the properties of the PXGraph, PXGraphExtension,
        //PXAction and PXEventSubscriberAttribute to be injected by Autofac
        [InjectDependency]
        public IRestServiceProvider ServiceProvider { get; set; }

        public PXAction<SOOrder> doRestRequest;
        [PXButton(CommitChanges = true)]
        [PXUIField(DisplayName ="Do Request")]
        protected IEnumerable DoRestRequest(PXAdapter adapter)
        {
            if(ServiceProvider!=null)
            {
                throw new PXException("Dependency Injection Worked");
            }
            else
            {
                throw new PXException("Something Went wrong");
            }
        }
    }
}
