namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chinh_sua_bang_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhieuXuats", "MaNhanVien", c => c.String());
            AddColumn("dbo.PhieuXuats", "MaKhachHang", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhieuXuats", "MaKhachHang");
            DropColumn("dbo.PhieuXuats", "MaNhanVien");
        }
    }
}
