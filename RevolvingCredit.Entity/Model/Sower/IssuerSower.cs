using JDevl32.Entity.Generic;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RevolvingCredit.Entity.Model.Sower
{

	/// <inheritdoc />
	/// <summary>
	/// An issuer sower (seeder).
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class IssuerSower
		:
		InformableUniqueIntEntityContextSowerBase<RevolvingCreditContext, Issuer>
	{

#region Constant

		/// <summary>
		/// The (default) display name.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public const string DefaultDisplayName = "Issuer";

#endregion

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public IssuerSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory)
			:
			this(entityContext, loggerFactory, DefaultDisplayName.ToLowerInvariant())
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public IssuerSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, string displayName)
			:
			this(entityContext, loggerFactory, displayName, GetDefaultEntity(displayName))
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public IssuerSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, string displayName, IEnumerable<Issuer> entity)
			:
			base(entityContext, loggerFactory, displayName, entity)
		{
		}

#endregion

#region Overrides of EntityContextSowerBase<RevolvingCreditContext>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public override async Task Seed()
			=>
			await Seed(EntityContext.Issuer);

#endregion

		/// <summary>
		/// Get the default (set of) unique entity item(s) to seed.
		/// </summary>
		/// <param name="displayName">
		/// A display name.
		/// </param>
		/// <returns>
		/// The default (set of) unique entity item(s) to seed.
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public static IEnumerable<Issuer> GetDefaultEntity(string displayName)
			=>
			new []
			{
				new Issuer
				{
					Description = $"The Bank of America Financial Services {displayName}."
					,
					FullName = "Bank of America Financial Services"
					,
					ShortName = "Bank of America"
				}
				,
				new Issuer
				{
					Description = $"The Capital One Financial Services {displayName}."
					,
					FullName = "Capital One Financial Services"
					,
					ShortName = "Capital One"
				}
				,
				new Issuer
				{
					Description = $"The Chase Financial Services {displayName}."
					,
					FullName = "Chase Financial Services"
					,
					ShortName = "Chase"
				}
				,
				new Issuer
				{
					Description = $"The Comenity Bank {displayName}."
					,
					FullName = "Comenity Bank"
					,
					ShortName = "Comenity"
				}
				,
				new Issuer
				{
					Description = $"The Dell Financial Services {displayName}."
					,
					FullName = "Dell Financial Services"
					,
					ShortName = "Dell"
				}
				,
				new Issuer
				{
					Description = $"The Discover Financial Services {displayName}."
					,
					FullName = "Discover Financial Services"
					,
					ShortName = "Discover"
				}
				,
				new Issuer
				{
					Description = $"The LMCU (Lake Michigan Credit Union) Financial Services {displayName}."
					,
					FullName = "LMCU Financial Services"
					,
					ShortName = "LMCU"
				}
				,
				new Issuer
				{
					Description = $"The PayPal Financial Services {displayName}."
					,
					FullName = "PayPal Financial Services"
					,
					ShortName = "PayPal"
				}
				,
				new Issuer
				{
					Description = $"The Synchrony Financial Services {displayName}."
					,
					FullName = "Synchrony Financial Services"
					,
					ShortName = "Synchrony"
				}
			}
		;
	}

}
