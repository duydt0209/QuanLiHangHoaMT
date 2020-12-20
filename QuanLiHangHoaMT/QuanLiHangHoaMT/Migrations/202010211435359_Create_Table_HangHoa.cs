namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HangHoa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HangHoas", "DonGia", c => c.String(unicode: false));
            AlterColumn("dbo.HangHoas", "SoLuong", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HangHoas", "SoLuong", c => c.Int(nullable: false));
            AlterColumn("dbo.HangHoas", "DonGia", c => c.Int(nullable: false));
        }
    }
}
