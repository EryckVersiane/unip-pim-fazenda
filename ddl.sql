CREATE TABLE master.dbo.produtos (
	codigo int IDENTITY(1,1) NOT NULL,
	nome varchar(150) NOT NULL,
	CONSTRAINT produtos_pk PRIMARY KEY (codigo)
);
EXEC master.sys.sp_addextendedproperty 'MS_Description', N'Código usado para identificar produto.', 'schema', N'dbo', 'table', N'produtos', 'column', N'codigo';
EXEC master.sys.sp_addextendedproperty 'MS_Description', N'Nome do produto.', 'schema', N'dbo', 'table', N'produtos', 'column', N'nome';
