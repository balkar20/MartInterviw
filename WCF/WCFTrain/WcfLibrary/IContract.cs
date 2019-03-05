namespace Server
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        void Say(string input);
    }
}