using Wydarzenia.BusinessLogic.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wydarzenia.BusinessLogic.Api.Communication
{
    public class ListIdNamePairServiceResponse : ServiceResponse
    {
        public List<IdNamePair> Data { get; set; } 
    }
}
