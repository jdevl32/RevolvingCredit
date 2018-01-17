using AutoMapper;
using JDevl32.Web.Controller.Generic;
using JDevl32.Web.Repository.Interface.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity.Model;
using RevolvingCredit.WebAPI.Repository;
using RevolvingCredit.WebAPI.ViewModel;

namespace RevolvingCredit.WebAPI.Controller
{

	/// <summary>
	/// The APR (type) controller.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add repository type.
	/// Add unique item type.
	/// Add unique item view model type.
	/// </remarks>
	[Produces("application/json")]
	[Route("api/APR")]
	public class APRController
		:
		UniqueInformableControllerBase<APRController, APRRepository, APR, APRViewModel>
	{

#region Constant

		/// <summary>
		/// The (default) display name.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public const string DefaultDisplayName = "APR (type)";

#endregion

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Replace derived class with repository type.
		/// Add unique item type.
		/// </remarks>
		public APRController(IHostingEnvironment hostingEnvironment, ILogger<APRController> logger, IMapper mapper, IUniqueInformableEntityContextRepository<APRRepository, APR> uniqueInformableEntityContextRepository)
			:
			this(hostingEnvironment, logger, mapper, uniqueInformableEntityContextRepository, DefaultDisplayName)
		{
		}

		// todo|jdevl32: ??? is making protected the best solution ???
		// todo|jdevl32: ??? ...and then...how to handle default display name ???
		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Replace derived class with repository type.
		/// Add unique item type.
		/// </remarks>
		protected APRController(IHostingEnvironment hostingEnvironment, ILogger<APRController> logger, IMapper mapper, IUniqueInformableEntityContextRepository<APRRepository, APR> uniqueInformableEntityContextRepository, string displayName)
			:
			base(hostingEnvironment, logger, mapper, uniqueInformableEntityContextRepository, displayName)
		{
		}

#endregion

		// todo|jdevl32: cleanup...
		/**
#region Property

		/// <summary>
		/// The APR (type) repository.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public IAPRRepository APRRepository { get; }

#endregion

#region Instance Initialization

		/// <summary>
		/// Create an APR (type) controller.
		/// </summary>
		/// <param name="aprRepository">
		/// The (injected) APR (type) repository.
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
		/// DELETE: api/APR
		/// Remove (all) the APR (type)s.
		/// </summary>
		/// <returns>
		/// A(n) (async) action result task.
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// Provision delete all route.
		/// </remarks>
		[HttpDelete("*", Name = "RemoveAll")]
		public async Task<IActionResult> Delete()
		{
			try
			{
				if (ModelState.IsValid)
				{
					APRRepository.Remove();

					if (await APRRepository.SaveChangesAsync())
					{
						return Ok();
					} // if
				} // if
				else if (HostingEnvironment.IsDevelopment())
				{
					return BadRequest(ModelState);
				} // if
			} // try
			catch (Exception exception)
			{
				Logger.LogError($"Error removing APR (type)(s):  {exception}");
			} // catch

			return BadRequest();
		}

		/// <summary>
		/// DELETE: api/APR
		/// Remove the APR (type) (specified by the view model).
		/// </summary>
		/// <param name="aprViewModel">
		/// The APR (type) view model.
		/// </param>
		/// <returns>
		/// A(n) (async) action result task.
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[HttpDelete]
		public async Task<IActionResult> Delete([FromBody] APRViewModel aprViewModel)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var apr = Mapper.Map<IAPR>(aprViewModel);
					//apr.UserName = User.Identity.Name;

					APRRepository.Remove(apr);

					if (await APRRepository.SaveChangesAsync())
					{
						return Ok();
					} // if
				} // if
				else if (HostingEnvironment.IsDevelopment())
				{
					return BadRequest(ModelState);
				} // if
			} // try
			catch (Exception exception)
			{
				Logger.LogError($"Error removing APR (type) ({aprViewModel}):  {exception}");
			} // catch

			return BadRequest();
		}

		/// <summary>
		/// GET: api/APR
		/// </summary>
		/// <returns>
		/// An action result.
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
				Logger.LogError(ex, $"Error retrieving APR (type)(s) from the repository:  {ex}");
			} // catch

			return BadRequest();
		}

		/// <summary>
		/// POST: api/APR
		/// </summary>
		/// <param name="aprViewModel">
		/// The APR (type) view model.
		/// </param>
		/// <returns>
		/// A(n) (async) action result task.
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[HttpPost]
		public async Task<IActionResult> Post([FromBody] APRViewModel aprViewModel)
		{
			// todo|jdevl32: contant(s)...
			try
			{
				if (ModelState.IsValid)
				{
					var apr = Mapper.Map<IAPR>(aprViewModel);
					//apr.UserName = User.Identity.Name;

					APRRepository.Update(apr);

					if (await APRRepository.SaveChangesAsync())
					{
						// Use map in case database modified the APR in any way.
						var value = Mapper.Map<IAPRViewModel>(apr);

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
				Logger.LogError($"Error updating APR (type) ({aprViewModel}):  {ex}");
			} // catch

			return BadRequest();
		}
		/**/

	}

}
