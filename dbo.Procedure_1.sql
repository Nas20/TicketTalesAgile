CREATE PROCEDURE sproc_tblStaff_FilterByStaffId
	@StaffId int
AS
	SELECT * FROM tblStaff where Id = @StaffId 
RETURN 0


