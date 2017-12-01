using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RevolvingCredit.Entity.Migration
{
	public partial class Create : Microsoft.EntityFrameworkCore.Migrations.Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Account",
				columns: table => new
				{
					Id = table.Column<Guid>(nullable: false),
					Description = table.Column<string>(nullable: true),
					FullName = table.Column<string>(nullable: true),
					SafeAccountNumber = table.Column<short>(nullable: false),
					ShortName = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Account", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "APR",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Description = table.Column<string>(nullable: true),
					FullName = table.Column<string>(nullable: true),
					ShortName = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_APR", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Issuer",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Description = table.Column<string>(nullable: true),
					FullName = table.Column<string>(nullable: true),
					ShortName = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Issuer", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Label",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Description = table.Column<string>(nullable: true),
					FullName = table.Column<string>(nullable: true),
					ShortName = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Label", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Line",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Description = table.Column<string>(nullable: true),
					FullName = table.Column<string>(nullable: true),
					ShortName = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Line", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Payment",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Description = table.Column<string>(nullable: true),
					FullName = table.Column<string>(nullable: true),
					ShortName = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Payment", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "AccountNote",
				columns: table => new
				{
					AccountId = table.Column<Guid>(nullable: false),
					UpdateTimestamp = table.Column<DateTime>(nullable: false),
					Contents = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountNote", x => new { x.AccountId, x.UpdateTimestamp });
					table.ForeignKey(
						name: "FK_AccountNote_Account_AccountId",
						column: x => x.AccountId,
						principalTable: "Account",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AccountStatement",
				columns: table => new
				{
					AccountId = table.Column<Guid>(nullable: false),
					End = table.Column<DateTime>(nullable: false),
					EndBalance = table.Column<double>(nullable: false),
					Fee = table.Column<double>(nullable: false),
					Interest = table.Column<double>(nullable: false),
					Start = table.Column<DateTime>(nullable: false),
					StartBalance = table.Column<double>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountStatement", x => new { x.AccountId, x.End });
					table.ForeignKey(
						name: "FK_AccountStatement_Account_AccountId",
						column: x => x.AccountId,
						principalTable: "Account",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AccountAPR",
				columns: table => new
				{
					AccountId = table.Column<Guid>(nullable: false),
					TypeId = table.Column<int>(nullable: false),
					UpdateTimestamp = table.Column<DateTime>(nullable: false),
					APR = table.Column<double>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountAPR", x => new { x.AccountId, x.TypeId, x.UpdateTimestamp });
					table.ForeignKey(
						name: "FK_AccountAPR_Account_AccountId",
						column: x => x.AccountId,
						principalTable: "Account",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_AccountAPR_APR_TypeId",
						column: x => x.TypeId,
						principalTable: "APR",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AccountPromotion",
				columns: table => new
				{
					AccountId = table.Column<Guid>(nullable: false),
					TypeId = table.Column<int>(nullable: false),
					Start = table.Column<DateTime>(nullable: false),
					End = table.Column<DateTime>(nullable: false),
					APR = table.Column<double>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountPromotion", x => new { x.AccountId, x.TypeId, x.Start, x.End });
					table.ForeignKey(
						name: "FK_AccountPromotion_Account_AccountId",
						column: x => x.AccountId,
						principalTable: "Account",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_AccountPromotion_APR_TypeId",
						column: x => x.TypeId,
						principalTable: "APR",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AccountIssuer",
				columns: table => new
				{
					AccountId = table.Column<Guid>(nullable: false),
					IssuerId = table.Column<int>(nullable: false),
					UpdateTimestamp = table.Column<DateTime>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountIssuer", x => new { x.AccountId, x.IssuerId, x.UpdateTimestamp });
					table.ForeignKey(
						name: "FK_AccountIssuer_Account_AccountId",
						column: x => x.AccountId,
						principalTable: "Account",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_AccountIssuer_Issuer_IssuerId",
						column: x => x.IssuerId,
						principalTable: "Issuer",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AccountLabel",
				columns: table => new
				{
					AccountId = table.Column<Guid>(nullable: false),
					LabelId = table.Column<int>(nullable: false),
					UpdateTimestamp = table.Column<DateTime>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountLabel", x => new { x.AccountId, x.LabelId, x.UpdateTimestamp });
					table.ForeignKey(
						name: "FK_AccountLabel_Account_AccountId",
						column: x => x.AccountId,
						principalTable: "Account",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_AccountLabel_Label_LabelId",
						column: x => x.LabelId,
						principalTable: "Label",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AccountLine",
				columns: table => new
				{
					AccountId = table.Column<Guid>(nullable: false),
					LineId = table.Column<int>(nullable: false),
					UpdateTimestamp = table.Column<DateTime>(nullable: false),
					Limit = table.Column<double>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountLine", x => new { x.AccountId, x.LineId, x.UpdateTimestamp });
					table.ForeignKey(
						name: "FK_AccountLine_Account_AccountId",
						column: x => x.AccountId,
						principalTable: "Account",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_AccountLine_Line_LineId",
						column: x => x.LineId,
						principalTable: "Line",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AccountPayment",
				columns: table => new
				{
					AccountId = table.Column<Guid>(nullable: false),
					Due = table.Column<DateTime>(nullable: false),
					Amount = table.Column<double>(nullable: false),
					TypeId = table.Column<int>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountPayment", x => new { x.AccountId, x.Due });
					table.ForeignKey(
						name: "FK_AccountPayment_Account_AccountId",
						column: x => x.AccountId,
						principalTable: "Account",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_AccountPayment_Payment_TypeId",
						column: x => x.TypeId,
						principalTable: "Payment",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_AccountAPR_TypeId",
				table: "AccountAPR",
				column: "TypeId");

			migrationBuilder.CreateIndex(
				name: "IX_AccountIssuer_IssuerId",
				table: "AccountIssuer",
				column: "IssuerId");

			migrationBuilder.CreateIndex(
				name: "IX_AccountLabel_LabelId",
				table: "AccountLabel",
				column: "LabelId");

			migrationBuilder.CreateIndex(
				name: "IX_AccountLine_LineId",
				table: "AccountLine",
				column: "LineId");

			migrationBuilder.CreateIndex(
				name: "IX_AccountPayment_TypeId",
				table: "AccountPayment",
				column: "TypeId");

			migrationBuilder.CreateIndex(
				name: "IX_AccountPromotion_TypeId",
				table: "AccountPromotion",
				column: "TypeId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "AccountAPR");

			migrationBuilder.DropTable(
				name: "AccountIssuer");

			migrationBuilder.DropTable(
				name: "AccountLabel");

			migrationBuilder.DropTable(
				name: "AccountLine");

			migrationBuilder.DropTable(
				name: "AccountNote");

			migrationBuilder.DropTable(
				name: "AccountPayment");

			migrationBuilder.DropTable(
				name: "AccountPromotion");

			migrationBuilder.DropTable(
				name: "AccountStatement");

			migrationBuilder.DropTable(
				name: "Issuer");

			migrationBuilder.DropTable(
				name: "Label");

			migrationBuilder.DropTable(
				name: "Line");

			migrationBuilder.DropTable(
				name: "Payment");

			migrationBuilder.DropTable(
				name: "APR");

			migrationBuilder.DropTable(
				name: "Account");
		}
	}
}
