CREATE DATABASE SP_Med_GP
GO
USE SP_Med_GP
GO

CREATE DATABASE SP_Medical
GO
USE SP_Medical
GO

drop database SP_Medical

DROP DATABASE SP_Med_GP
GO


ALTER TABLE TipoUsuario ALTER COLUMN nomeTipo VARCHAR (30)
GO

ALTER TABLE Usuarios ALTER COLUMN email VARCHAR (50)
GO

DROP TABLE TipoUsuario;
go

drop table Usuarios
go



CREATE TABLE TipoUsuario (
tipoUsuarioID INT PRIMARY KEY IDENTITY(1,1),
nomeTipo VARCHAR (30))
GO

CREATE TABLE Usuarios (
usuarioID INT PRIMARY KEY IDENTITY(1,1),
tipoUsuarioID INT FOREIGN KEY REFERENCES TipoUsuario,
nome VARCHAR (50),
email VARCHAR(50),
senha VARCHAR (30));
GO

CREATE TABLE Clinicas(
clinicaID INT PRIMARY KEY IDENTITY(1,1),
nomeFantasia varchar (30),
CNPJ varchar (18),
enderecoClinica varchar(100),
razaoSocial varchar (30),
horarioFechamento time,
horarioAbertura time);
GO

CREATE TABLE Especialidades (
especialidadeID INT PRIMARY KEY IDENTITY(1,1),
nomeEspecialidade VARCHAR(30));
GO


CREATE TABLE Medicos(
medicoID INT PRIMARY KEY IDENTITY(1,1),
usuarioID INT FOREIGN KEY REFERENCES Usuarios,
clinicaID INT FOREIGN KEY REFERENCES Clinicas,
IDespecialidade INT FOREIGN KEY REFERENCES Especialidades,
crm VARCHAR (8))
GO

CREATE TABLE Pacientes(
pacienteID INT PRIMARY KEY IDENTITY(1,1),
usuarioID INT FOREIGN KEY REFERENCES Usuarios,
dataNascimento Date,
telefonePaciente VARCHAR (17),
RGPaciente VARCHAR (12),
CPFPaciente VARCHAR(14),
enderecoPaciente VARCHAR(100));
GO


CREATE TABLE Consultas(
consultaID INT PRIMARY KEY IDENTITY(1,1),
medicoID INT FOREIGN KEY REFERENCES Medicos,
pacienteID INT FOREIGN KEY REFERENCES Pacientes,
dataConsulta datetime,
descConsulta varchar (30));
GO


ALTER TABLE Medico
ADD clinicaID INT NOT NULL
go

ALTER TABLE Medico
ADD constraint fk_medicoClinica FOREIGN KEY (clinicaID) REFERENCES Clinicas(clinicaID)
GO

drop table Consultas
GO

ALTER TABLE Medico
ADD constraint fk_medicoUsuario FOREIGN KEY (usuarioID) REFERENCES Usuarios(usuarioID)
GO

DROP TABLE Medico
go


alter table Consultas
ADD constraint fk_consultasMedico FOREIGN KEY (medicoID) REFERENCES Medico(medicoID)
GO

alter table Consultas
ADD constraint fk_consultasPaciente FOREIGN KEY (pacienteID) REFERENCES Paciente(pacienteID)
GO

alter table Consultas
drop column dataConsulta
go

alter table consultas
add dataConsulta datetime NOT NULL
GO




DELETE FROM Usuarios
WHERE usuarioID >=13
GO

DELETE FROM Clinicas
WHERE clinicaID = 2
go

CREATE FUNCTION medicosEspecializados (@especializacao int)
RETURNS TABLE
AS
RETURN

SELECT count (medicoID) as 'qtd'
FROM Medico
WHERE especialidadeID = @especializacao

GO

select * from medicosEspecializados (2)