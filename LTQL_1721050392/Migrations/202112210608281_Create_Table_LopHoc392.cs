namespace LTQL_1721050392.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_LopHoc392 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHoc392",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(),
                    })
                .PrimaryKey(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LopHoc392");
        }
    }
}
