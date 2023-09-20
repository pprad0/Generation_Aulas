CREATE DATABASE db_loja_de_games;
USE db_loja_de_games;

CREATE TABLE [tb_produtos] (
	id bigint NOT NULL,
	Nome varchar(255) NOT NULL,
	Descricao varchar(500) NOT NULL,
	Console varchar(255) NOT NULL,
	Quantidade int NOT NULL,
	Preco decimal(8,2) NOT NULL,
	Foto varchar(5000) NOT NULL,
	Categoria_id bigint NOT NULL,
	Usuario_id bigint NOT NULL,
  CONSTRAINT [PK_TB_PRODUTOS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [tb_categorias] (
	id bigint NOT NULL,
	tipo varchar(255) NOT NULL,
  CONSTRAINT [PK_TB_CATEGORIAS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [tb_usuarios] (
	id bigint NOT NULL,
	Nome varchar(255) NOT NULL,
	Usuario varchar(255) NOT NULL,
	Senha varchar(255) NOT NULL,
	Foto varchar(5000) NOT NULL,
	DataNascimento date NOT NULL,
  CONSTRAINT [PK_TB_USUARIOS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
ALTER TABLE [tb_produtos] WITH CHECK ADD CONSTRAINT [tb_produtos_fk0] FOREIGN KEY ([Categoria_id]) REFERENCES [tb_categorias]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [tb_produtos] CHECK CONSTRAINT [tb_produtos_fk0]
GO
ALTER TABLE [tb_produtos] WITH CHECK ADD CONSTRAINT [tb_produtos_fk1] FOREIGN KEY ([Usuario_id]) REFERENCES [tb_usuarios]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [tb_produtos] CHECK CONSTRAINT [tb_produtos_fk1]
GO


-- Consultas

SELECT * FROM tb_produtos;
SELECT * FROM tb_categorias;
SELECT * FROM tb_usuarios;