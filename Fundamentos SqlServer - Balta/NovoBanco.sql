


CREATE DATABASE [Cursos]
GO

USE [Cursos]

CREATE TABLE [Categoria](
    [Id] INT NOT NULL IDENTITY(1,1),
    [Nome] NVARCHAR(80) NOT NULL,
    CONSTRAINT [Pk_Categoria] PRIMARY KEY([Id]),
)

CREATE TABLE [Curso](
    [Id] INT NOT NULL IDENTITY(1,1),
    [Nome] NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL,

    CONSTRAINT [Pk_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [Fk_Cursp_Categoria] FOREIGN KEY ([CategoriaId])
        REFERENCES [Categoria]([Id])
)
