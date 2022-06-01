DROP DATABASE IF  EXISTS banco;

CREATE DATABASE banco;

USE banco;

CREATE TABLE cliente
 (
 Id INT NOT NULL, 
 Nome varchar (40),
 Endereco varchar (40),
 Cpf varchar(14),
 PRIMARY KEY (Id)
 ) ENGINE=InnoDB;
 
 INSERT INTO cliente (Id, Nome, Endereco, Cpf) VALUES (1, 'Tarcio', 'Rua 2', '062.186.245.28');
 INSERT INTO cliente (Id, Nome, Endereco, Cpf) VALUES (2, 'Hiago', 'Rua b', '062.186.245.29');
 INSERT INTO cliente (Id, Nome, Endereco, Cpf) VALUES (3, 'Joao', 'Rua c', '068.166.555.09');

ALTER TABLE cliente
ADD nascimento int NULL ;

UPDATE cliente
SET nascimento = 1999
WHERE Id = 1;

UPDATE cliente
SET nascimento = 2000
WHERE Id = 2;

UPDATE cliente
SET nascimento = 2001
WHERE Id = 3;

delete from cliente 
where Id = 1;

drop table cliente;


