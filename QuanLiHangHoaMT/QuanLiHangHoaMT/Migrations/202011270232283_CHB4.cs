namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CHB4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhieuXuats", "MaHangHoa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhieuXuats", "MaHangHoa");
        }
    }
}
