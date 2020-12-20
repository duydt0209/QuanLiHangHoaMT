namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhaCungCap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCaps",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 128),
                        TenNCC = c.String(),
                        DiaChiNCC = c.String(),
                        SoDT = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.MaNCC);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaCungCaps");
        }
    }
}
