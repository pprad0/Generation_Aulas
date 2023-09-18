CREATE DATABASE db_rh;

CREATE TABLE tb_colaboradores(
	Id BIGINT IDENTITY(1,1),
	Nome VARCHAR(255) NOT NULL,
	Cargo VARCHAR(255) NOT NULL,
	Salario BIGINT NOT NULL,
	Admissao DATE NOT NULL,
	PRIMARY KEY(Id)
);


SELECT * FROM tb_colaboradores;


INSERT INTO tb_colaboradores
	(Nome, Cargo, Salario, Admissao)
	VALUES
	('Pedro', 'FullStack Jr', 3000, '2022-02-02'),
	('Ana', 'FullStack Pleno', 5000, '2021-03-03'),
	('Claudio', 'FullStack Senior', 4500, '2023-02-01'),
	('Giovanna', 'Backend Jr', 3123, '2019-10-10'),
	('Udson', 'Analista Dados Jr', 2244, '2020-12-05');


SELECT * FROM tb_colaboradores WHERE Salario < 2000;


UPDATE tb_colaboradores SET Cargo = 'FullStack Pleno' WHERE Id = 1;