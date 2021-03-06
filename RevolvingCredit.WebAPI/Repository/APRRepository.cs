﻿using JDevl32.Web.Repository.Generic;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.WebAPI.Repository
{

	/// <inheritdoc />
	/// <summary>
	/// An APR (type) repository.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor loggable logger category name.
	/// </remarks>
	public class APRRepository
		:
		InformableUniqueIntEntityContextRepositoryBase<RevolvingCreditContext, APR>
	{

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Refactor loggable logger category name.
		/// </remarks>
		public APRRepository(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory)
			:
			base(entityContext, loggerFactory, entityContext.APR)
		{
		}

#endregion

	}

}
