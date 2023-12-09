ALTER TABLE [dbo].[tbl_material] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_material] ADD CONSTRAINT [PK_tbl_material] PRIMARY KEY CLUSTERED (,[id])
go
