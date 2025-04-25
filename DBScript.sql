-- Create the database and tables for InvoiceMaster

-- Create the database if it does not exist
IF NOT EXISTS (
    SELECT 1
    FROM sys.databases
    WHERE name = N'InvoiceMaster'
)
BEGIN
    CREATE DATABASE [InvoiceMaster];
END
GO

USE [InvoiceMaster];
GO

-- Create the tables

-- tbl_categories
IF OBJECT_ID(N'dbo.tbl_categories', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[tbl_categories] (
        [id]           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [title]        VARCHAR(50)     NULL,
        [description]  NVARCHAR(255)   NULL,
        [added_date]   DATETIME        NULL,
        [added_by]     INT             NULL
    );
END
GO

-- tbl_dea_cust
IF OBJECT_ID(N'dbo.tbl_dea_cust', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[tbl_dea_cust] (
        [id]           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [role]         VARCHAR(50)     NULL,
        [name]         VARCHAR(50)     NULL,
        [email]        VARCHAR(150)    NULL,
        [contact]      VARCHAR(15)     NULL,
        [address]      NVARCHAR(255)   NULL,
        [added_date]   DATETIME        NULL,
        [added_by]     INT             NULL
    );
END
GO

-- tbl_products
IF OBJECT_ID(N'dbo.tbl_products', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[tbl_products] (
        [id]           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [name]         VARCHAR(50)     NULL,
        [category]     VARCHAR(50)     NULL,
        [description]  NVARCHAR(255)   NULL,
        [rate]         DECIMAL(18,2)   NULL,
        [qty]          DECIMAL(18,2)   NULL,
        [added_date]   DATETIME        NULL,
        [added_by]     INT             NULL
    );
END
GO

-- tbl_transactions
IF OBJECT_ID(N'dbo.tbl_transactions', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[tbl_transactions] (
        [id]                INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [type]              VARCHAR(50)     NULL,
        [dea_cust_id]       INT             NULL,
        [grand_total]       DECIMAL(18,2)   NULL,
        [transaction_date]  DATETIME        NULL,
        [vat]               DECIMAL(18,2)   NULL,
        [discount]          DECIMAL(18,2)   NULL,
        [added_by]          INT             NULL
    );
END
GO

-- tbl_transaction_detail
IF OBJECT_ID(N'dbo.tbl_transaction_detail', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[tbl_transaction_detail] (
        [id]            INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [product_id]    INT             NULL,
        [rate]          DECIMAL(18,2)   NULL,
        [qty]           DECIMAL(18,2)   NULL,
        [total]         DECIMAL(18,2)   NULL,
        [dea_cust_id]   INT             NULL,
        [added_date]    DATETIME        NULL,
        [added_by]      INT             NULL
    );
END
GO

-- tbl_users
IF OBJECT_ID(N'dbo.tbl_users', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[tbl_users] (
        [id]           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [first_name]   VARCHAR(50)     NULL,
        [surname]      VARCHAR(50)     NULL,
        [email]        VARCHAR(150)    NULL,
        [username]     VARCHAR(50)     NULL,
        [password]     NVARCHAR(255)   NULL,
        [contact]      VARCHAR(15)     NULL,
        [address]      TEXT            NULL,
        [role]         VARCHAR(15)     NULL,
        [added_date]   DATETIME        NULL,
        [added_by]     INT             NULL
    );
END
GO

-- Seed two basic accounts
USE [InvoiceMaster];
GO

-- Admin account
IF NOT EXISTS (SELECT 1 FROM dbo.tbl_users WHERE username = N'admin')
BEGIN
  INSERT INTO dbo.tbl_users
    (first_name, surname, email, username, password, contact, address, role, added_date, added_by)
  VALUES
    (N'Admin', N'', N'admin@example.com', N'admin',
     -- mot de passe hashé ou en clair selon ton approche ; ici en clair pour l’exemple :
     N'admin', N'0000000000', N'Adresse Admin', N'Administrateur',
     GETDATE(), 0);
END
GO

-- Standard User account
IF NOT EXISTS (SELECT 1 FROM dbo.tbl_users WHERE username = N'user')
BEGIN
  INSERT INTO dbo.tbl_users
    (first_name, surname, email, username, password, contact, address, role, added_date, added_by)
  VALUES
    (N'User', N'', N'user@example.com', N'user',
     N'user', N'0000000000', N'Adresse User', N'Utilisateur',
     GETDATE(), 0);
END
GO
