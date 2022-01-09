using System;
using System.ServiceModel;

namespace ServiceReference1
{
    internal class ServiceCallBackClient
    {
        private InstanceContext context;

        public ServiceCallBackClient(InstanceContext context)
        {
            this.context = context;
        }

        internal void gabung(string nama)
        {
            throw new NotImplementedException();
        }

        internal void kirimPesan(string pesan)
        {
            throw new NotImplementedException();
        }
    }
}