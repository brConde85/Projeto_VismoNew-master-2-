CREATE DATABASE db_loja;
USE db_loja;
GO

CREATE TABLE venda (
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
datas datetime,
valor float NOT NULL
);

CREATE TABLE fornecedor(
codFornecedor INT NOT NULL PRIMARY KEY IDENTITY(1,1),
nome NVARCHAR (50) NOT NULL,
status NVARCHAR (20) NOT NULL
);


CREATE TABLE produto(
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
nome NVARCHAR (50) NOT NULL,
preco FLOAT NOT NULL,
qtdEstoque INT NOT NULL,
codFornecedor INT NOT NULL,
pchave NVARCHAR (25) NOT NULL,
status NVARCHAR (20) NOT NULL,
CONSTRAINT FK_codFornecedor FOREIGN KEY (codFornecedor)
	REFERENCES dbo.fornecedor (codFornecedor)
);

CREATE TABLE produto_venda(
codigoProduto INT,
codigoVenda INT NOT NULL,
quantidade INT NOT NULL,
codigoProdCasa INT,

CONSTRAINT FK_codProduto FOREIGN KEY (codigoProduto)
	REFERENCES dbo.produto (codigo),

CONSTRAINT FK_codVenda FOREIGN KEY (codigoVenda)
	REFERENCES dbo.venda (codigo),

CONSTRAINT FK_codProdCasa FOREIGN KEY (codigoProdCasa)
	REFERENCES dbo.produtoCasa (codigo)
);

CREATE TABLE funcionario(
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
logins NVARCHAR(30) NOT NULL UNIQUE,
senha NVARCHAR(20) NOT NULL,
nome NVARCHAR(70) NOT NULL,
cpf NVARCHAR(11) NOT NULL UNIQUE,
statuss NVARCHAR(20),
tipo NVARCHAR (20) NOT NULL
); 

CREATE TABLE pagamento(
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
valor NVARCHAR(7) NOT NULL,
descricao NVARCHAR(50) NOT NULL,
validade DATE NOT NULL,
situacao NVARCHAR(20) NOT NULL,
codFornecedor INT NOT NULL,
CONSTRAINT codFornecedor FOREIGN KEY (codFornecedor)
	REFERENCES dbo.fornecedor (codFornecedor)
);
create table produtoCasa(
codigo INT PRIMARY KEY NOT NULL IDENTITY (1,1),
nome NVARCHAR(50) NOT NULL,
preco FLOAT NOT NULL,
pChave NVARCHAR(50) NOT NULL
);
update fornecedor set status = 'Habilitado' where codFornecedor > 0 