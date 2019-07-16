using DecisionsFramework.Design.Flow;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDateFormat
{
    [AutoRegisterMethodsOnClass(true, "Integration", "DateFormat", RegisterForAgents = true)]
    public class GetDateFormat
    {
        public string CurrentCultureName()
        {
            return CultureInfo.CurrentCulture.Name;
        }


    }
}