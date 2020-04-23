using System;

namespace FreeCode.Exceptions
{
    [Serializable]
    public class BusinessRuleException<TDataType> : Exception
    {
        readonly string DataItemName;
        readonly TDataType ActualValue;
        public BusinessRuleException(string message, string dataItem, TDataType actual): base(message)
        {
        }
    }
}
