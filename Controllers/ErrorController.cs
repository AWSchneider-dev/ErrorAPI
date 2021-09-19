using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ErrorAPI.Controllers
{
    public class ErrorController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {

            // This returns all errors in a date sorted list. Default is 36 hours.
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {

            // Returns the specific error
            return "value";
        }

        // POST api/error
        public void Post([FromBody]string formName, [FromBody]Uri formUri, [FromBody]string formElements)
        {
          // accepts a form name, uri and a json object
        }

        // PUT api/error/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/error/5
        //public void Delete(int id)
        //{
        //}
    }
}
