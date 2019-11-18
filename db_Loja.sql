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

SELECT datas Y, SUM(valor) X FROM dbo.venda WHERE datetime.now;

select * from venda;
select * from produto_venda
select * from produto

select * from Produto

SELECT pv.codigoVenda Código, p.nome Item , v.valor R$, SUM(pv.quantidade) Quantidade, v.datas Dia 
FROM venda AS v, produto AS p, produto_venda AS pv
WHERE p.codigo  = pv.codigoProduto AND v.codigo = pv.codigoVenda 
GROUP BY pv.codigoVenda

SELECT p.nome, v.* 
FROM venda AS v,produto AS p, produto_venda AS pv 
WHERE p.codigo = pv.codigoProduto and pv.codigoVenda = v.codigo 

 
SELECT pv.codigoVenda Código , SUM(pv.quantidade) Quantidade 
FROM venda AS v, produto AS p, produto_venda AS pv
WHERE p.codigo  = pv.codigoProduto AND v.codigo = pv.codigoVenda 
GROUP BY pv.codigoVenda;

select * from produto
select TOP 100 * from venda ORDER BY datas;
select * from pagamento
delete from Funcionario

