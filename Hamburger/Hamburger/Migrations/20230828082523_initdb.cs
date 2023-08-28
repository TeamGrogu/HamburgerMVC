using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToppingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Statuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Statuses",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateTable(
                name: "MenuProducts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MenuProducts_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductToppings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ToppingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductToppings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductToppings_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductToppings_Toppings_ToppingID",
                        column: x => x.ToppingID,
                        principalTable: "Toppings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFavorites",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavorites", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserFavorites_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFavorites_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFavorites_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    MenuID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "SizeID");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "b631a43b-28b1-4af2-97be-e4735e20d037", "Admin", "ADMIN" },
                    { 2, "09dbb7ba-0084-4f98-992a-24fe7c8e3719", "Standard", "STANDARD" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "Kadikoy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4d15dc5d-51a7-4324-aa8f-99285159cf8d", "overthinkerst@gmail.com", false, "overthinkers", "team", false, null, "OVERTHINKERST@GMAIL.COM", "OVERTHINKERS", "AQAAAAEAACcQAAAAEGjfFAFJdYV0RxwIcTGBRg0Lc6pvJj3N2pEPDlkHvVkF+yQRwVCyGMTPKwYaTwcx3g==", null, false, null, false, "overthinkers" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreateDate", "UpdateDate", "isActive" },
                values: new object[,]
                {
                    { 1, "Hamburgers", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3136), true },
                    { 2, "Sides", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3139), new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3139), true },
                    { 3, "Beverages", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3140), new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3141), true },
                    { 4, "Deserts", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3141), new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3142), true },
                    { 5, "Sauces", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3143), new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3143), true },
                    { 6, "Topppings", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3144), new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3145), true }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "Price", "SizeName" },
                values: new object[,]
                {
                    { 1, 0m, "Küçük Boy" },
                    { 2, 0m, "Orta Boy" },
                    { 3, 0m, "Büyük Boy" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreateDate", "Description", "Price", "ProductImage", "ProductName", "UpdateDate", "isActive" },
                values: new object[,]
                {
                    { 101, 1, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3383), "Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan bir Burger King® klasiği.", 134.99m, "https://www.burgerking.com.tr/cmsfiles/products/whopper.png?v=285", "Whopper Burger", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3383), true },
                    { 102, 1, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3420), "King Chicken eti, susamlı sandviç ekmeği, mayonez ve doğranmış maruldan oluşan son derece sade bir lezzet alternatifi.", 124.99m, "https://www.burgerking.com.tr/cmsfiles/products/king-chicken-1.png?v=285", "King Chicken Burger", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3421), true },
                    { 103, 1, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3423), "Kocaman Steakhouse eti, özel sosu, cheddar peyniri, domatesi, mayonezi, marulu ve çıtır kaplamalı soğanlarıyla sabrınızı zorlayacak bir lezzet.", 174.99m, "https://www.burgerking.com.tr/cmsfiles/products/bk-steakhouse-burger.png?v=285", "Steakhouse Burger", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3424), true },
                    { 104, 1, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3426), "4 adet Hamburger eti, 3 katlı özel ekmeği, cheddar peyniri, salatalık turşusu, doğranmış marul ve soğana eşlik eden özel Big King® sosun birleşimi", 194.99m, "https://www.burgerking.com.tr/cmsfiles/products/double-big-king.png?v=285", "Double Big King Burger", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3426), true },
                    { 105, 1, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3428), "Whopper® eti, büyük boy susamlı sandviç ekmeği, mayonez, doğranmış marul, soğan halkaları, nefis barbekü sosu ve 2 adet cheddar peynirinden oluşan Whopper® lezzeti.", 159.99m, "https://www.burgerking.com.tr/cmsfiles/products/rodeo-whopper.png?v=285", "Rodeo Whopper Burger", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3429), true },
                    { 106, 1, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3431), "İki adet Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğanla klasik Whopper® lezzetini ikiye katlamak için ideal.", 194.99m, "https://www.burgerking.com.tr/cmsfiles/products/double-whopper-1.png?v=285", "Double Whopper Burger", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3431), true },
                    { 107, 1, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3433), "Hamburger eti, küçük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan, Whopper® lezzetinden vazgeçemeyenlere nefis bir seçim.", 109.99m, "https://www.burgerking.com.tr/cmsfiles/products/whopper-jr.png?v=285", "Whopper Jr. Burger", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3433), true },
                    { 108, 1, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3436), "Özel kaplamasıyla tavuk göğüs fileto, mısır irmiği ile süslemeli özel ekmeği, spicy sosu, domatesi ve doğranmış maruldan oluşan yeni bir lezzet.", 109.99m, "https://www.burgerking.com.tr/cmsfiles/products/spicy-gurme-tavuk.png?v=285", "Spicy Gurme Burger", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3436), true },
                    { 109, 1, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3439), "Fish Royale® eti, küçük boy susamlı sandviç ekmeği, doğranmış marul ile burger klasiğine lezzetini veren tartar sosun birleşimi.", 159.99m, "https://www.burgerking.com.tr/cmsfiles/products/fish-royale-1.png?v=285", "Fish Royale Burger", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3439), true },
                    { 110, 1, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3441), "2 adet Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, 4 adet cheddar peyniri, hardal ve ketçaptan oluşan lezzet.", 159.99m, "https://www.burgerking.com.tr/cmsfiles/products/mega-double-cheeseburger.png?v=285", "Mega Double CheeseBurger", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3441), true },
                    { 201, 2, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3443), "Doğal, soyulmuş, gevrek kızarmış patates", 59.99m, "https://www.burgerking.com.tr/cmsfiles/products/patates.png?v=285", "Patates", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3444), true },
                    { 202, 2, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3445), "Çıtır Mı Çıtır Altın Sarısı Tırtıklı Patates", 69.99m, "https://www.burgerking.com.tr/cmsfiles/products/tirtikli-patates.png?v=285", "Tırtıklı  Patates", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3446), true },
                    { 203, 2, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3447), "Çıtır çıtır 8’li, 12’li ya da 16’lı Soğan Halka lezzeti", 79.99m, "https://www.burgerking.com.tr/cmsfiles/products/sogan-halkasi.png?v=285", "Soğan Halkası", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3448), true },
                    { 204, 2, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3450), "Dışı çıtır çıtır, içi sıcacık peyniriyle Çıtır Peynir!", 75.99m, "https://www.burgerking.com.tr/cmsfiles/products/citir-peynir.png?v=285", "Çıtır Peynir", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3451), true },
                    { 205, 2, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3453), "Dışı çıtır çıtır, Nuggets...", 75.99m, "https://www.burgerking.com.tr/cmsfiles/products/bk-king-nuggets-1.png?v=285", "Çıtır Nuggets", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3453), true },
                    { 206, 2, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3455), "Özel harcıyla nar gibi kızarmış  beyaz tavuk eti.", 85.99m, "https://www.burgerking.com.tr/cmsfiles/products/chicken-tenders.png?v=285", "Çıtır Tavuk Tenders", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3455), true },
                    { 301, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3457), "Şeftalili Fuse Tea ve Limonlu Fuse Tea seçenekleri ile", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/fuse-tea.png?v=285", "Fuse Tea", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3458), true },
                    { 302, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3459), "Cola cola ", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/coca-cola.png?v=285", "Coca Cola", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3460), true },
                    { 303, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3462), "Cola cola Zero ", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/coca-cola-zero-sugar.png?v=285", "Coca Cola Zero", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3462), true },
                    { 304, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3465), "Fanta", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/fanta.png?v=285", "Fanta", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3465), true },
                    { 305, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3467), "Sprite", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/sprite.png?v=285", "Sprite", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3468), true },
                    { 306, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3469), "Ayran", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/sprite.png?v=285", "Ayran", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3470), true },
                    { 307, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3471), "Elma Suyu", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/elma-suyu.png?v=285", "Cappy Elma Suyu", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3472), true },
                    { 308, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3474), "Atom Suyu", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/cappy-atom-200-ml.png?v=285", "Cappy Atom", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3474), true },
                    { 309, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3476), "Kahve Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/espresso.png?v=285", "Espresso", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3476), true },
                    { 310, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3478), "Kahve Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/nescafe-black.png?v=285", "Filtre Kahve", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3478), true },
                    { 311, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3480), "Karadeniz Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/cay.png?v=285", "Çay", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3481), true },
                    { 312, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3562), "Karadeniz Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/vanilyali-cappuccino.png?v=285", "Cappuccino", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3563), true },
                    { 313, 3, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3565), "Çikolata Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/nestle-sicak-cikolata.png?v=285", "Sıcak Çikolata", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3566), true },
                    { 401, 4, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3567), "Çikolata Lezzeti", 45.99m, "https://www.burgerking.com.tr/cmsfiles/products/cikolatali-cookie.png?v=285", "Çikolatalı Cookie", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3568), true },
                    { 402, 4, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3570), "Çikolata Lezzeti", 45.99m, "https://www.burgerking.com.tr/cmsfiles/products/sufle.png?v=285", "Sufle", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3570), true },
                    { 403, 4, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3572), "Vişne Lezzeti", 55.99m, "https://www.burgerking.com.tr/cmsfiles/products/visneli-tatli.png?v=285", "Vişneli Tatlı", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3572), true },
                    { 404, 4, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3575), "Vanilyalı, Çilekli, Çikolatalı, Espressolu, Limonlu çeşitleriyle.", 55.99m, "https://www.burgerking.com.tr/cmsfiles/products/espressolu-milkshake.png?v=285", "Vişneli Tatlı", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3575), true },
                    { 405, 4, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3577), "Vanilyalı, Çilekli, Çikolatalı, Espressolu, Limonlu çeşitleriyle.", 55.99m, "https://www.burgerking.com.tr/cmsfiles/products/espressolu-milkshake.png?v=285", "Vişneli Tatlı", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3577), true },
                    { 406, 4, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3581), "Vanilyalı, Çikolata Soslu, Böğürtlen Soslu, Karamel Soslu, Çilek Soslu, Limonlu", 65.99m, "https://www.burgerking.com.tr/cmsfiles/products/king-sundae.png?v=285", "King Sundae", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3581), true },
                    { 407, 4, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3583), "Çikolata Parçacıklı, Renkli Çikolata Drajeleri, Limonlu", 75.99m, "https://www.burgerking.com.tr/cmsfiles/products/bkool.png?v=285", "Bkool", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3583), true },
                    { 501, 5, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3588), "Acı Sos", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-aci-sos.png?v=285", "Mini Acı Sos", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3588), true },
                    { 502, 5, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3591), "Mayonez", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-mayonez.png?v=285", "Mayonez", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3591), true },
                    { 503, 5, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3594), "Ranch Sos", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-ranch.png?v=285", "Mini Ranch", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3594), true },
                    { 504, 5, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3596), "Sarımsaklı Sos", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-sarimsakli-mayonez-1.png?v=285", "Sarımsaklı Sos", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3596), true },
                    { 505, 5, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3600), "Mini Ketçap", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-ketcap.png?v=285", "Mini Ketçap", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3600), true }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreateDate", "Description", "Price", "ProductImage", "ProductName", "UpdateDate", "isActive" },
                values: new object[,]
                {
                    { 506, 5, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3627), "Mini Ketçap", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-ketcap.png?v=285", "Mini Ketçap", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3627), true },
                    { 507, 5, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3629), "Mini BBQ", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-bbq.png?v=285", "Mini BBQ", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3630), true },
                    { 508, 5, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3632), "Buffalo Sos", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-buffalo-1.png?v=285", "Buffalo Sos", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3632), true },
                    { 601, 6, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3634), "Marul", 5.99m, null, "Marul", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3634), true },
                    { 602, 6, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3636), "Domates", 5.99m, null, "Domates", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3637), true },
                    { 603, 6, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3638), "Cheddar Peyniri", 5.99m, null, "Cheddar Peyniri", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3639), true },
                    { 604, 6, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3641), "Turşu", 5.99m, null, "Turşu", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3641), true },
                    { 605, 6, new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3643), "Soğan", 5.99m, null, "Soğan", new DateTime(2023, 8, 28, 11, 25, 23, 43, DateTimeKind.Local).AddTicks(3643), true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MenuProducts_MenuID",
                table: "MenuProducts",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuProducts_ProductID",
                table: "MenuProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MenuID",
                table: "OrderDetails",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SizeID",
                table: "OrderDetails",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusID",
                table: "Orders",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductToppings_ProductID",
                table: "ProductToppings",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductToppings_ToppingID",
                table: "ProductToppings",
                column: "ToppingID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_MenuID",
                table: "UserFavorites",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_ProductID",
                table: "UserFavorites",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_UserID",
                table: "UserFavorites",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MenuProducts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductToppings");

            migrationBuilder.DropTable(
                name: "UserFavorites");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
