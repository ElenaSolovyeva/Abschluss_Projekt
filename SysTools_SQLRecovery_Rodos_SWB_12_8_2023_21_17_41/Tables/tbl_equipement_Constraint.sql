ALTER TABLE [dbo].[tbl_equipement] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_equipement] ADD CONSTRAINT [PK_tbl_equipement] PRIMARY KEY CLUSTERED ([id])
go
