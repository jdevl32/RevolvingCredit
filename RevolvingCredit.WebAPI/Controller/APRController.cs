using AutoMapper;
using JDevl32.Mapper.Interface;
using Microsoft.AspNetCore.Mvc;
using RevolvingCredit.WebAPI.Repository.Interface;

namespace RevolvingCredit.WebAPI.Controller
{

	[Produces("application/json")]
	[Route("api/APR")]
	public class APRController
		:
		Microsoft.AspNetCore.Mvc.Controller
		,
		IInstanceMapper
	{

#region Property

#region IInstanceMapper

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public IMapper Mapper { get; }

#endregion

		/// <summary>
		/// The APR repository.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public IAPRRepository APRRepository { get; }

#endregion

#region Instance Initialization

		/// <summary>
		/// Create an APR controller.
		/// </summary>
		/// <param name="aprRepository">
		/// An APR repository.
		/// </param>
		/// <param name="mapper">
		/// A mapper.
		/// </param>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRController(IAPRRepository aprRepository, IMapper mapper)
		{
			APRRepository = aprRepository;
			Mapper = mapper;
		}

#endregion

		[HttpGet]
		public IActionResult Get()
		{
			// todo|jdevl32: map to view-model...
			return Ok(APRRepository.GetAPR());
		}

		/**
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
		**/

	}

}
