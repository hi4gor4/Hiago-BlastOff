CREATE DATABASE [Balta]

CREATE TABLE [Estudante]
(
    [Id] UNIQUEIDENTIFIER NOT NULL,
    [Nome] NVARCHAR(120) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL,
    [Documento] NVARCHAR(20) NULL,
    [Telefone] NVARCHAR(20) NULL,
    [DataNascimento] DATETIME NULL,
    [DataCriacao] DATETIME NOT NULL,
    CONSTRAINT [PK_Estudante] PRIMARY KEY([Id])
)