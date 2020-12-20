namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CSB3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoaDons", "MaHangHoa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HoaDons", "MaHangHoa");
        }
    }
}
