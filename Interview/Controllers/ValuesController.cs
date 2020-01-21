using Interview.Data.Core;
using Interview.DataReader;
using System.Collections.Generic;
using System.Web.Http;

namespace Interview.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<DataDto> Get()
        {
            IDataProvider provider = new DataProvider();
            return provider.ReadAllData();
        }

        // GET api/values/5
        public IEnumerable<DataDto> Get(int id)
        {
            IDataProvider provider = new DataProvider();
            return provider.ReadSpecificObject(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
