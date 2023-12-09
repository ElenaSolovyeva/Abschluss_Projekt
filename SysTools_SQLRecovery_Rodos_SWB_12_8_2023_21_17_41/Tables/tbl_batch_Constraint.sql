ALTER TABLE [dbo].[tbl_batch] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_batch] ADD CONSTRAINT [PK_tbl_batch] PRIMARY KEY CLUSTERED ([id])
go
