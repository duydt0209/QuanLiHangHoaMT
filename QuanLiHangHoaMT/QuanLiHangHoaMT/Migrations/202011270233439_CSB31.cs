namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CSB31 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhieuNhaps", "MaHangHoa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhieuNhaps", "MaHangHoa");
        }
    }
}
