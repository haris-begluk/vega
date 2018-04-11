using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('AnonymousName463')"); 
                migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('AnonymousName747')");
                migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('AnonymousName436')");
                migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('AnonymousName6347')");
                migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('AnonymousName845')"); 
                migrationBuilder.Sql("INSERT INTO Models(Name, MakeId) VALUES ('AnonymousName463-Model1', 1)");
                migrationBuilder.Sql("INSERT INTO Models(Name, MakeId) VALUES ('AnonymousName747-Model1', 2)");
                migrationBuilder.Sql("INSERT INTO Models(Name, MakeId) VALUES ('AnonymousName845-Model1', 5)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.Sql("DELETE FROM Makes ");
        }
    }
}
