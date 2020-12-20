namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HoaDon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoaDons", "MaNhanVien", c => c.String());
            AddColumn("dbo.HoaDons", "MaKhachHang", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HoaDons", "MaKhachHang");
            DropColumn("dbo.HoaDons", "MaNhanVien");
        }
    }
}
