namespace CodeFirstUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.CourseTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CourseTypes",
                c => new
                    {
                        CourseTypeID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.CourseTypeID);
            
        }
    }
}
