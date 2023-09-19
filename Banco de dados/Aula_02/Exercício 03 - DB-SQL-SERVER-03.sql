create database db_farmacia_bem_estar 
USE db_farmacia_bem_estar;

create table tb_categorias(
	Id BIGINT IDENTITY(1,1),
	Categoria VARCHAR(255) not null,
	Frete BIGINT not null,
	primary key(Id)
);

create table tb_produtos(
	Id BIGINT IDENTITY(1,1),
	Nome VARCHAR(255) not null,
	Preco BIGINT,
	Loja VARCHAR(255) not null,
	Categoria_Id BIGINT not null, 
	primary key(Id),
	FOREIGN KEY (Categoria_Id) REFERENCES tb_categorias(Id)
);


SELECT * from tb_categorias;
SELECT * from tb_produtos;


INSERT INTO tb_categorias
	(Categoria, Frete)
	VALUES
	('Pele', 10),
	('Cabelo', 4),
	('Vitaminicos', 5),
	('Antibioticos', 14),
	('Anti-inflamatórios', 20)
	

INSERT INTO tb_produtos
	(Nome, Preco, Loja, Categoria_Id)
	VALUES
	('Antibiotico 1', 20, 'Farmacia Canada', 4),
	('Antibiotico 2', 35, 'Farmacia Brasil', 4),
	('Antibiotico 3', 57, 'Farmacia Osasco', 4),
	('Anti-inflamatório 1', 37, 'Farmacia Brasil', 5),
	('Anti-inflamatório 2 ',  77, 'Farmacia Brasil', 5),
	('Skin Care 1', 33, 'Farmacia Brasil', 1),
	('Skin Care 2 ',  22, 'Farmacia Brasil', 1),
	('Elseve', 18, 'Farmacia Chile', 2);




Select * from tb_categorias;

Select * from tb_produtos;

SELECT * FROM tb_produtos JOIN tb_categorias
     ON tb_produtos.Categoria_Id = tb_categorias.Id
	 WHERE tb_produtos.Preco > 45;


SELECT * FROM tb_produtos JOIN tb_categorias
     ON tb_produtos.Categoria_Id = tb_categorias.Id
	 WHERE tb_produtos.Preco between 20 and 55;



select * from tb_produtos
	where Nome like '%c%'; 

	
SELECT * FROM tb_produtos JOIN tb_categorias
     ON tb_produtos.Categoria_Id = tb_categorias.Id
	 WHERE tb_categorias.Categoria = 'Pele' ;
