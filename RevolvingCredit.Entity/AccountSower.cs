using JDevl32.Entity.Generic;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RevolvingCredit.Entity
{

	/// <inheritdoc />
	/// <summary>
	/// A revolvling credit account sower (seeder).
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AccountSower
		:
		InformableUniqueGuidEntityContextSowerBase<RevolvingCreditContext, Account>
	{

#region Constant

		/// <summary>
		/// The (default) display name.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public const string DefaultDisplayName = "Revolving Credit Account";

#endregion

#region Property

#region Overrides of InformableEntityContextSowerBase<RevolvingCreditContext, Account, Guid>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		protected override IEnumerable<Account> Entity { get; set; }

#endregion

#endregion

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public AccountSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory)
			:
			this(entityContext, loggerFactory, DefaultDisplayName)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public AccountSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, string displayName)
			:
			base(entityContext, loggerFactory, displayName)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public AccountSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, IEnumerable<Account> entity)
			:
			this(entityContext, loggerFactory, DefaultDisplayName, entity)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public AccountSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, string displayName, IEnumerable<Account> entity)
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
			await Seed(EntityContext.Account);

#endregion

	}

}
