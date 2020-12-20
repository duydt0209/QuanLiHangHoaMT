namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class capnhap_hh : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.HangHoas", name: "LoaiHH_MaLoaiHH", newName: "MaLoaiHH");
            RenameIndex(table: "dbo.HangHoas", name: "IX_LoaiHH_MaLoaiHH", newName: "IX_MaLoaiHH");
            AddColumn("dbo.HangHoas", "HinhHH", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HangHoas", "HinhHH");
            RenameIndex(table: "dbo.HangHoas", name: "IX_MaLoaiHH", newName: "IX_LoaiHH_MaLoaiHH");
            RenameColumn(table: "dbo.HangHoas", name: "MaLoaiHH", newName: "LoaiHH_MaLoaiHH");
        }
    }
}
