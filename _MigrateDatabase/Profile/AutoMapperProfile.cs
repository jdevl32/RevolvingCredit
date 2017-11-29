using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Interface;
using RevolvingCredit.Entity.Model;

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

		/// <summary>
		/// Create the profile.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public AutoMapperProfile()
		{
			CreateMap<Account, IAccount>()
				.ConstructUsing(source => new Account())
				.ReverseMap();
			CreateMap<AccountAPR, IAccountAPR>()
				.ConstructUsing(source => new AccountAPR(source.Mapper))
				.ReverseMap();
			CreateMap<AccountIssuer, IAccountIssuer>()
				.ConstructUsing(source => new AccountIssuer(source.Mapper))
				.ReverseMap();
			CreateMap<AccountLabel, IAccountLabel>()
				.ConstructUsing(source => new AccountLabel(source.Mapper))
				.ReverseMap();
			CreateMap<AccountLine, IAccountLine>()
				.ConstructUsing(source => new AccountLine(source.Mapper))
				.ReverseMap();
			CreateMap<AccountNote, IAccountNote>()
				.ConstructUsing(source => new AccountNote())
				.ReverseMap();
			CreateMap<AccountPayment, IAccountPayment>()
				.ConstructUsing(source => new AccountPayment())
				.ReverseMap();
			CreateMap<AccountPromotion, IAccountPromotion>()
				.ConstructUsing(source => new AccountPromotion(source.Mapper))
				.ReverseMap();
			CreateMap<AccountStatement, IAccountStatement>()
				.ConstructUsing(source => new AccountStatement(source.Mapper))
				.ReverseMap();
			CreateMap<APR, IAPR>()
				.ConstructUsing(source => new APR(source.Id))
				.ReverseMap();
			CreateMap<Issuer, IIssuer>()
				.ConstructUsing(source => new Issuer(source.Id))
				.ReverseMap();
			CreateMap<Label, ILabel>()
				.ConstructUsing(source => new Label(source.Id))
				.ReverseMap();
			CreateMap<Line, ILine>()
				.ConstructUsing(source => new Line(source.Id))
				.ReverseMap();
			CreateMap<Payment, IPayment>()
				.ConstructUsing(source => new Payment(source.Id))
				.ReverseMap();
			// todo|jdevl32: maybe not needed ???
			CreateMap<RevolvingCreditContext, IRevolvingCreditContext>()
				.ConstructUsing
					(
						source => new RevolvingCreditContext
							(
								source.DbContextOptions
								,
								source.ConfigurationRoot
								,
								source.HostingEnvironment
								,
								source.Logger
								,
								source.Mapper
								,
								source.ConnectionStringKey
							)
					)
				.ReverseMap();
		}

	}

}
