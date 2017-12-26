using System.Collections.Generic;
using Beginor.AppFx.Core;
using NHibernate;
using Beginor.AppFx.Repository.Hibernate;
using Beginor.OwinApp.Data.Entity;

namespace Beginor.OwinApp.Data.Repository {

    public class SampleRepository
        : HibernateRepository<SampleEntity, int>, ISampleRepository {

        public SampleRepository(ISessionFactory factory) : base(factory) { }

    }

}
