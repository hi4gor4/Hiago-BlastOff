INSERT INTO cliente (CPF, nome, endereço, ano_nasc) VALUES (12345678912, ‘Hiago’, ‘Rua D’, ‘2000-03-23’);

INSERT INTO cliente (CPF, nome, endereço, ano_nasc) VALUES (12345678911, ‘Joao’, ‘Rua 2’, ‘1998-09-08’);

INSERT INTO cliente (CPF, nome, endereço, ano_nasc) VALUES (12345678911, ‘Tarcio’, ‘Rua 2’, ‘2000-09-08’);

UPDATE cliente
SET nome = 'Pamela'
WHERE cpf = 12345678911 ;

