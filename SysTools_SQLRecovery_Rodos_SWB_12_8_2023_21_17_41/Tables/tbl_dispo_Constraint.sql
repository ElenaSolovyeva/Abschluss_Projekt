CREATE NONCLUSTERED INDEX [IX_tbl_dispo_1] ON [dbo].[tbl_dispo]([line_id] ASC)
go
CREATE NONCLUSTERED INDEX [IX_tbl_dispo_2] ON [dbo].[tbl_dispo]([auftragsnr] ASC)
go
CREATE NONCLUSTERED INDEX [IX_tbl_dispo_3] ON [dbo].[tbl_dispo]([rz_nr] ASC)
go
ALTER TABLE [dbo].[tbl_dispo] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_dispo] ALTER COLUMN [start_time] datetime NOT NULL
go
ALTER TABLE [dbo].[tbl_dispo] ALTER COLUMN [end_time] datetime NOT NULL
go
ALTER TABLE [dbo].[tbl_dispo] ADD CONSTRAINT [PK_tbl_dispo] PRIMARY KEY CLUSTERED ([id],[start_time],[end_time])
go
CREATE NONCLUSTERED INDEX [IX_tbl_dispo] ON [dbo].[tbl_dispo]([Rezept_id] ASC,[sap_auftragsnr] ASC)
go
