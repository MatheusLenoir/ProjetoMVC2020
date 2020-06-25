create database ProjetoMVCC22;
use ProjetoMVCC22;

create table tbl_clientes22bll(
id_cliente int(11) not null primary key,
nome_cliente varchar(45) not null,
sobrenome_cliente varchar(45) not null,
email_cliente varchar(50) not null,
senha_cliente varchar(45) not null,
cpf_cliente varchar(11) not null,
nome_mae varchar(50) not null,
tp_usuario int(1) default null 
);

select * from tbl_clientes22bll;