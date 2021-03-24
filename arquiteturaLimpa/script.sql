create database bancoUsuario;

use bancoUsuario;

drop table usuario;

create table usuarios(
	 id int primary key,
	 nome varchar (255),
	 email varchar (255),
	 password varchar(255),
	 ativo int,
	 perfil varchar (255)
);

insert into usuarios values (1, 'lu', 'lu@gmail.com', '123456', 1, 'usu');

select*from usuarios;