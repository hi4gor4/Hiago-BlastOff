DROP TABLE Author
CREATE TABLE [Autor]
(
    [Id] uniqueidentifier NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Titulo] NVARCHAR(80) NOT NULL,
    [Imagem] NVARCHAR(1024) NOT NULL,
    [Biografia] NVARCHAR(2000) NOT NULL,
    [Url] nvarchar(450) NULL,
    [Email] NVARCHAR(160) NOT NULL,
    [Tipo] TINYINT NOT NULL, -- 0 a 255
    CONSTRAINT [PK_Author] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Carreira]
(
    [Id] uniqueidentifier NOT NULL,
    [Titulo] NVARCHAR(160) NOT NULL,
    [Summario] NVARCHAR(2000) NOT NULL,
    [Url] NVARCHAR(1024) NOT NULL,
    [DuracaoMinutos] INT NOT NULL,
    [Ativo] BIT NOT NULL,
    [Featured] BIT NOT NULL,
    [Tags] NVARCHAR(160) NOT NULL,
    CONSTRAINT [PK_Carreira] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Categoria]
(
    [Id] uniqueidentifier NOT NULL,
    [Titulo] NVARCHAR(160) NOT NULL,
    [Url] NVARCHAR(1024) NOT NULL,
    [Summario] NVARCHAR(2000) NOT NULL,
    [Ordem] int NOT NULL,
    [Descricao] TEXT NOT NULL,
    [Featured] BIT NOT NULL,
    CONSTRAINT [PK_Categoria] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Curso]
(
    [Id] uniqueidentifier NOT NULL,
    [Tag] NVARCHAR(20) NOT NULL,
    [Titulo] NVARCHAR(160) NOT NULL,
    [Summario] NVARCHAR(2000) NOT NULL,
    [Url] NVARCHAR(1024) NOT NULL,
    [Nivel] TINYINT NOT NULL,
    [Duracaominutos] INT NOT NULL,
    [DataCriacao] DATETIME NOT NULL,
    [DataAtualizacao] DATETIME NOT NULL,
    [Ativo] BIT NOT NULL,
    [Gratuito] BIT NOT NULL,
    [Featured] BIT NOT NULL,
    [AutorId] uniqueidentifier NOT NULL,
    [CategoriaId] uniqueidentifier NOT NULL,
    [Tags] NVARCHAR(160) NOT NULL,
    CONSTRAINT [PK_Curso] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Curso_Autor_AutorId] FOREIGN KEY ([AutorId]) REFERENCES [Autor] ([Id]),
    CONSTRAINT [FK_Curso_Categoria_CategoriaId] FOREIGN KEY ([CategoriaId]) REFERENCES [Categoria] ([Id])
);
GO

CREATE TABLE [ItemCarreira]
(
    [CarreiraId] uniqueidentifier NOT NULL,
    [CursoId] uniqueidentifier NOT NULL,
    [Titulo] NVARCHAR(160) NOT NULL,
    [Descricao] TEXT NOT NULL,
    [Ordem] TINYINT NOT NULL,
    
    CONSTRAINT [PK_ItemCarreira] PRIMARY KEY ([CursoId], [CarreiraId]),
    CONSTRAINT [FK_ItemCareira_Carreira_CarreiraId] FOREIGN KEY ([CarreiraId]) REFERENCES [Carreira] ([Id]),
    CONSTRAINT [FK_CareerItem_Course_CourseId] FOREIGN KEY ([CursoId]) REFERENCES [Curso] ([Id])
);
GO
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

CREATE TABLE [EstudanteCurso]
(
    [CursoId] uniqueidentifier NOT NULL,
    [EstudanteId] uniqueidentifier NOT NULL,
    [Progresso] TINYINT NOT NULL,
    [Favorito] BIT NOT NULL,
    [InicioData] DATETIME NOT NULL,
    [UltimaData] DATETIME NULL DEFAULT(GETDATE()),
    CONSTRAINT [PK_EstudanteCurso] PRIMARY KEY ([CursoId], [EstudanteId]),
    CONSTRAINT [FK_EstudanteCurso_Curso_CursoId] FOREIGN KEY ([CursoId]) REFERENCES [Curso] ([Id]),
    CONSTRAINT [FK_EstudanteCurso_Estudante_EstudanteId] FOREIGN KEY ([EstudanteId]) REFERENCES [Estudante]([Id])
);
GO
