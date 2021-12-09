select * from Usuarios
select*from TipoUsuario
select*from Medicos
select*from Pacientes
select*from Clinicas
select*from Especialidades
select*from Consultas

select count(usuarioID) from Usuarios;
GO

CREATE PROCEDURE idadePaciente AS
SELECT pacienteID as 'idPaciente' from Paciente
INNER JOIN Usuarios ON Usuarios.usuarioID = paciente.usuarioID
GO

