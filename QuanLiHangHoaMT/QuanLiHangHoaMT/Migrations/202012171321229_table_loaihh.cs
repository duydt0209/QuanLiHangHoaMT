namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table_loaihh : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HangHoas", "LoaiHH_MyProperty", "dbo.LoaiHHs");
            RenameColumn(table: "dbo.HangHoas", name: "LoaiHH_MyProperty", newName: "LoaiHH_MaLoaiHH");
            RenameIndex(table: "dbo.HangHoas", name: "IX_LoaiHH_MyProperty", newName: "IX_LoaiHH_MaLoaiHH");
            DropPrimaryKey("dbo.LoaiHHs");
            AddColumn("dbo.LoaiHHs", "MaLoaiHH", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.LoaiHHs", "MaLoaiHH");
            AddForeignKey("dbo.HangHoas", "LoaiHH_MaLoaiHH", "dbo.LoaiHHs", "MaLoaiHH");
            DropColumn("dbo.LoaiHHs", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LoaiHHs", "MyProperty", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.HangHoas", "LoaiHH_MaLoaiHH", "dbo.LoaiHHs");
            DropPrimaryKey("dbo.LoaiHHs");
            DropColumn("dbo.LoaiHHs", "MaLoaiHH");
            AddPrimaryKey("dbo.LoaiHHs", "MyProperty");
            RenameIndex(table: "dbo.HangHoas", name: "IX_LoaiHH_MaLoaiHH", newName: "IX_LoaiHH_MyProperty");
            RenameColumn(table: "dbo.HangHoas", name: "LoaiHH_MaLoaiHH", newName: "LoaiHH_MyProperty");
            AddForeignKey("dbo.HangHoas", "LoaiHH_MyProperty", "dbo.LoaiHHs", "MyProperty");
        }
    }
}
