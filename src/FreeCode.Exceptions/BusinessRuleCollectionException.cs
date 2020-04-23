using System;
using System.Collections.Generic;

namespace FreeCode.Exceptions
{
    [Serializable]
    public class BusinessRuleCollectionException : Exception
    {
        public ICollection<Exception> Rules { get; private set; } = new HashSet<Exception>();
        public BusinessRuleCollectionException(string message) : base(message) { }
        public BusinessRuleCollectionException(string message, ICollection<Exception> rules) : base(message) 
        {

        }
    }
}
