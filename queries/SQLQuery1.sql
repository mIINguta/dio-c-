-- Contando linhas
SELECT COUNT(*) QuantidadeProdutos from Produtos

-- Soma
SELECT SUM(Preco) SomaProdutos FROM Produtos

-- Soma dos produtos tam G
SELECT SUM (Preco) ProdutosG FROM Produtos
WHERE Tamanho = 'G'

--Descobrir Valor máximo
SELECT MAX(Preco) FROM Produtos

--Descobrir Valor minimo
SELECT MIN(Preco) FROM Produtos

--Descobrir valor medio 
SELECT AVG(Preco) FROM Produtos

--Concatenando colunas "Renomeei a coluna de retorno"
SELECT (Nome + '-' + Cor) NomeProdutos
FROM Produtos

--Upper e Lower
SELECT UPPER(Nome + '-' + Cor) NomeProdutos
FROM Produtos
--
SELECT LOWER(Nome + '-' + Cor) NomeProdutos
FROM Produtos

--Adicionando uma nova column
ALTER TABLE Produtos
ADD DataCadastro DATETIME2

SELECT * FROM Produtos

--UPDATE
UPDATE Produtos SET DataCadastro = GETDATE()

-- Excluindo Coluna
ALTER TABLE Produtos
DROP COLUMN DataCadastro

--Formatando Data
SELECT Nome, FORMAT(DataCadastro, 'dd/MM/yy HH:mm') FROM Produtos

--GroupBy
SELECT 
Tamanho, COUNT(*) Quantidade
FROM Produtos
WHERE Tamanho <> ''
GROUP BY Tamanho 
ORDER BY Quantidade DESC

--Group By Pegando ID

SELECT MAX(Preco)
FROM Produtos

--Criando Chave Estrangeira e Primaria

CREATE TABLE Enderecos(
Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
IdCliente int NULL,
Rua varchar(255) NULL,
Bairro varchar(255) NULL,
Cidade varchar(255) NULL,
Estado char(2) NULL,

CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdCliente) REFERENCES Clientes(Id)
)

-- Criando um INNER JOIN
 SELECT
*
 FROM 
 Clientes
 INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
 WHERE Clientes.Id = 4










