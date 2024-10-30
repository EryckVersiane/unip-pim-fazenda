create table dbo.fornecedor
(
    id int identity(1,1) constraint fornecedor_pk primary key,
    nome varchar(150) not null,
    cnpj varchar(11),
    telefone varchar(11),
    email varchar(150) not null,
    endereço varchar(150)
);