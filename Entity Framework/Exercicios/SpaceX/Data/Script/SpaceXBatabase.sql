CREATE DATABASE [SpaceX];

USE SpaceX; 

CREATE TABLE [Galaxia]
(
    [id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [nome] NVARCHAR(80) NOT NULL,
    [massa] DECIMAL NOT NULL ,
    [tamanho] DECIMAL NOT NULL,
    [tipo] NVARCHAR NOT NULL
)
GO

CREATE TABLE [Estrela]
(
    [id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,    
    [nome] NVARCHAR(80) NOT NULL,
    [massa] DECIMAL NOT NULL ,
    [tamanho] DECIMAL NOT NULL,
    [luminosidade] FLOAT NOT NULL,
    [galaxia_id] INT NOT NULL
    FOREIGN KEY (galaxia_id) REFERENCES [Galaxia](id)

)
GO

CREATE TABLE [Planeta]
(
    [id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,    
    [nome] NVARCHAR(80) NOT NULL,
    [massa] DECIMAL NOT NULL ,
    [tamanho] DECIMAL NOT NULL,
    [dist_terra] DECIMAL NOT NULL,
    [estrela_id] INT NOT NULL 
    FOREIGN KEY (estrela_id) REFERENCES [Estrela](id)
)
GO