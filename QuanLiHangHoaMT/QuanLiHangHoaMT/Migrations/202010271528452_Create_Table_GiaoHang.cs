namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_GiaoHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GiaoHang",
                c => new
                    {
                        MaGH = c.String(nullable: false, maxLength: 128),
                        PhuongTienGH = c.String(),
                        GiaGH = c.String(),
                    })
                .PrimaryKey(t => t.MaGH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GiaoHang");
        }
    }
}
