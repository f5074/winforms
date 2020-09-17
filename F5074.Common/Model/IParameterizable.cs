using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Model
{
    public interface IParameterizable
    {
        string ParameterName { get; set; }
        object ParameterValue { get; set; }
    }
}
