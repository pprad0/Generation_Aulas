CREATE DATABASE db_quitanda;

USE db_quitanda;


CREATE TABLE tb_produtos(
	Id BIGINT IDENTITY(1,1),
	Nome VARCHAR(255) NOT NULL,
	Quantidade INT,
	DataValidade DATE,
	Preco DECIMAL(2) NOT NULL,
	PRIMARY KEY(Id)
);


SELECT * FROM tb_produtos;


ALTER TABLE tb_produtos ALTER COLUMN preco DECIMAL(6,2);


INSERT INTO tb_produtos
(Nome, Quantidade, DataValidade, Preco)
VALUES
('Pera', 40, '2013-10-18', 6.00),
('Uva', 30, '2013-10-18', 9.00);


ALTER TABLE tb_produtos ADD Descricao VARCHAR(255);


INSERT INTO tb_produtos
(Nome, Quantidade, DataValidade, Preco, Descricao)
VALUES
('Cebola', 12, '2015-06-19', 44.45, 'Cebola Roxa');


UPDATE tb_produtos SET Descricao = 'Banana Nanica' WHERE Id = 4;


DELETE FROM tb_produtos WHERE Id = 2;