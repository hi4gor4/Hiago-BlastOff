create database Tarefa2
use Tarefa2
CREATE TABLE empresa(
	Matricula INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(40) NOT NULL,
    CPF VARCHAR(14) NOT NULL,
    Cargo VARCHAR(30) NOT NULL,
    nProjetos INT NOT NULL
);
INSERT INTO empresa  (Nome, CPF, Cargo, nProjetos) VALUES ('Hiago', '062.186.245-28', 'Desenvolvedor', 2);
INSERT INTO empresa  (Nome, CPF, Cargo, nProjetos) VALUES ('Hiago', '062.186.245-26', 'GP', 9);
INSERT INTO empresa  (Nome, CPF, Cargo, nProjetos) VALUES ('Hiago', '062.186.245-27', 'Front', 5);


SELECT  
Nome, CPF, Cargo, Min(nProjetos)
FROM empresa;


SELECT 
Nome, CPF, Cargo, Max(nProjetos) 
FROM Empresa;

SELECT avg(nProjetos) AS Media FROM empresa WHERE Cargo <> 'GP';

SELECT  
Nome, CPF, Cargo, nProjetos
FROM empresa
where nProjetos >= 4;

SELECT DISTINCT Cargo FROM empresa;

SELECT  
Nome, CPF, Cargo, nProjetos
FROM empresa
where Cargo = 'Desenvolvedor' ;
