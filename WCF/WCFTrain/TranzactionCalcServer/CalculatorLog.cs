using System;
using System.ServiceModel;
using System.Transactions;

namespace TranzactionCalcServer
{
    [ServiceBehavior(TransactionIsolationLevel = System.Transactions.IsolationLevel.Serializable)]
    public class CalculatorService : ICalculatorLog
    {
        [OperationBehavior(TransactionScopeRequired = true,
            TransactionAutoComplete = false)]
        public double Add(double n1, double n2)
        {
            RecordToLog($"Added {n1} to {n2}");
            return n1 + n2;
        }

        [OperationBehavior(TransactionScopeRequired = true,
            TransactionAutoComplete = false)]
        public double Subtract(double n1, double n2)
        {
            RecordToLog($"Subtracted {n1} from {n2}");
            return n1 - n2;
        }

        [OperationBehavior(TransactionScopeRequired = true,
            TransactionAutoComplete = false)]
        public double Multiply(double n1, double n2)
        {
            RecordToLog($"Multiplied {n1} by {n2}");
            return n1 * n2;
        }

        [OperationBehavior(TransactionScopeRequired = true,
            TransactionAutoComplete = false)]
        public double Divide(double n1, double n2)
        {
            RecordToLog($"Divided {n1} by {n2}");
            return n1 / n2;
        }

        private void RecordToLog(string s)
        {
            var transaction = Transaction.Current.TransactionInformation;
            var id = transaction.LocalIdentifier;
            Console.WriteLine($"Transaxtion id: {id}, message:{s}");
        }
    }
}