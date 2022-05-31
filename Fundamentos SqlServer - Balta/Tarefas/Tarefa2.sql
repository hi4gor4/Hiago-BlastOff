INSERT INTO Empresa  (Nome, CPF, Cargo, nProjetos) VALUES (‘Hiago’, ‘062.186.245-28’, ‘Desenvolvedor’, 2);

SELECT TOP 1
Nome, CPF, Cargo, GREATEST(nProjetos) 
FROM Empresa;

SELECT 
Nome, CPF, Cargo, MIN(nProjetos) 
FROM Empresa
WHERE nProjetos = MIN(nProjetos);

