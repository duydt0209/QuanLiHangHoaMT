namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Kho : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khos",
                c => new
                    {
                        MaKho = c.String(nullable: false, maxLength: 128),
                        TenKho = c.String(),
                        TinhTrangKho = c.String(),
                    })
                .PrimaryKey(t => t.MaKho);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khos");
        }
    }
}
