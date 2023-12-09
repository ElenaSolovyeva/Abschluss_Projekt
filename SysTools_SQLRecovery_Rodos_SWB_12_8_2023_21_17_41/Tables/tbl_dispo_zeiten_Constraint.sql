ALTER TABLE [dbo].[tbl_dispo_zeiten] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_dispo_zeiten] ALTER COLUMN [fid_dispo] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_dispo_zeiten] ADD CONSTRAINT [PK__tbl_dispo_zeiten__15502E78] PRIMARY KEY CLUSTERED ([id],[fid_dispo])
go
