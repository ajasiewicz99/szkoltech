using Wydarzenia.BusinessLogic.Api.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wydarzenia.BusinessLogic.Api.Interface
{
    public interface IWydarzeniaApi
    {
        void TestNhibernate();
        ListIdNamePairServiceResponse GetEvents();
    }
}
