CREATE OR ALTER VIEW vwCategorias AS
    SELECT TOP 100
            
            [Categoria].[Nome],
            COUNT([Curso].CategoriaId) AS Cursos
        FROM 
            [Categoria]
            INNER JOIN 
                [Curso]
                ON
                [CURSO].[CategoriaId] = [Categoria].[Id]
                GROUP BY 
                [Categoria].[Id],
                [Categoria].[Nome],
                [Curso].[CategoriaId]