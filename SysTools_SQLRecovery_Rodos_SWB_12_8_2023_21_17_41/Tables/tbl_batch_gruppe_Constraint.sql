ALTER TABLE [dbo].[tbl_batch_gruppe] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_batch_gruppe] ADD CONSTRAINT [PK_tbl_batch_gruppe] PRIMARY KEY CLUSTERED (,[id])
go
