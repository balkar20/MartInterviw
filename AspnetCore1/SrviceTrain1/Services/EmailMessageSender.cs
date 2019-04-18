namespace SrviceTrain1.Services
{
    public class EmailMessageSender:IMessageSender
    {
        public string Send()
        {
            return "Sent by Email";
        }
    }
}