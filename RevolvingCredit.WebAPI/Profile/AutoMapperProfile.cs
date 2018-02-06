using JDevl32.Logging.Interface;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;

namespace RevolvingCredit.WebAPI.Profile
{

	/// <summary>
	/// A profile for auto-mapper configuration.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Implement loggable (interface).
	/// </remarks>
	public class AutoMapperProfile
		:
		AutoMapper.Profile
		// todo|jdevl32: ???
		/**/
		,
		ILoggable
		/**/
	{

		// todo|jdevl32: ???
		/**/
#region Property

#region Implementation of ILoggable

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public ILogger Logger => JDevl32.Logging.Logger.Instance;

#endregion

#endregion
		/**/

#region Instance Initialization

		/// <summary>
		/// Create the (auto-mapper) profile.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Remove (protected) restriction on view model id.
		/// </remarks>
		public AutoMapperProfile()
		{
			// todo|jdevl32: ???
			//Logger = loggerFactory.CreateLogger(GetType());

			// todo|jdevl32: ??? here (instead of web-app) ???
			Common.Configure(this);
			// todo|jdevl32: ???
			/**
			CreateMap<APR, UniqueEntityViewModelBase<int>>()
				.ConstructUsing(source => new APRViewModel())
				//.ReverseMap()
			;
			CreateMap<UniqueEntityViewModelBase<int>, APR>()
				.ConstructUsing(source => new APR())
				//.ReverseMap()
			;
			CreateMap<APR, APRViewModel>()
				.ConstructUsing
					(
						CreateAPRViewModel
					)
			;
			CreateMap<APRViewModel, APR>()
				.ConstructUsing
					(
						CreateAPR
					)
				//.ReverseMap()
			;
			/**/
			/**/
		}

		// todo|jdevl32: ???
		/**
		public APR CreateAPR(APRViewModel source)
		{
			var destination = new APR
			{
				Id = source.Id
			};

			LogCreate(source, destination);

			return destination;
		}

		public APRViewModel CreateAPRViewModel(APR source)
		{
			var destination = new APRViewModel
			{
				Id = source.Id
			};

			LogCreate(source, destination);

			return destination;
		}
		/**/

		/// <summary>
		/// 
		/// </summary>
		/// <param name="source"></param>
		/// <param name="destination"></param>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual void LogCreate(object source, object destination)
		{
			Logger.LogInformation($"[{nameof(source)}={source}]");
			Logger.LogInformation($"[{nameof(destination)}={destination}]");
		}

#endregion

	}

}
