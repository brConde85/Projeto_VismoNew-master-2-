CREATE DATABASE db_loja;
USE db_loja;

GO
CREATE TABLE cliente(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1)
);

CREATE TABLE venda (
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
datas datetime,
valor float NOT NULL
);

CREATE TABLE fornecedor(
codFornecedor INT NOT NULL PRIMARY KEY IDENTITY(1,1),
nome NVARCHAR (50) NOT NULL
);

CREATE TABLE produto(
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
nome NVARCHAR (50) NOT NULL,
preco FLOAT NOT NULL,
qtdEstoque INT NOT NULL,
codFornecedor INT NOT NULL,
pchave NVARCHAR (25) NOT NULL,
CONSTRAINT FK_codFornecedor FOREIGN KEY (codFornecedor)
	REFERENCES dbo.fornecedor (codFornecedor)
);
drop table dbo.produto_venda,dbo.venda,dbo.produto;
CREATE TABLE produto_venda(
codigoProduto INT NOT NULL,
codigoVenda INT NOT NULL,
quantidade INT NOT NULL,

CONSTRAINT FK_codProduto FOREIGN KEY (codigoProduto)
	REFERENCES dbo.produto (codigo),

	CONSTRAINT FK_codVenda FOREIGN KEY (codigoVenda)
	REFERENCES dbo.venda (codigo)
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

drop table funcionario;

TRUNCATE TABLE dbo.funcionario;
drop table dbo.produto_venda;
TRUNCATE TABLE dbo.fornecedor;
ALTER TABLE dbo.produto
	add pchave NVARCHAR(25) NOT NULL;

	/*utilizar truncate para limpar dados da tabela*/

CREATE TABLE itemReposicao(
codReposicao INT PRIMARY KEY IDENTITY(1,1),
datas date NOT NULL,
codigoProduto INT NOT NULL,
codigoGerente INT NOT NULL,
CONSTRAINT FK_codProdutoReposicao FOREIGN KEY(codigoProduto)
	REFERENCES dbo.produto (codigo),

CONSTRAINT FK_codGerente FOREIGN KEY(codigoGerente)
	REFERENCES dbo.funcionario (codigo)
);
drop table dbo.pagamento,dbo.itemReposicao;
CREATE TABLE pagamento(
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
valor NVARCHAR(7) NOT NULL,
descricao NVARCHAR(50) NOT NULL,
validade DATE NOT NULL,
situacao NVARCHAR(8) NOT NULL,
codFornecedor INT NOT NULL,
CONSTRAINT codFornecedor FOREIGN KEY (codFornecedor)
	REFERENCES dbo.fornecedor (codFornecedor)
);

SELECT * FROM Fornecedor;
select * from funcionario;
select * from Produto;


select * from venda;
select * from produto_venda;

SELECT t1.*, t2.nome, t3.quantidade
FROM Venda t1, Produto t2, produto_venda t3
WHERE t1.codigo = t3.codigoVenda
AND t2.codigo = t3.codigoProduto 

SELECT t1.*, t2.nome, t3.datas FROM produto_venda t1, Produto t2, Venda t3 WHERE t1.codigoProduto = t2.codigo AND t1.codigoVenda = '2' AND t3.codigo = '2'







