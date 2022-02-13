using Wydarzenia.BusinessLogic.Api.Communication;
using Wydarzenia.BusinessLogic.Api.Interface;
using Wydarzenia.BusinessLogic.ModelDTO;
using Wydarzenia.BusinessLogic.NHibernate;
using BiuroPracy.Domain;
using System;
using System.Linq;

namespace Wydarzenia.BusinessLogic.Api
{
    public class WydarzeniaApi : BaseApi, IWydarzeniaApi
    {
        public ListIdNamePairServiceResponse GetEvents()
        {
            try
            {
                using (var session = NHibernateBase.Session)
                {
                    var eventDB = session.QueryOver<Event>().List();
                    var events = eventDB.ToList().Select(x =>
                       new IdNamePair
                       {
                           Id = x.Id,
                           Name = x.Name
                       }).ToList();

                    return new ListIdNamePairServiceResponse()
                    {
                        Data = events
                    };
                }
            }
            catch (Exception e)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = e.StackTrace + " " + e.Message,
                    Success = false
                };
            }
        }

        public void TestNhibernate()
        {
            try
            {
                using (var session = NHibernateBase.Session)
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var eventdata = session.Get<Event>(1);
                    }
                }
            }
            catch (Exception e)
            {
            }
        }

    }
}
