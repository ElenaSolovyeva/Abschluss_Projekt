ALTER TABLE [dbo].[SAP_RoDocument] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[SAP_RoDocument] ADD CONSTRAINT [PK_SAP_RoDocument] PRIMARY KEY CLUSTERED (,[id])
go
