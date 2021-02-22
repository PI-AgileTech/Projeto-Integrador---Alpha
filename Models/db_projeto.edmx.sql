
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/10/2020 14:10:24
-- Generated from EDMX file: D:\Meus Projetos de Programação_EU DEV\projetogrupo5\Alpha\Alpha\Models\db_projeto.edmx
-- --------------------------------------------------

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'dados_pessoaisSet'
CREATE TABLE [dbo].[dados_pessoaisSet] (
    [dados_pessoais_Id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [data_nascimento] datetime  NOT NULL,
    [cpf] smallint  NOT NULL,
    [sexo] bit  NOT NULL,
    [telefone] smallint  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [rua] nvarchar(max)  NOT NULL,
    [numero] smallint  NOT NULL,
    [bairro] nvarchar(max)  NOT NULL,
    [cep] smallint  NOT NULL,
    [uf] bit  NOT NULL,
    [status_relacionamento] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'reservaSet'
CREATE TABLE [dbo].[reservaSet] (
    [reserva_Id] int IDENTITY(1,1) NOT NULL,
    [hospede] nvarchar(max)  NOT NULL,
    [data_nascimento1] nvarchar(max)  NOT NULL,
    [cpf1] nvarchar(max)  NOT NULL,
    [sexo] bit  NOT NULL,
    [data_reserva] datetime  NOT NULL,
    [data_saida] datetime  NOT NULL,
    [horario_entrada] time  NOT NULL,
    [horario_saida] time  NOT NULL,
    [tipo_reserva] nvarchar(max)  NOT NULL,
    [quarto] nvarchar(max)  NOT NULL,
    [num_quarto] smallint  NOT NULL,
    [status_relacionamento1] nvarchar(max)  NOT NULL,
    [telefone1] smallint  NOT NULL,
    [email1] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'checkinSet'
CREATE TABLE [dbo].[checkinSet] (
    [checkin_Id] int IDENTITY(1,1) NOT NULL,
    [hospede1] nvarchar(max)  NOT NULL,
    [horario_checkin] time  NOT NULL,
    [horario_checkout] time  NOT NULL,
    [num_quarto1] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [dados_pessoais_Id] in table 'dados_pessoaisSet'
ALTER TABLE [dbo].[dados_pessoaisSet]
ADD CONSTRAINT [PK_dados_pessoaisSet]
    PRIMARY KEY CLUSTERED ([dados_pessoais_Id] ASC);
GO

-- Creating primary key on [reserva_Id] in table 'reservaSet'
ALTER TABLE [dbo].[reservaSet]
ADD CONSTRAINT [PK_reservaSet]
    PRIMARY KEY CLUSTERED ([reserva_Id] ASC);
GO

-- Creating primary key on [checkin_Id] in table 'checkinSet'
ALTER TABLE [dbo].[checkinSet]
ADD CONSTRAINT [PK_checkinSet]
    PRIMARY KEY CLUSTERED ([checkin_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------