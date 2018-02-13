using JDevl32.Entity.Generic;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RevolvingCredit.Entity.Model.Sower
{

	/// <inheritdoc />
	/// <summary>
	/// A (major) label sower (seeder).
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class LabelSower
		:
		InformableUniqueIntEntityContextSowerBase<RevolvingCreditContext, Label>
	{

#region Constant

		/// <summary>
		/// The (default) display name.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public const string DefaultDisplayName = "(Major) label";

#endregion

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public LabelSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory)
			:
			this(entityContext, loggerFactory, DefaultDisplayName.ToLowerInvariant())
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public LabelSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, string displayName)
			:
			this(entityContext, loggerFactory, displayName, GetDefaultEntity(displayName))
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public LabelSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, string displayName, IEnumerable<Label> entity)
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
			await Seed(EntityContext.Label);

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
		public static IEnumerable<Label> GetDefaultEntity(string displayName)
			=>
			new []
			{
				new Label
				{
					Description = $"The Discover credit card {displayName}."
					,
					FullName = "Discover credit card"
					,
					ShortName = "Discover"
				}
				,
				new Label
				{
					Description = $"The MasterCard credit card {displayName}."
					,
					FullName = "MasterCard credit card"
					,
					ShortName = "MasterCard"
				}
				,
				new Label
				{
					Description = $"The Visa credit card {displayName}."
					,
					FullName = "Visa credit card"
					,
					ShortName = "Visa"
				}
			}
		;
	}

}
