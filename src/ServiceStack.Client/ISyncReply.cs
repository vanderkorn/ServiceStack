#if !(SL5 || __IOS__ || XBOX || ANDROID)
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ServiceStack
{
    [ServiceContract(Namespace = "http://services.servicestack.net/")]
    public interface ISyncReply
    {
        [OperationContract(Action = "*", ReplyAction = "*")]
        Message Send(Message requestMsg);
    }
}
#endif