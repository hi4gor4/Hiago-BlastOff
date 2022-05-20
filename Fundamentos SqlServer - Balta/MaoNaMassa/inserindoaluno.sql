DECLARE @studentId UNIQUEIDENTIFIER = (SELECT NEWID())
INSERT INTO 
[Student]
VALUES
(
    'a804485d-f8ed-46bd-ae71-f7a1142f76c1',
    'Hiago Rangel',
    'hiago@gmail.com',
    '12345678901',
    '87654321',
    '2000-01-01',
    GETDATE()
)
INSERT INTO 
    [StudentCourse]
VALUES(
    '5ea2f56e-7c21-3e39-c43e-b7d900000000',
    'a804485d-f8ed-46bd-ae71-f7a1142f76c1',
    50,
    0,
    '2020-01-13',
    GETDATE()
    
)