ALTER TABLE [dbo].[tbl_equipement_dosier] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_equipement_dosier] ALTER COLUMN [lager_id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_equipement_dosier] ADD CONSTRAINT [PK_tbl_equipement_dosier] PRIMARY KEY CLUSTERED ([id],[lager_id])
go
