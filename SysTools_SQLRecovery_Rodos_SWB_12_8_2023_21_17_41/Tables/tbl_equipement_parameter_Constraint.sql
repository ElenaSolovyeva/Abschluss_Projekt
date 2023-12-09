ALTER TABLE [dbo].[tbl_equipement_parameter] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_equipement_parameter] ADD CONSTRAINT [PK_tbl_equipement_parameter] PRIMARY KEY CLUSTERED ([id])
go
