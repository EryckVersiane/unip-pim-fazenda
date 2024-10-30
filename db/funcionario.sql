
create table dbo.funcionario
(
    id int identity(1,1) constraint funcionario_pk primary key,
    nome varchar(150) not null,
    cpf varchar(11),
    endereco varchar(500) not null,
    telefone varchar(11),
    email varchar(150) not null,
    cargo varchar(50) not null,
    jornada varchar(250) not null
);

