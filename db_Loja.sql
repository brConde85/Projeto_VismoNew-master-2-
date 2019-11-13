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

select * from funcionario

UPDATE Funcionario set statuss = '1' WHERE logins = '3'
                    AND senha = 3

select extract(month from datas) as mes,
extract(year from datas) as ano,
 sum(valor) as total from Venda 
 group by mes, ano order by ano, mes;

 select datas from venda where extract(month from datas) = 10 and
 extract(year from datas) = 2019 group by datas

 SELECT EXTRACT(month FROM venda) "Month", SUM(venda) "Total"
  FROM dbo.venda
  GROUP BY EXTRACT(month FROM datas) order by "Total" desc
  

  select getdate();
  Select * from venda where Convert(varchar(10), datas) = Convert(varchar(10), getdate())


