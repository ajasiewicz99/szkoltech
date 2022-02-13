using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wydarzenia.BusinessLogic.NHibernate;

namespace Wydarzenia.BusinessLogic.Api
{
    public class BaseApi
    {
        public BaseApi()
        {
            NHibernateBase nHibernate = new NHibernateBase();
            nHibernate.Initialize();
        }
    }
}
