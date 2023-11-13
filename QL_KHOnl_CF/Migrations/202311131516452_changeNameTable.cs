namespace QL_KHOnl_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeNameTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.COURSEs", newName: "COURSE");
            RenameTable(name: "dbo.FEEDBACKs", newName: "FEEDBACK");
            RenameTable(name: "dbo.TEACHERs", newName: "TEACHER");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TEACHER", newName: "TEACHERs");
            RenameTable(name: "dbo.FEEDBACK", newName: "FEEDBACKs");
            RenameTable(name: "dbo.COURSE", newName: "COURSEs");
        }
    }
}
