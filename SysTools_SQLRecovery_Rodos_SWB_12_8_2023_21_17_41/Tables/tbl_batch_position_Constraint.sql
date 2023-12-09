ALTER TABLE [dbo].[tbl_batch_position] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_batch_position] ADD CONSTRAINT [PK_tbl_batch_position] PRIMARY KEY CLUSTERED (,[id])
go
