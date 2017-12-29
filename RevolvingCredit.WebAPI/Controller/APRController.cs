using AutoMapper;
using JDevl32.Web.Controller;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity.Interface;
using RevolvingCredit.WebAPI.Repository;
using RevolvingCredit.WebAPI.Repository.Interface;
using RevolvingCredit.WebAPI.ViewModel;
using RevolvingCredit.WebAPI.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RevolvingCredit.WebAPI.Controller
{

	/// <summary>
	/// The APR controller.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Implement controller base class.
	/// Implement post (update) APR.
	/// </remarks>
	[Produces("application/json")]
	[Route("api/APR")]
	public class APRController
		:
		ControllerBase<APRController>
	{

#region Property

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
		/// The (injected) APR repository.
		/// </param>
		/// <param name="hostingEnvironment">
		/// The (injected) hosting environment.
		/// </param>
		/// <param name="logger">
		/// The (injected) logger.
		/// </param>
		/// <param name="mapper">
		/// The (injected) mapper.
		/// </param>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRController(IAPRRepository aprRepository, IHostingEnvironment hostingEnvironment, ILogger<APRController> logger, IMapper mapper)
			:
			base(hostingEnvironment, logger, mapper)
		{
			APRRepository = aprRepository;
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
				return Ok(Mapper.Map<IEnumerable<IAPRViewModel>>(APRRepository.Get()));
			} // try
			catch (Exception ex)
			{
				Logger.LogError(ex, $"Error retrieving APR (type)s from the repository:  {ex}");
			} // catch

			return BadRequest();
		}

		/// <summary>
		/// POST: api/APR
		/// </summary>
		/// <returns>
		/// 
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[HttpPost]
		public async Task<IActionResult> Post([FromBody] APRViewModel aprViewModel)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var apr = Mapper.Map<IAPR>(aprViewModel);
					//apr.UserName = User.Identity.Name;

					APRRepository.Update(apr);

					// todo|jdevl32: better way (instead of "as") ???
					if (await (APRRepository as APRRepository).SaveChangesAsync())
					{
						// Use map in case database modified the APR in any way.
						var value = Mapper.Map<IAPRViewModel>(apr);

						// todo|jdevl32: contant(s)...
						return Accepted($"/api/APR/{value.Id}", value);
					} // if
				} // if
				else if (HostingEnvironment.IsDevelopment())
				{
					return BadRequest(ModelState);
				} // if
			} // try
			catch (Exception ex)
			{
				Logger.LogError($"Error updating APR ({aprViewModel}):  {ex}");
			} // catch

			return BadRequest();
		}

		/**
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
