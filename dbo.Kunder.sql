CREATE TABLE [dbo].[Kunder] (
    [Id]          INT            NOT NULL,
    [KundNamn]    NVARCHAR (MAX)  NULL,
    [KundTelefon] NVARCHAR (MAX)  NULL,
    [Modell]      NVARCHAR (MAX)  NULL,
    [Lösenord]    NVARCHAR (MAX)  NULL,
    [IMEInummer]  NVARCHAR (MAX)  NULL,
    [Pris]        INT            NULL,
    [Instruktion] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

