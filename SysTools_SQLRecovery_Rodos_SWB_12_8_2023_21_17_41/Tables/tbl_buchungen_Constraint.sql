ALTER TABLE [dbo].[tbl_buchungen] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_buchungen] ADD CONSTRAINT [PK_tbl_buchungen] PRIMARY KEY CLUSTERED ([id])
go
