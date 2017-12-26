using System.Collections.Generic;
using Beginor.AppFx.Core;
using Beginor.OwinApp.Data.Entity;

namespace Beginor.OwinApp.Data.Repository {

    public interface ISampleRepository : IRepository<SampleEntity, int> { }

}
