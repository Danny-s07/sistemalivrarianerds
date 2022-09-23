-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.

create database livraria_nerds  charset=utf8 COLLATE = utf8_general_ci;

USE livraria_nerds;


CREATE TABLE categoria (
cod_cat INT(03) AUTO_INCREMENT PRIMARY KEY PRIMARY KEY,
nome VARCHAR(40) UNIQUE NOT NULL,
dt_cad DATETIME NOT NULL,
status_cat BIT(1) NOT NULL
);

CREATE TABLE autor (
cod_aut VARCHAR(10) PRIMARY KEY,
nome VARCHAR(10),
telefone CHAR(14),
celular CHAR(15),
email VARCHAR(50),
sexo VARCHAR(10),
status_aut BIT(1) NOT NULL,
dt_cad DATETIME NOT NULL
);

CREATE TABLE fornecedores (
cod_forn INT(03) AUTO_INCREMENT PRIMARY KEY PRIMARY KEY,
nome VARCHAR(50) NOT NULL,
sexo VARCHAR(10),
email VARCHAR(50),
cnpj CHAR(14) UNIQUE NOT NULL,
rua VARCHAR(50),
numero VARCHAR(04) NOT NULL,
bairro VARCHAR(40),
cep CHAR(09),
complemento VARCHAR(40),
cidade VARCHAR(40),
estado CHAR(02),
telefones CHAR(14),
celular CHAR(15),
status_forn BIT(1) NOT NULL,
dt_cd DATETIME NOT NULL
);

CREATE TABLE cargos (
cod_carg INT(03) AUTO_INCREMENT PRIMARY KEY PRIMARY KEY,
nome VARCHAR(50) UNIQUE NOT NULL,
dt_cad DATETIME NOT NULL,
status_carg BIT(1) NOT NULL
);

CREATE TABLE cliente (
cod_cli INT(03) AUTO_INCREMENT PRIMARY KEY PRIMARY KEY,
dt_cad DATETIME NOT NULL,
nome VARCHAR(50) NOT NULL,
rg CHAR(12),
cpf CHAR(14) UNIQUE NOT NULL,
datanascimento DATE NOT NULL,
sexo VARCHAR(10),
rua VARCHAR(50) NOT NULL,
numero INT(04) NOT NULL,
complemento VARCHAR(40),
bairro VARCHAR(35),
cidade VARCHAR(50),
estado CHAR(02),
cep CHAR(09),
email VARCHAR(40),
telefones CHAR(14),
celular CHAR(15),
status_cli BIT(1) NOT NULL
);

CREATE TABLE funcionario (
cod_func INT(03) AUTO_INCREMENT PRIMARY KEY PRIMARY KEY,
nome VARCHAR(50) NOT NULL,
rg CHAR(12),
cpf CHAR(14) UNIQUE NOT NULL,
datanascimento DATE NOT NULL,
sexo VARCHAR(10),
rua VARCHAR(50) NOT NULL,
numero INT(04) NOT NULL,
complemento VARCHAR(40),
bairro VARCHAR(40),
cidade VARCHAR(40),
estado CHAR(02),
cep CHAR(09),
email VARCHAR(50),
telefone CHAR(14),
celular CHAR(15),
status_func BIT(1) NOT NULL,
dt_cad DATETIME NOT NULL,
cod_carg INT(03),
FOREIGN KEY(cod_carg) REFERENCES cargos (cod_carg)
);

CREATE TABLE livros (
cod_prod INT(03) AUTO_INCREMENT PRIMARY KEY PRIMARY KEY,
nome VARCHAR(35) NOT NULL,
qtd_estoque INT(04) NOT NULL,
preco DECIMAL(6,2) NOT NULL,
dt_cad DATETIME NOT NULL,
status_liv BIT(1) NOT NULL,
cod_forn INT(03),
cod_cat INT(03),
cod_aut VARCHAR(10),
FOREIGN KEY(cod_forn) REFERENCES fornecedores (cod_forn),
FOREIGN KEY(cod_cat) REFERENCES categoria (cod_cat),
FOREIGN KEY(cod_aut) REFERENCES autor (cod_aut)
);

CREATE TABLE pedido (
cod_ped INT(03) AUTO_INCREMENT PRIMARY KEY PRIMARY KEY,
dt_cad DATETIME NOT NULL,
valor_total DECIMAL(7,2) NOT NULL,
formapagt VARCHAR(20),
desconto DECIMAL(5,2 ) NOT NULL,
cod_cli INT(03),
cod_func INT(03),
FOREIGN KEY(cod_cli) REFERENCES cliente (cod_cli),
FOREIGN KEY(cod_func) REFERENCES funcionario (cod_func)
);

CREATE TABLE itens_vendidos (
codigo_itens_vendidos INT(11) AUTO_INCREMENT PRIMARY KEY,
cod_ped INT(03),
cod_prod INT(03),
qtde INT(03) NOT NULL,
preco DECIMAL(7,2) NOT NULL,
FOREIGN KEY(cod_ped) REFERENCES pedido (cod_ped),
FOREIGN KEY(cod_prod) REFERENCES livros (cod_prod)
);

