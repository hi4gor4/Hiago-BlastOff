
USE aula;

DELIMITER //
CREATE PROCEDURE inserirEstudante(Nome VARCHAR(50), idade INT, email VARCHAR(100))
BEGIN
	UPDATE Student SET age = 20 WHERE id = LAST_INSERT_ID();
	INSERT INTO Aluno(nome, idade, email) VALUES (nome, idade, email);
    DELETE FROM Student WHERE id % 2 = 0;
END //
DELIMITER ;