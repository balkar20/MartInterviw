using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Behavior1
{
    public class MyMessageInspector : IDispatchMessageInspector
    {
        public object AfterReceiveRequest
        (ref Message request,
            IClientChannel channel,
            InstanceContext instanceContext)
        {
            Console.WriteLine(request.ToString());
            return request;
        }

        public void BeforeSendReply
        (ref Message reply,
            object correlationState)
        {
            Console.WriteLine(reply.ToString());
        }
    }
}