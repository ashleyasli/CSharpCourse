using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    internal class RecordNotFoundException : Exception
    {
        public RecordNotFoundException()
        {
        }

        public RecordNotFoundException(string message) : base(message)
        {
        }        
    }
}