using System.Runtime.Serialization;

namespace ServerWin
{
    [DataContract]
    public class GreetFault
    {
        private string report;

        public GreetFault(string message)
        {
            this.report = $"I GreeterFaultModel with message: {message}";
        }

        [DataMemberAttribute]
        public string Message
        {
            get { return this.report; }
            set { this.report = value; }
        }
    }
}