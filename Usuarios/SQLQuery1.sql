create database usuarios_db;

use usuarios_db;

SELECT *
FROM sys.databases;  

select * from sys.tables;

create table usuario(
idUsuario int not null primary key identity, 
nomeCompleto varchar(45) not null,
email varchar(45) not null
);

Select * from usuario;

insert into usuario values('Andréa Silvestre', 'andrea.silvestre@ufn.edu.br');
insert into usuario values('José Belico', 'jose.belico@ufn.edu.br');
insert into usuario values('Pedro Morais', 'pedro.morais@ufn.edu.br');

select * from usuario;

delete from usuario where idUsuario = 2;

update usuario set nomeCompleto = 'Joao Gustavo', email='joao.gustavo@ufn.edu.br' where idUsuario = 5