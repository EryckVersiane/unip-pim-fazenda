create table dbo.pessoa (
    id int identity(1,1)  constraint  pessoa_pk primary key,
    nome varchar(100) not null
);

create table dbo.pessoa_fisica (
    id int identity(1,1) constraint pessoa_fisica_pk primary key,
    cpf varchar(11) not null,
    pessoa_id int not null constraint pessoa_fisica_pessoa_FK references dbo.pessoa
);

create table dbo.pessoa_juridica (
    id int identity(1,1) constraint pessoa_juridica_pk primary key,
    cnpj varchar(14) not null,
    pessoa_id int not null constraint pessoa_juridica_pessoa_FK references dbo.pessoa
);

create table dbo.email (
    id int identity(1,1) constraint  email_pk primary key,
    email varchar(100) not null,
    pessoa_id int not null constraint email_pessoa_FK references dbo.pessoa
);

create table dbo.telefone (
    id   int identity(1,1) constraint telefone_pk primary key,
    ddd varchar(100) not null,
    numero  varchar(11)  not null,
    pessoa_id int not null constraint telefone_pessoa_FK references dbo.pessoa
);

create table dbo.funcionario (
    id int identity(1,1) constraint funcionario_pk primary key,
    pessoa_fisica_id int not null constraint funcionario_pessoa_fisica_FK references dbo.pessoa_fisica
);


create table dbo.salario (
    id int identity(1,1)  constraint salario_pk primary key ,
    valor decimal(4,2) not null ,
    vigencia date,
    funcionario_id int not null constraint  salario_funcionario_FK references dbo.funcionario
);

create table dbo.fornecedor (
    id int identity(1,1) constraint fornecedor_pk primary key,
    pessoa_juridica_id int not null constraint fornecedor_pessoa_juridica_FK references dbo.pessoa_juridica
);


create table dbo.usuario (
    id int identity(1,1) constraint usuario_pk primary key ,
    usuario varchar(20) not null ,
    senha varchar(512) not null,
    estado varchar(1), -- se for senha gerada automáticamente deve ser A depois que for alterada deve ser null ou M
    pessoa_id int not null constraint usuario_pessoa_FK references dbo.pessoa
);


create table dbo.produto (
    codigo int identity(1,1) constraint produo_pk primary key ,
    nome varchar(124) not null
);


