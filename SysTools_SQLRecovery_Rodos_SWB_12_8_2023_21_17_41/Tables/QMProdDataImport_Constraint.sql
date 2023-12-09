ALTER TABLE [dbo].[QMProdDataImport] ALTER COLUMN [Id] bigint NOT NULL
go
ALTER TABLE [dbo].[QMProdDataImport] ADD CONSTRAINT [PK_QMProdDataImport] PRIMARY KEY CLUSTERED ([Id])
go
