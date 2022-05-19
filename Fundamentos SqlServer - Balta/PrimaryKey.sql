USE [Curso]

DROP TABLE [Aluno]
CREATE TABLE [Aluno](
    [Id] INT NOT NULL ,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL UNIQUE,
    [Nascimento] DATETIME NULL,
    [Active] BIT NOT NULL DEFAULT(0),
    
    CONSTRAINT [PK_ALuno]   PRIMARY Key (Id)
)