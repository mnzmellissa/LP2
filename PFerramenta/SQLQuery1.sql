CREATE DATABASE LP2;

USE LP2

CREATE TABLE CATEGORIA (
 idCATEGORIA INT NOT NULL IDENTITY,
 DESCRICAO VARCHAR(15) NOT NULL,
 PRIMARY KEY(idCATEGORIA)
);

CREATE TABLE FERRAMENTA (
 idFERRAMENTA INT NOT NULL IDENTITY,
 NOME VARCHAR(20) NOT NULL,
 FORNECEDOR VARCHAR(20) NOT NULL,
 DISTRIBUICAO CHAR(1) NOT NULL,
 DTCADASTRO DATE NOT NULL,
 SITEOFICIAL VARCHAR(100) NOT NULL,
 CATEGORIA_idCATEGORIA INT,
 PRIMARY KEY(idFERRAMENTA),
 FOREIGN KEY(CATEGORIA_idCATEGORIA) REFERENCES CATEGORIA(idCATEGORIA)
);

INSERT INTO CATEGORIA (DESCRICAO)
VALUES ('Ferramentas Man'),
       ('Ferramentas Elé'),
       ('Ferramentas Med'),
       ('Ferramentas Cut');

-- Vinculando ferramentas à categoria de Ferramentas Manuais (idCATEGORIA = 5)
INSERT INTO FERRAMENTA (NOME, FORNECEDOR, DISTRIBUICAO, DTCADASTRO, SITEOFICIAL, CATEGORIA_idCATEGORIA)
VALUES ('Martelo', 'Fornecedor A', 'M', '2023-01-15', 'http://www.martelos.com', 5),
       ('Chave de Fenda', 'Fornecedor B', 'F', '2023-02-20', 'http://www.chavedefenda.com', 5);

-- Vinculando ferramentas à categoria de Ferramentas Elétricas (idCATEGORIA = 6)
INSERT INTO FERRAMENTA (NOME, FORNECEDOR, DISTRIBUICAO, DTCADASTRO, SITEOFICIAL, CATEGORIA_idCATEGORIA)
VALUES ('Furadeira', 'Fornecedor C', 'E', '2023-03-10', 'http://www.furadeiras.com', 6),
       ('Serra Elétrica', 'Fornecedor D', 'E', '2023-04-05', 'http://www.serras.com', 6);

-- Vinculando ferramentas à categoria de Ferramentas de Medição (idCATEGORIA = 7)
INSERT INTO FERRAMENTA (NOME, FORNECEDOR, DISTRIBUICAO, DTCADASTRO, SITEOFICIAL, CATEGORIA_idCATEGORIA)
VALUES ('Trena', 'Fornecedor E', 'M', '2023-05-20', 'http://www.trenas.com', 7),
       ('Paquímetro', 'Fornecedor F', 'M', '2023-06-15', 'http://www.paquimetros.com', 7);

-- Vinculando ferramentas à categoria de Ferramentas de Corte (idCATEGORIA = 8)
INSERT INTO FERRAMENTA (NOME, FORNECEDOR, DISTRIBUICAO, DTCADASTRO, SITEOFICIAL, CATEGORIA_idCATEGORIA)
VALUES ('Tesoura', 'Fornecedor G', 'M', '2023-07-10', 'http://www.tesouras.com', 8),
       ('Estilete', 'Fornecedor H', 'M', '2023-08-05', 'http://www.estiletes.com', 8);
