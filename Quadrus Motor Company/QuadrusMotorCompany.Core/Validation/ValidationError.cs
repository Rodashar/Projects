using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Core.Validation
{
    public class ValidationError
    {
        private readonly String _attributeName;
        private readonly String _error;

        public ValidationError(String attributeName, String error)
        {
            this._attributeName = attributeName;
            this._error = error;
        }

        public string AttributeName
        {
            get { return _attributeName; }
        }

        public string Error
        {
            get { return _error; }
        }
    }
}
