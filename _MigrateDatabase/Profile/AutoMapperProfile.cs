using RevolvingCredit.Entity;

namespace _MigrateDatabase.Profile
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
		/// Refactor auto-mapper profile configuration.
		/// </remarks>
		public AutoMapperProfile() => Common.Configure(this);

#endregion

	}

}
