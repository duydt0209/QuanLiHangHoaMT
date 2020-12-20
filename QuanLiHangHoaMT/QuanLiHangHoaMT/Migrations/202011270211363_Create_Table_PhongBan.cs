namespace QuanLiHangHoaMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_PhongBan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhongBans", "MaNhanVien", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhongBans", "MaNhanVien");
        }
    }
}
