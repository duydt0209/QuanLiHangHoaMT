namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KhachHang : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.HangHoas");
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 128),
                        TenKhachHang = c.String(),
                        SoDT = c.String(),
                        DiaChi = c.String(),
                        NgaySinh = c.String(),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
            AlterColumn("dbo.HangHoas", "MaHangHoa", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.HangHoas", "TenHangHoa", c => c.String());
            AlterColumn("dbo.HangHoas", "DonGia", c => c.String());
            AlterColumn("dbo.HangHoas", "SoLuong", c => c.String());
            AddPrimaryKey("dbo.HangHoas", "MaHangHoa");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.HangHoas");
            AlterColumn("dbo.HangHoas", "SoLuong", c => c.String(unicode: false));
            AlterColumn("dbo.HangHoas", "DonGia", c => c.String(unicode: false));
            AlterColumn("dbo.HangHoas", "TenHangHoa", c => c.String(unicode: false));
            AlterColumn("dbo.HangHoas", "MaHangHoa", c => c.String(nullable: false, maxLength: 128, unicode: false));
            DropTable("dbo.KhachHangs");
            AddPrimaryKey("dbo.HangHoas", "MaHangHoa");
        }
    }
}
