create database db_pizzaria_legal; 
USE db_pizzaria_legal;

create table tb_categorias(
	Id BIGINT IDENTITY(1,1),
	Borda VARCHAR(255) not null,
	Tipo VARCHAR(255) not null,
	primary key(Id)
);

create table tb_pizzas(
	Id BIGINT IDENTITY(1,1),
	Nome VARCHAR(255) not null,
	Sabor VARCHAR(255) not null,
	Preco BIGINT,
	Loja VARCHAR(255) not null,
	Categoria_Id BIGINT not null, 
	primary key(Id),
	FOREIGN KEY (Categoria_Id) REFERENCES tb_categorias(Id)
);

INSERT INTO tb_categorias
	(Borda, Tipo)
	VALUES
	('Nenhuma', 'Salgada'),
	('Doce de leite', 'Doce'),
	('Brigadeiro', 'Doce'),
	('Catupiry', 'Salgada'),
	('Bacon', 'Salgada'),
	('Beijinho', 'Doce');

INSERT INTO tb_pizzas
	(Nome, Sabor, Preco, Loja, Categoria_Id)
	VALUES
	('Neymar', 'Queijo', 20, 'Pizzaria do Z�', 1),
	('Bruna Marquezine', 'Frango', 35, 'Pizzaria do Z�', 5),
	('Jacquin', 'Brigadeiro', 57, 'Pizzaria do Z�', 2),
	('Paquet�', 'Doce de Leite', 37, 'Pizzaria do Z�', 3),
	('Ana DeArmas', 'Alca�uz', 77, 'Pizzaria do Z�', 3),
	('Ronaldo', 'Picanha', 33, 'Pizzaria do Z�', 4),
	('Gl�ria Groover', '4 Queijos', 22, 'Pizzaria do Z�', 4),
	('Filson', 'Calabresa', 18, 'Pizzaria do Z�', 4);




Select * from tb_categorias;

Select * from tb_pizzas;

SELECT * FROM tb_pizzas JOIN tb_categorias
     ON tb_pizzas.Categoria_Id = tb_categorias.Id
	 WHERE tb_pizzas.Preco > 45;


SELECT * FROM tb_pizzas JOIN tb_categorias
     ON tb_pizzas.Categoria_Id = tb_categorias.Id
	 WHERE tb_pizzas.Preco between 50 and 100;



select * from tb_pizzas
	where Nome like '%m%'; 


SELECT * FROM tb_pizzas JOIN tb_categorias
    ON tb_pizzas.Categoria_Id = tb_categorias.Id
	WHERE tb_categorias.Tipo = 'Doce' ;