create table dbo.produto
(
    id int identity(1,1) constraint produto_pk primary key,
    nome varchar(150) not null,
    preco varchar(50) not null,
    quantidade int not null,
    peso varchar(50) not null,
    unidade_medida varchar(50) not null
);