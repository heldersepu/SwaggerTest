﻿using System.Collections.Generic;
using System.Web.Http;

namespace Swagger_Test.Controllers
{
    [RoutePrefix("api/Company")]
    public class CompanyController : ApiController
    {
        /// <remarks>
        /// ## TESTING MARKDOWN TABLES
        /// ### start table
        ///
        /// | Tables        | Are           | Cool  |
        /// | ------------- |:-------------:| -----:|
        /// | col 3 is      | right-aligned | $1600 |
        /// | col 2 is      | centered      |   $12 |
        /// | zebra stripes | are neat      |    $1 |
        ///
        /// ### end table
        /// </remarks>
        public Company Get()
        {
            return new Company {
                Id = 1,
                Name = "Co",
                Description = "Test Co"
            };
        }

        /// <summary>
        /// GET Echo test of company
        /// </summary>
        /// <param name="c">company to echo</param>
        /// <returns>Returns given company</returns>
        [Route("Get2")]
        public Company Get2([FromUri] Company c)
        {
            return c;
        }

        /// <summary>
        /// POST Echo test of company
        /// </summary>
        /// <param name="companies">companies to echo</param>
        /// <returns>Returns given companies</returns>
        public IHttpActionResult Post([FromBody] IEnumerable<Company> companies)
        {
            return Ok(companies);
        }

        public IHttpActionResult Put([FromBody] List<Company> companies)
        {
            return Ok(companies);
        }
    }
}
