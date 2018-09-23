using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDemo.Core.Exceptions
{
    [Serializable]
    public class MissingInformationImportException : ApplicationException
    {
        public string MissingParameterName { get; set; }

        public MissingInformationImportException(string parameterName) : base()
        {
            MissingParameterName = parameterName;
        }

        public MissingInformationImportException(string message, string parameterName) : base(message)
        {
            MissingParameterName = parameterName;
        }

        public MissingInformationImportException(string message, Exception innerException, string parameterName) : base(message, innerException)
        {
            MissingParameterName = parameterName;
        }

        protected MissingInformationImportException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }
}
