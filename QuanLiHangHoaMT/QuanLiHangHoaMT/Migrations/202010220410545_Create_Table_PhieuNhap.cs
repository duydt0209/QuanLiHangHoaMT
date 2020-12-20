namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_PhieuNhap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhieuNhaps",
                c => new
                    {
                        MaNhap = c.String(nullable: false, maxLength: 128),
                        TenPhieuNhap = c.String(),
                        NgayNhap = c.String(),
                        SoLuongNhap = c.String(),
                        GiaNhap = c.String(),
                    })
                .PrimaryKey(t => t.MaNhap);
            
            CreateTable(
                "dbo.PhieuXuats",
                c => new
                    {
                        MaXuat = c.String(nullable: false, maxLength: 128),
                        TenPhieuXuat = c.String(),
                        NgayXuat = c.String(),
                        SoLuongXuat = c.String(),
                        GiaXuat = c.String(),
                    })
                .PrimaryKey(t => t.MaXuat);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhieuXuats");
            DropTable("dbo.PhieuNhaps");
        }
    }
}
