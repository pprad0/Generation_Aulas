create database db_generation_game_online; 
USE db_generation_game_online;

create table tb_classes(
	Id BIGINT IDENTITY(1,1),
	Classe VARCHAR(255) not null,
	DanoEspecial BIGINT,
	primary key(Id)
);

create table tb_personagens(
	Id BIGINT IDENTITY(1,1),
	Nome VARCHAR(255) not null,
	Hp BIGINT not null,
	Guilda VARCHAR(255),
	Idade INT not null,
	ClassesId BIGINT not null, 
	primary key(Id),
	FOREIGN KEY (ClassesId) REFERENCES tb_classes (Id)
);

INSERT INTO tb_classes
	(Classe, DanoEspecial)
	VALUES
	('Mago', 1000),
	('Espartano', 1200),
	('Planador', 3000),
	('Lanceiro', 500),
	('Arqueiro', 5000);

INSERT INTO tb_personagens
	(Nome, Hp, Guilda, Idade, ClassesId)
	VALUES
	('Cleidson', 500, 'Maré Alta', 20, 1),
	('Jobson', 2000, 'Maré Alta', 21, 2),
	('Whindersson', 2500, 'Maré Alta', 22, 3),
	('Udson', 1500, 'Maré Alta', 23, 4),
	('Bilson', 3000, 'Maré Alta', 24, 5),
	('Gilson', 4000, 'Maré Alta', 25, 4),
	('Crilson', 2000, 'Maré Alta', 26, 3),
	('Filson', 1200, 'Maré Alta', 27, 2);



Select * from tb_classes;

Select * from tb_personagens;

SELECT tb_personagens.Id, tb_personagens.Nome, tb_personagens.Hp, tb_personagens.Guilda, tb_personagens.Idade, tb_classes.Classe, tb_classes.DanoEspecial
FROM tb_personagens JOIN tb_classes
     ON tb_personagens.ClassesId = tb_classes.Id
	 WHERE tb_personagens.Hp >= 2000;


SELECT tb_personagens.Id,tb_personagens.Nome, tb_personagens.Hp, tb_personagens.Guilda, tb_personagens.Idade, tb_classes.Classe, tb_classes.DanoEspecial
FROM tb_personagens JOIN tb_classes
     ON tb_personagens.ClassesId = tb_classes.Id
	 WHERE tb_classes.DanoEspecial >= 1300;

SELECT databasepropertyex('db_generation_game_online', 'collation') SQLCOLLATION;

select * from tb_personagens
	where Nome like '%c%'; 
	
SELECT tb_personagens.Id,tb_personagens.Nome, tb_personagens.Hp, tb_personagens.Guilda, tb_personagens.Idade, tb_classes.Classe, tb_classes.DanoEspecial
FROM tb_personagens JOIN tb_classes
     ON tb_personagens.ClassesId = tb_classes.Id
	 WHERE tb_classes.Classe = 'Arqueiro';
