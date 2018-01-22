using JDevl32.Web.ViewModel;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Model;
using RevolvingCredit.WebAPI.ViewModel;

namespace RevolvingCredit.WebAPI.Profile
{

	/// <inheritdoc />
	/// <summary>
	/// A profile for auto-mapper configuration.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AutoMapperProfile
		:
		AutoMapper.Profile
	{

#region Instance Initialization

		/// <summary>
		/// Create the profile.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Create map of APR to unique item (base class).
		/// </remarks>
		public AutoMapperProfile()
		{
			// todo|jdevl32: ??? here (instead of web-app) ???
			Common.Configure(this);
			CreateMap<APR, UniqueViewModelBase>()
				.ConstructUsing(source => new APRViewModel())
				.ReverseMap()
			;
		}

#endregion

	}

}
