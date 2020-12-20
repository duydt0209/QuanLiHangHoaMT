namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 128),
                        TenNhanVien = c.String(),
                        NgaySinhNV = c.String(),
                        DiaChiNV = c.String(),
                        QueQuanNV = c.String(),
                        SoDT = c.String(),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            AddColumn("dbo.KhachHangs", "DiaChiKH", c => c.String());
            DropColumn("dbo.KhachHangs", "DiaChi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KhachHangs", "DiaChi", c => c.String());
            DropColumn("dbo.KhachHangs", "DiaChiKH");
            DropTable("dbo.NhanViens");
        }
    }
}
