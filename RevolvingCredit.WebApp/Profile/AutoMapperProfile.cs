namespace RevolvingCredit.WebApp.Profile
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
		/// Add account balance.
		/// </remarks>
		public AutoMapperProfile()
		{
			// todo|jdevl32: ??? here (instead of web-api) ???
			//Common.Configure(this);
		}

#endregion

	}

}
