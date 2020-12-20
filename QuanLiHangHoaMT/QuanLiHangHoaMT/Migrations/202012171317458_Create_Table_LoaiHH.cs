namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_LoaiHH : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiHHs",
                c => new
                    {
                        MyProperty = c.String(nullable: false, maxLength: 128),
                        TenLoaiSP = c.String(),
                    })
                .PrimaryKey(t => t.MyProperty);
            
            AddColumn("dbo.HangHoas", "LoaiHH_MyProperty", c => c.String(maxLength: 128));
            CreateIndex("dbo.HangHoas", "LoaiHH_MyProperty");
            AddForeignKey("dbo.HangHoas", "LoaiHH_MyProperty", "dbo.LoaiHHs", "MyProperty");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HangHoas", "LoaiHH_MyProperty", "dbo.LoaiHHs");
            DropIndex("dbo.HangHoas", new[] { "LoaiHH_MyProperty" });
            DropColumn("dbo.HangHoas", "LoaiHH_MyProperty");
            DropTable("dbo.LoaiHHs");
        }
    }
}
