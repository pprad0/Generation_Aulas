CREATE DATABASE db_escola;


CREATE TABLE tb_estudantes(
	Id BIGINT IDENTITY(1,1),
	Nome VARCHAR(255) NOT NULL,
	Sobrenome VARCHAR(255) NOT NULL,
	Turma VARCHAR(255) NOT NULL,
	Aniversario DATE,
	Nota INT NOT NULL,
	PRIMARY KEY(Id)
);

Drop table tb_estudantes;

INSERT INTO tb_estudantes
	(Nome, Sobrenome, Turma, Aniversario, Nota)
	VALUES
	('Caio', 'Silva', '1', '2000-01-01', 1),
	('Lucas', 'Salva', '2', '2000-01-02', 2),
	('Pedro', 'Moraes', '3b', '2000-02-01',3 ),
	('Luana', 'Moroas', '4b', '2000-02-02', 4),
	('Laiz', 'Santos', '2b', '1999-01-01', 5),
	('Kimberly', 'Santas', '4a', '2001-03-03', 6),
	('João', 'Heuer', '5e', '2000-11-12', 7),
	('Joana', 'Melo', '9', '2000-01-01', 8);


SELECT * FROM tb_estudantes;

SELECT * FROM tb_estudantes WHERE Nota > 7;
SELECT * FROM tb_estudantes WHERE Nota < 7;

UPDATE tb_estudantes SET Turma = '6a' WHERE Id = 7;