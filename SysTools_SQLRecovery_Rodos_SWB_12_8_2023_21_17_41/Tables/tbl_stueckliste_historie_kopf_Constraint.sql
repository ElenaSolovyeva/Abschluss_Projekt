ALTER TABLE [dbo].[tbl_stueckliste_historie_kopf] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_stueckliste_historie_kopf] ADD CONSTRAINT [PK_tbl_stueckliste_historie_kopf] PRIMARY KEY CLUSTERED (,[id])
go
