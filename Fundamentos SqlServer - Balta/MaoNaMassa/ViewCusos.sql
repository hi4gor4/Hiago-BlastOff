USE [Balta]
CREATE OR ALTER VIEW vwCourses AS
SELECT
    [Course].[Id],
    [Course].[Tag],
    [Course].[Title],
    [Category].[Title] AS [Category],
    [Author].[Name] As [Author]
FROM
    [Course]
    INNER JOIN 
    [Category] 
    ON
    [Course].[CategoryId] = [Category].[Id]
    INNER JOIN 
    [Author] 
    ON
    [Course].[AuthorId] = [Author].[Id]
WHERE
    [Active] = 1

ORDER BY
    [CreateDate] DESC
