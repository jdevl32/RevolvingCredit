using AutoMapper;
using JDevl32.Logging.Interface;
using JDevl32.Mapper.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RevolvingCredit.WebAPI.Repository.Interface;
using RevolvingCredit.WebAPI.ViewModel.Interface;
using System;
using System.Collections.Generic;

namespace RevolvingCredit.WebAPI.Controller
{

	/// <summary>
	/// The APR controller.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Implement loggable interface.
	/// </remarks>
	[Produces("application/json")]
	[Route("api/APR")]
	public class APRController
		:
		Microsoft.AspNetCore.Mvc.Controller
		,
		ILoggable<APRController>
		,
		IInstanceMapper
	{

#region Property

#region ILoggable<APRController>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public ILogger<APRController> Logger { get; }

#endregion

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
		/// <param name="logger">
		/// A logger.
		/// </param>
		/// <param name="mapper">
		/// A mapper.
		/// </param>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRController(IAPRRepository aprRepository, ILogger<APRController> logger, IMapper mapper)
		{
			APRRepository = aprRepository;
			Logger = logger;
			Mapper = mapper;
		}

#endregion

		/// <summary>
		/// GET: api/APR
		/// </summary>
		/// <returns>
		/// 
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// Implement view model.
		/// Add error handling.
		/// </remarks>
		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				return Ok(Mapper.Map<IEnumerable<IAPRViewModel>>(APRRepository.GetAPR()));
			} // try
			catch (Exception ex)
			{
				Logger.LogError(ex, $"Error retrieving APR (type)s from the repository:  {ex}");
			} // catch

			return BadRequest();
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
