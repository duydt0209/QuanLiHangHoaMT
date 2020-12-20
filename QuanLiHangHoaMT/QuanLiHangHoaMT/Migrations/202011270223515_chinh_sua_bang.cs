namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chinh_sua_bang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhieuNhaps", "MaNhanVien", c => c.String());
            AddColumn("dbo.PhieuNhaps", "MaNCC", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhieuNhaps", "MaNCC");
            DropColumn("dbo.PhieuNhaps", "MaNhanVien");
        }
    }
}
