CREATE DATABASE aula;

USE aula;



CREATE TABLE Aluno (

    id int not null auto_increment primary key,

    nome varchar(50),

    idade int,

    email varchar(100)

);



CREATE TABLE compra (

    id int not null auto_increment primary key,

    nome varchar(50),

    preco FLOAT,

    pagamento FLOAT

);

