namespace QL_KHOnl_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ASSIGNMENTS",
                c => new
                    {
                        ASSIGNMENTID = c.String(nullable: false, maxLength: 128),
                        ID_COURSE = c.String(maxLength: 128),
                        TITLE_ASSIGNMENT = c.String(),
                        Description_ASSIGNMENT = c.String(),
                        DueDate_ASSIGNMENT = c.DateTime(),
                        Type_ASSIGNMENT = c.String(),
                        POINTS = c.Double(),
                    })
                .PrimaryKey(t => t.ASSIGNMENTID)
                .ForeignKey("dbo.COURSEs", t => t.ID_COURSE)
                .Index(t => t.ID_COURSE);
            
            CreateTable(
                "dbo.COURSEs",
                c => new
                    {
                        ID_COURSE = c.String(nullable: false, maxLength: 128),
                        ID_TYPECOURSE = c.String(maxLength: 128),
                        ID_TEACHER = c.String(maxLength: 128),
                        NAME_COURSE = c.String(),
                        DESCRIPTION_COURSE = c.String(),
                        PRICE_COURSE = c.Double(nullable: false),
                        STATUS_COURSE = c.String(),
                        THUMBNAIL = c.String(),
                        COUNT_LESSON_COURSE = c.Int(nullable: false),
                        LEVEL_COURSE = c.String(),
                        CREATED_AT_COURSE = c.DateTime(),
                        UPDATE_AT_COURSE = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID_COURSE)
                .ForeignKey("dbo.TEACHERs", t => t.ID_TEACHER)
                .ForeignKey("dbo.TYPE_COURSE", t => t.ID_TYPECOURSE)
                .Index(t => t.ID_TYPECOURSE)
                .Index(t => t.ID_TEACHER);
            
            CreateTable(
                "dbo.GRADES",
                c => new
                    {
                        GRADEID = c.String(nullable: false, maxLength: 128),
                        ID_USER = c.String(maxLength: 128),
                        ID_COURSE = c.String(maxLength: 128),
                        ASSIGNMENTID = c.String(),
                        QUIZID = c.String(),
                        GRADE = c.Double(),
                    })
                .PrimaryKey(t => t.GRADEID)
                .ForeignKey("dbo.COURSEs", t => t.ID_COURSE)
                .ForeignKey("dbo.USER_COURSE", t => t.ID_USER)
                .Index(t => t.ID_USER)
                .Index(t => t.ID_COURSE);
            
            CreateTable(
                "dbo.USER_COURSE",
                c => new
                    {
                        ID_USER = c.String(nullable: false, maxLength: 128),
                        FULLNAME_USER = c.String(),
                        NUMBER_OF_COURSE = c.Int(nullable: false),
                        EMAIL_USER = c.String(),
                        PHONE_USER = c.String(),
                        ROLE_USER = c.String(),
                        STATUS_USER = c.String(),
                    })
                .PrimaryKey(t => t.ID_USER);
            
            CreateTable(
                "dbo.CART_OF_USER",
                c => new
                    {
                        ID_USER = c.String(nullable: false, maxLength: 128),
                        ID_COURSE = c.String(),
                        USER_COURSE_ID_USER = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_USER)
                .ForeignKey("dbo.USER_COURSE", t => t.USER_COURSE_ID_USER)
                .Index(t => t.USER_COURSE_ID_USER);
            
            CreateTable(
                "dbo.FEEDBACKs",
                c => new
                    {
                        FEEDBACKID = c.String(nullable: false, maxLength: 128),
                        ID_USER = c.String(maxLength: 128),
                        ID_COURSE = c.String(),
                        DATE_FEEDBACK = c.DateTime(nullable: false),
                        TITLE_FEEDBACK = c.String(),
                        TEXT_FEEDBACK = c.String(),
                        RATE_FEEDBACK = c.Int(),
                    })
                .PrimaryKey(t => t.FEEDBACKID)
                .ForeignKey("dbo.USER_COURSE", t => t.ID_USER)
                .Index(t => t.ID_USER);
            
            CreateTable(
                "dbo.ORDER_COURSE",
                c => new
                    {
                        ID_ORDER = c.String(nullable: false, maxLength: 128),
                        ID_COURSE = c.String(maxLength: 128),
                        ID_USER = c.String(maxLength: 128),
                        STATUS_ORDER = c.String(),
                        TIME_AT_ORDER = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_ORDER)
                .ForeignKey("dbo.COURSEs", t => t.ID_COURSE)
                .ForeignKey("dbo.USER_COURSE", t => t.ID_USER)
                .Index(t => t.ID_COURSE)
                .Index(t => t.ID_USER);
            
            CreateTable(
                "dbo.QUIZZES",
                c => new
                    {
                        QUIZID = c.String(nullable: false, maxLength: 128),
                        ID_COURSE = c.String(maxLength: 128),
                        TITLE_QUIZID = c.String(),
                        DESCRIPTION_QUIZID = c.String(),
                        DUEDATE_QUIZ = c.DateTime(),
                        QUESTION = c.Int(),
                        POINTS_QUIZ = c.Double(),
                    })
                .PrimaryKey(t => t.QUIZID)
                .ForeignKey("dbo.COURSEs", t => t.ID_COURSE)
                .Index(t => t.ID_COURSE);
            
            CreateTable(
                "dbo.TEACHERs",
                c => new
                    {
                        ID_TEACHER = c.String(nullable: false, maxLength: 128),
                        ID_COURSE = c.String(),
                        NAME_TEACHER = c.String(),
                        STATUS_COURSE = c.String(),
                        THUMBNAIL = c.String(),
                        D_CREATED = c.DateTime(nullable: false),
                        LEVEL_TEACHER = c.String(),
                        DESCRIPTION_TEACHER = c.String(),
                    })
                .PrimaryKey(t => t.ID_TEACHER);
            
            CreateTable(
                "dbo.TYPE_COURSE",
                c => new
                    {
                        ID_TYPECOURSE = c.String(nullable: false, maxLength: 128),
                        NAME_TYPECOURSE = c.String(),
                        THUMBNAIL = c.String(),
                    })
                .PrimaryKey(t => t.ID_TYPECOURSE);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.COURSEs", "ID_TYPECOURSE", "dbo.TYPE_COURSE");
            DropForeignKey("dbo.COURSEs", "ID_TEACHER", "dbo.TEACHERs");
            DropForeignKey("dbo.QUIZZES", "ID_COURSE", "dbo.COURSEs");
            DropForeignKey("dbo.ORDER_COURSE", "ID_USER", "dbo.USER_COURSE");
            DropForeignKey("dbo.ORDER_COURSE", "ID_COURSE", "dbo.COURSEs");
            DropForeignKey("dbo.GRADES", "ID_USER", "dbo.USER_COURSE");
            DropForeignKey("dbo.FEEDBACKs", "ID_USER", "dbo.USER_COURSE");
            DropForeignKey("dbo.CART_OF_USER", "USER_COURSE_ID_USER", "dbo.USER_COURSE");
            DropForeignKey("dbo.GRADES", "ID_COURSE", "dbo.COURSEs");
            DropForeignKey("dbo.ASSIGNMENTS", "ID_COURSE", "dbo.COURSEs");
            DropIndex("dbo.QUIZZES", new[] { "ID_COURSE" });
            DropIndex("dbo.ORDER_COURSE", new[] { "ID_USER" });
            DropIndex("dbo.ORDER_COURSE", new[] { "ID_COURSE" });
            DropIndex("dbo.FEEDBACKs", new[] { "ID_USER" });
            DropIndex("dbo.CART_OF_USER", new[] { "USER_COURSE_ID_USER" });
            DropIndex("dbo.GRADES", new[] { "ID_COURSE" });
            DropIndex("dbo.GRADES", new[] { "ID_USER" });
            DropIndex("dbo.COURSEs", new[] { "ID_TEACHER" });
            DropIndex("dbo.COURSEs", new[] { "ID_TYPECOURSE" });
            DropIndex("dbo.ASSIGNMENTS", new[] { "ID_COURSE" });
            DropTable("dbo.TYPE_COURSE");
            DropTable("dbo.TEACHERs");
            DropTable("dbo.QUIZZES");
            DropTable("dbo.ORDER_COURSE");
            DropTable("dbo.FEEDBACKs");
            DropTable("dbo.CART_OF_USER");
            DropTable("dbo.USER_COURSE");
            DropTable("dbo.GRADES");
            DropTable("dbo.COURSEs");
            DropTable("dbo.ASSIGNMENTS");
        }
    }
}
