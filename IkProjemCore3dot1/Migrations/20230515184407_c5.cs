using Microsoft.EntityFrameworkCore.Migrations;

namespace IkProjemCore3dot1.Migrations
{
    public partial class c5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE  sp_UserAuth   @Item int     
			 as 
			 SELECT 
		    a.AreaName, 
		    a.ControllerName, 
		    a.ActionName 
		FROM 
		    (
		        SELECT    wi3.AreaName AS AreaName,
				
				( SELECT  wi2.ControllerName FROM WebItem AS wi2 WHERE  wi2.Id = ( SELECT UpperId FROM WebItem AS wi  WHERE    wi.Id = @Item  )  AND wi2.ActionName IS NULL
					AND wi2.AreaName IS NULL ) AS ControllerName,
					
					( SELECT  ActionName  FROM   WebItem AS wi  WHERE  wi.Id = @Item   AND wi.ControllerName IS NULL  AND wi.AreaName IS NULL) AS ActionName
					
					FROM WebItem AS wi3 WHERE  wi3.Id = ( SELECT UpperId   FROM   WebItem AS wi2   WHERE  wi2.Id = (  SELECT  UpperId  FROM    WebItem AS wi  
					WHERE wi.Id = @Item)  AND wi2.ActionName IS NULL  AND wi2.AreaName IS NULL )  AND wi3.ControllerName IS NULL  AND wi3.ActionName IS NULL ) AS a;
	 
			 ";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
