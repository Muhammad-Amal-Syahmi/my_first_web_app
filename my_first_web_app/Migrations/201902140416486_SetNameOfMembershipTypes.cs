namespace my_first_web_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Type = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Type = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Type = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Type = 'Anually' WHERE Id = 4");
        }
        
        public override void Down()
        {
            
        }
    }
}
