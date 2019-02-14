namespace my_first_web_app.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Type", c => c.String(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Type");
        }
    }
}
