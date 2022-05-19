USE [Curso]

CREATE TABLE [ProgressoCurso](
    [AlunoId] INT NOT NULL,
    [CursoId] INT NOT NULL,
    [Progresso] INT NOT NULL,
    [UltimaAtualizacao] DATETIME NOT NULL DEFAULT (GETDATE())

    CONSTRAINT Pk_ProgressoCurso PRIMARY key ([AlunoId], [CursoId])
)
GO