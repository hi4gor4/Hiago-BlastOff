create database  Servico
use Servico

CREATE TABLE Cliente
 (
 CPF nvarchar(11) NOT NULL, 
 nome varchar (40) NOT NULL,
 endereco varchar (40) NOT NULL,
 ano_nasc varchar(10) NOT NULL,
 PRIMARY KEY (CPF)
 ) ENGINE=InnoDB;


INSERT INTO cliente (CPF, nome, endereco, ano_nasc) VALUES ('12345678912', 'Hiago', 'Rua D', '2000-03-23');

INSERT INTO cliente (CPF, nome, endereco, ano_nasc) VALUES ('12345678911', 'Joao', 'Rua 2', '1998-09-08');

INSERT INTO cliente (CPF, nome, endereco, ano_nasc) VALUES ('12345678913', 'Tarcio', 'Rua 2', '2000-09-08');

UPDATE cliente
SET nome = 'Pamela'
WHERE CPF = '12345678911' ;

delete from Cliente where CPF = '12345678912';
