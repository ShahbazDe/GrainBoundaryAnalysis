CREATE PROCEDURE dbo.spSpecimens_GetALLData
AS
BEGIN
SET NOCOUNT ON;

select*
from dbo.Specimens;

END
GO