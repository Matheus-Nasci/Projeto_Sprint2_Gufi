CREATE DATABASE Gufi_DQL;

USE Gufi_DDL;

SELECT * FROM Instituicao;
SELECT * FROM TipoEvento;
SELECT * FROM TipoUsuario;
SELECT * FROM Usuario;
SELECT * FROM Evento;
SELECT * FROM Presenca;

SELECT	Usuario.NomeUsuario,Usuario.Email,TipoUsuario.TituloTipoUsuario
		,Usuario.DataNascimento,Usuario.Genero FROM  Usuario
		INNER JOIN TipoUsuario ON TipoUsuario.IdTipoUsuario = Usuario.TipoUsuario
		
--Nesse caso eu só tinha uma instituição cadastrada
SELECT Instituicao.CNPJ,Instituicao.NomeFantasia,Instituicao.Endereco FROM Instituicao

--Colocar o que você deseja que apareça no da Tabela 
-- NÃO PRECISA SER DA MESMA TABELA 
SELECT Evento.NomeEvento, TipoEvento.TituloTipoEvento, Evento.DataEvento, Evento.AcessoLivre
		,Evento.Descricao, Instituicao.CNPJ, Instituicao.Endereco, Instituicao.NomeFantasia
		FROM Evento --Tabela aonde você pegou os Dados
		INNER JOIN Instituicao ON Instituicao.IdInstituicao = Evento.IdInstitucao
		INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento
		--No INNER JOIN É PARA CONECTAR AS Tabelas

SELECT Evento.NomeEvento, TipoEvento.TituloTipoEvento, Evento.DataEvento, Evento.AcessoLivre
		,Evento.Descricao, Instituicao.CNPJ, Instituicao.Endereco, Instituicao.NomeFantasia FROM Evento 
		INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento
		INNER JOIN Instituicao ON Instituicao.IdInstituicao = Evento.IdInstitucao
		WHERE Evento.AcessoLivre = 1; --Mostrando somente os eventos publicos

SELECT	Evento.NomeEvento, TipoEvento.TituloTipoEvento, Evento.DataEvento,
		-- Simple CASE expression: 
		CASE 	
			WHEN AcessoLivre = 1 THEN 'PUBLICO'
			WHEN AcessoLivre = 0 THEN 'PRIVADO'
		END	AS AcessoLivre
		,Evento.Descricao, Instituicao.CNPJ, Instituicao.Endereco, Instituicao.NomeFantasia FROM Evento 
		INNER JOIN Instituicao ON Instituicao.IdInstituicao = Evento.IdInstitucao
		INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento  

SELECT	 Usuario.NomeUsuario,Usuario.Email,TipoUsuario.TituloTipoUsuario,Usuario.DataNascimento
		,Usuario.Genero, Evento.NomeEvento, TipoEvento.TituloTipoEvento, Evento.DataEvento, Evento.AcessoLivre
		,Evento.Descricao, Instituicao.CNPJ, Instituicao.Endereco, Instituicao.NomeFantasia FROM Evento 
		INNER JOIN Instituicao ON Instituicao.IdInstituicao = Evento.IdInstitucao
		INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento
		INNER JOIN TipoUsuario ON TipoUsuario.IdTipoUsuario = Evento.IdTipoEvento
		INNER JOIN Usuario ON TipoUsuario.IdTipoUsuario = Usuario.TipoUsuario

SELECT Evento.NomeEvento, Presenca.Situacao FROM Evento
		INNER JOIN Presenca ON Presenca.IdPresenca = Evento.IdEvento
		WHERE Presenca.Situacao = 'CONFIRMADO';

