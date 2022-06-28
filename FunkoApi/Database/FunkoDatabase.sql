CREATE database [Bonecos]

use [Bonecos]

CREATE TABLE [Colecao](
    [id] int IDENTITY(1,1),
    [nome] VARCHAR(80) NOT NULL,
    [tipo] Varchar(40) NOT NULL,
    CONSTRAINT [PK_Colecao] PRIMARY KEY ([id])
)
GO

CREATE TABLE [Funko](
    [id] int IDENTITY(1,1),
    [nome] NVARCHAR(80) NOT NULL,
    [lancamento] DATE NOT NULL,
    [numero] int NOT NULL,
    [descricao] NVARCHAR(80) NOT NULL,
    [idColecao] int NOT NULL,
    CONSTRAINT [PK_Funko] PRIMARY KEY ([id]),
    CONSTRAINT [Fk_Colecao] FOREIGN KEY ([idColecao]) REFERENCES [Colecao]

)
GO

CREATE TABLE [Imagem](
    [id] int IDENTITY(1,1),
    [url] VARCHAR(80) NOT NULL,
    [idFunko] int NOT NULL,
    CONSTRAINT [PK_Imagem] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Funko] FOREIGN KEY ([idFunko]) REFERENCES [Funko]
)
GO

CREATE TABLE [Loja](
    [id] INT IDENTITY(1,1),
    [nome] VARCHAR(80) NOT NULL,
    [localizacao] VARCHAR(80) NOT NULL,
    
    CONSTRAINT [PK_Loja] PRIMARY KEY ([id]) 

)
GO
CREATE TABLE [FunkoLoja](
    [id] INT,
    [idFunko] INT,
    [idLoja] INT,
    [quantidade] INT NOT NULL,
    
    CONSTRAINT [PK_FunkoLoja] PRIMARY KEY (id),
    CONSTRAINT [FK_Funko_IN_FunkoLoja] FOREIGN KEY ([idFunko]) REFERENCES [Funko],
    CONSTRAINT [Fk_Loja] FOREIGN KEY ([idLoja]) REFERENCES [Loja]
)
GO