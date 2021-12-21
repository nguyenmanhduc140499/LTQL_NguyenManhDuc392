namespace LTQL_1721050392.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NMDSinhvien392 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NMDSinhVien392",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(),
                        MaLop = c.String(),
                    })
                .PrimaryKey(t => t.MaSinhVien);
            
            AddColumn("dbo.LopHoc392", "MaSinhVien", c => c.String(maxLength: 128));
            CreateIndex("dbo.LopHoc392", "MaSinhVien");
            AddForeignKey("dbo.LopHoc392", "MaSinhVien", "dbo.NMDSinhVien392", "MaSinhVien");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LopHoc392", "MaSinhVien", "dbo.NMDSinhVien392");
            DropIndex("dbo.LopHoc392", new[] { "MaSinhVien" });
            DropColumn("dbo.LopHoc392", "MaSinhVien");
            DropTable("dbo.NMDSinhVien392");
        }
    }
}
