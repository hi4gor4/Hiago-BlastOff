USE [Cursos]

SELECT TOP 100
    MAX([Id])
FROM 
    Curso

SELECT TOP 100
    Count([Id])
FROM 
    Curso

SELECT TOP 100
    SUM([Id])
FROM 
    Curso
    