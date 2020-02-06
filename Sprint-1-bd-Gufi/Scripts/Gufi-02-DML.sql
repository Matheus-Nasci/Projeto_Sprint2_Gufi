CREATE DATABASE Gufi_DML;

USE Gufi_DDL;

INSERT INTO TipoUsuario(TituloTipoUsuario)
VALUES ('Administraor'),('Comum');

INSERT INTO TipoEvento(TituloTipoEvento)
VALUES ('C#'),('JavaScript'),('HTML5'),('DataBase');

INSERT INTO Instituicao (CNPJ,NomeFantasia,Endereco)
VALUES ('24380019283478','DevXP','Alameda Barão de Limeira,538');

INSERT INTO Usuario(NomeUsuario,Email,Senha,Genero,DataNascimento,TipoUsuario)
VALUES	('Matheus','Matheus@gmail.com','matheus123','Masculino','18/03/2003',1),
		('Felipe','Felipe@gmail.com','393474','Masculino','17/05/2002',2),
		('Diego','Diego@Yahoo.com','diego321','Masculino','20/08/1999',2),
		('Daniel','Daniel@hotmail.com','101023','Masculino','21/01/2003',2);

INSERT INTO Evento(DataEvento,NomeEvento,Descricao,AcessoLivre,IdInstitucao,IdTipoEvento)
VALUES	('07/02/2020','Company DEV','Um evento sobre CSharp',1,1,1),
		('01/08/2020','Company DEV','Vamos aprender JavaScript do Começo',0,1,2),
		('20/07/2020','Company DEV','Evolua no HTML',0,1,3),
		('17/05/2020','Company DEV','Os dados são muito importantes',1,1,4);

INSERT INTO Presenca(Situacao,IdUsuario,IdEvento)
VALUES	('PRESENTE',2,3),
		('PRESENTE',1,2),
		('AUSENTE',4,4),
		('PRESENTE',3,1);