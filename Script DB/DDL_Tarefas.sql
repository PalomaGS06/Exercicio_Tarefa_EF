CREATE DATABASE TarefasDB;
GO

USE TarefasDB;
GO

CREATE TABLE Usuario(
	Id INT IDENTITY PRIMARY KEY,
	Nome NVARCHAR(MAX),
	Email NVARCHAR(MAX),
	Senha NVARCHAR(MAX)
);
GO

CREATE TABLE Statuss(
	Id INT IDENTITY PRIMARY KEY,
	Titulo NVARCHAR(MAX)
);
GO

CREATE TABLE Tarefa(
	Id INT IDENTITY PRIMARY KEY,
	DataCriacao DATETIME,
	Descricao NVARCHAR(MAX),

	 --FKs 
	IdUsuario INT
	FOREIGN KEY (IdUsuario) REFERENCES Usuario (Id) NOT NULL,

	IdStatus INT
	FOREIGN KEY (IdStatus) REFERENCES Statuss (Id) NOT NULL
);
GO
