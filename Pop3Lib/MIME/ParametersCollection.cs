using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pop3Lib.MIME
{
    [Serializable]
    public class ParametersCollection : Dictionary<string, string>
    {

        // StringComparer.CurrentCultureIgnoreCase - указывает не то, что в коллекции регистр символов учитываться не будет
        public ParametersCollection() : base(StringComparer.CurrentCultureIgnoreCase) { }

    }
}