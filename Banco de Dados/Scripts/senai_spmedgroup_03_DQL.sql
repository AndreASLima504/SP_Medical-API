select * from Usuarios
select*from TipoUsuario
select*from Medico
select*from Paciente
select*from Clinicas
select*from Especialidades
select*from Paciente
select*from Consultas

select count(usuarioID) from Usuarios;
GO

CREATE PROCEDURE idadePaciente AS
SELECT pacienteID as 'idPaciente' from Paciente
INNER JOIN Usuarios ON Usuarios.usuarioID = paciente.usuarioID
GO

