ALTER TABLE [dbo].[tbl_laufzeit] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_laufzeit] ADD CONSTRAINT [PK_tbl_laufzeit] PRIMARY KEY CLUSTERED (,[id])
go
