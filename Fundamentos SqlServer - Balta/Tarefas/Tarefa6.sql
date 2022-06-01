DROP DATABASE IF  EXISTS banco;

CREATE DATABASE banco;

use banco;
CREATE TABLE Alunos
 (
 MAT nvarchar(10) NOT NULL, 
 Nome varchar (40) NOT NULL,
 Endereco varchar (40) NOT NULL,
 Cidade varchar(20) NOT NULL,
 PRIMARY KEY (MAT)
 ) ENGINE=InnoDB;
 CREATE TABLE Disciplinas 
 (
 COD_DISC nvarchar(3) NOT NULL, 
 nome_disc varchar (40) NOT NULL,
 carga_hor int NOT NULL,

 PRIMARY KEY (COD_DISC)
 ) ENGINE=InnoDB;
 
 CREATE TABLE Professores 
 (
 COD_PROF nvarchar(6) NOT NULL, 
 Nome varchar (40) NOT NULL,
 Endereco varchar (40) NOT NULL,
 Cidade varchar(20) NOT NULL,
 PRIMARY KEY (COD_PROF)
 ) ENGINE=InnoDB;
 
  CREATE TABLE Turma  
 (
 COD_PROF nvarchar(6) NOT NULL, 
 COD_DISC nvarchar (3) NOT NULL,
 COD_TURMA varchar (6) NOT NULL,
 Ano INT NOT NULL,
 Horario nvarchar(8) not null,
 PRIMARY KEY (COD_TURMA),
 FOREIGN KEY (COD_PROF) REFERENCES Professores(COD_PROF),
 FOREIGN KEY (COD_DISC) REFERENCES Disciplinas(COD_DISC)
 ) ENGINE=InnoDB;
  CREATE TABLE Historico   
 (
 MAT nvarchar(10) NOT NULL, 
 COD_DISC nvarchar (3) NOT NULL,
 COD_TURMA varchar (6) NOT NULL,
 COD_PROF nvarchar(6) NOT NULL, 
 Ano INT NOT NULL,
 Frequencia float not null,
 Nota float not null,

 PRIMARY KEY (COD_DISC, MAT),
 FOREIGN KEY (COD_PROF) REFERENCES Professores(COD_PROF),
 FOREIGN KEY (COD_DISC) REFERENCES Disciplinas(COD_DISC),
 FOREIGN KEY (MAT) REFERENCES Alunos(MAT)

 
 
 ) ENGINE=InnoDB;
 
  INSERT INTO Alunos (MAT, Nome, Endereco, Cidade) VALUES ('2015010101', 'JOSE DE ALENCAR', 'RUA DAS ALMAS', 'NATAL');
  INSERT INTO Alunos (MAT, Nome, Endereco, Cidade) VALUES (2015010102, 'JOÃO JOSÉ', 'AVENIDA RUY CARNEIRO', 'JOÃO PESSOA');
  INSERT INTO Alunos (MAT, Nome, Endereco, Cidade) VALUES ('2015010103', 'MARIA JOAQUINA', 'RUA CARROSSEL', 'RECIFE');
  INSERT INTO Alunos (MAT, Nome, Endereco, Cidade) VALUES ('2015010104', 'MARIA DAS DORES', 'RUA DAS LADEIRAS', 'FORTALEZA');
  INSERT INTO Alunos (MAT, Nome, Endereco, Cidade) VALUES ('2015010105', 'JOSUÉ CLAUDINO DOS SANTOS', 'CENTRO', 'NATAL');
  INSERT INTO Alunos (MAT, Nome, Endereco, Cidade) VALUES (2015010106, 'JOSUÉLISSON CLAUDINO DOS SANTOS', 'CENTRO', 'NATAL');
  
  INSERT INTO Disciplinas (COD_DISC, nome_disc, carga_hor) VALUES ('BD', 'BANCO DE DADOS', 100);
  INSERT INTO Disciplinas (COD_DISC, nome_disc, carga_hor) VALUES ('POO', 'PROGRAMAÇÃO COM ACESSO A BANCO DE DADOS', 100);
  INSERT INTO Disciplinas (COD_DISC, nome_disc, carga_hor) VALUES ('WEB', ' AUTORIA WEB', 50);
  INSERT INTO Disciplinas (COD_DISC, nome_disc, carga_hor) VALUES ('ENG', ' ENGENHARIA DE SOFTWARE', 80);

  INSERT INTO Professores (COD_PROF, Nome, Endereco, Cidade) VALUES ('212131', 'NICKERSON FERREIRA', 'RUA MANAÍRA', 'JOÃO PESSOA');
  INSERT INTO Professores (COD_PROF, Nome, Endereco, Cidade) VALUES ('122135', 'ADORILSON BEZERRA', 'AVENIDA SALGADO FILHO', 'NATAL');
  INSERT INTO Professores (COD_PROF, Nome, Endereco, Cidade) VALUES ('192011', 'DIEGO OLIVEIRA', 'AVENIDA ROBERTO FREIRE', 'NATAL');
  

  INSERT INTO Turma ( COD_DISC,  COD_TURMA, COD_PROF,  Ano, Horario) VALUES ('BD', '1', '212131', 2015, '11H-12H');
  INSERT INTO Turma ( COD_DISC,  COD_TURMA, COD_PROF,  Ano, Horario) VALUES ('BD', '2', '212131', 2015, '13H-14H');
  INSERT INTO Turma ( COD_DISC,  COD_TURMA, COD_PROF,  Ano, Horario) VALUES ('POO', '3', '192011', 2015, '08H-09H');
  INSERT INTO Turma ( COD_DISC,  COD_TURMA, COD_PROF,  Ano, Horario) VALUES ('WEB', '4', '192011', 2015, '07H-08H');
  INSERT INTO Turma ( COD_DISC,  COD_TURMA, COD_PROF,  Ano, Horario) VALUES ('ENG', '5', '122135', 2015, '10H-11H');

  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010101', 'BD', '1', '212131', 2015, 80, 7.5);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010101', 'POO', '1', '212131', 2015, 90, 9.5);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010101', 'WEB', '1', '212131', 2015, 70, 6.5);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010101', 'ENG', '1', '212131', 2015, 90, 8.5);

  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010102', 'BD', '1', '212131', 2015, 50, 4.5);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010102', 'POO', '3', '212131', 2015, 40, 3.5);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010102', 'WEB', '4', '212131', 2015, 60, 6.5);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010102', 'ENG', '5', '212131', 2015, 90, 9.5);

  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010103', 'BD', '2', '212131', 2015, 70, 10);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010103', 'POO', '3', '212131', 2015, 90, 7.5);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010103', 'WEB', '4', '212131', 2015, 50, 7.5);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010103', 'ENG', '5', '212131', 2015, 30, 3.5);

  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010104', 'BD', '2', '212131', 2015, 100, 10);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010104', 'POO', '3', '212131', 2015, 100, 9.5);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010104', 'WEB', '4', '212131', 2015, 90, 8.5);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010104', 'ENG', '5', '212131', 2015, 95, 9.7);

  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010105', 'BD', '2', '212131', 2015, 100, 80);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010105', 'POO', '3', '212131', 2015, 90, 8.5);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010105', 'WEB', '4', '212131', 2015, 95, 9);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010105', 'ENG', '5', '212131', 2015, 95, 9);

  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010106', 'BD', '2', '212131', 2015, 90, 10);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010106', 'POO', '3', '212131', 2015, 80, 8.5);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010106', 'WEB', '4', '212131', 2015, 75, 7);
  INSERT INTO Historico ( MAT,  COD_DISC, COD_TURMA, COD_PROF, Ano, Frequencia, Nota) VALUES ('2015010106', 'ENG', '5', '212131', 2015, 65, 6);

  select  MAT
  from Historico
  where (COD_TURMA = 1 or COD_TURMA = 2) and Nota <= 5;

  select  MAT, AVG(Nota)
  from Historico
  where (COD_TURMA = 3); 
  
  select  MAT, AVG(Nota)
  from Historico
  where (COD_TURMA = 3) and Nota >= 6;
  
  SELECT COUNT(MAT) 
  FROM Alunos 
  WHERE Cidade != 'Natal'
