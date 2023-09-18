CREATE DATABASE db_ecommerce;


CREATE TABLE tb_produtos(
	Id BIGINT IDENTITY(1,1),
	Nome VARCHAR(255) NOT NULL,
	Loja VARCHAR(255) NOT NULL,
	Preco DECIMAL NOT NULL,
	Categoria VARCHAR(255),
	PRIMARY KEY(Id)
);

INSERT INTO tb_produtos (Nome, Loja, Preco, Categoria)
	VALUES
	('Caneta', 'Casas Bahia', 3000, 'Escolar'),
	('Café', 'Americanas', 5000, 'Escolar'),
	('Lapis', 'Casas Bahia', 4500, 'Escolar'),
	('Borracha', 'Americanas', 3123, 'Escolar'),
	('Caderno', 'Casas Bahia', 2244, 'Filme'),
	('Barco', 'Americanas', 2244, 'Filme'),
	('Bike', 'Casas Bahia', 250, 'Filme'),
	('Giz', 'Americanas', 200, 'Música');


SELECT * FROM tb_produtos;

SELECT * FROM tb_produtos WHERE Preco > 500;
SELECT * FROM tb_produtos WHERE Preco < 500;

UPDATE tb_produtos SET Loja = 'Amazon' WHERE Id = 1;