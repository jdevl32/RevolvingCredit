using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace RevolvingCredit.WebAPI.Controller
{

	[Produces("application/json")]
	[Route("api/APR")]
	public class APRController : Microsoft.AspNetCore.Mvc.Controller
	{

		// GET: api/APR
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET: api/APR/5
		[HttpGet("{id}", Name = "Get")]
		public string Get(int id)
		{
			return "value";
		}
		
		// POST: api/APR
		[HttpPost]
		public void Post([FromBody]string value)
		{
		}
		
		// PUT: api/APR/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}
		
		// DELETE: api/ApiWithActions/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}

	}

}
