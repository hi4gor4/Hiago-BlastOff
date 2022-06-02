CREATE DATABASE estoque;

USE estoque;



CREATE TABLE produtos (

    id INT PRIMARY KEY,

    descricao VARCHAR(50) UNIQUE,

    estoque INT NOT NULL

);



INSERT INTO produtos VALUES ('1', 'Lasanha', '10');

INSERT INTO produtos VALUES ('2', 'Morango', '5');

INSERT INTO produtos VALUES ('3', 'Farinha', '15');



CREATE TABLE itens_venda (

    id_venda INT PRIMARY KEY,

    id_produto INT,

    quantidade INT

);