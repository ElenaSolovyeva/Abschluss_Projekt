CREATE NONCLUSTERED INDEX [IX_tbl_dispo_position_1] ON [dbo].[tbl_dispo_position]([auf_id] ASC)
go
CREATE NONCLUSTERED INDEX [IX_tbl_dispo_position_2] ON [dbo].[tbl_dispo_position]([auf_id] ASC)
go
CREATE NONCLUSTERED INDEX [IX_tbl_dispo_position_3] ON [dbo].[tbl_dispo_position]([auf_id] ASC)
go
CREATE NONCLUSTERED INDEX [IX_tbl_dispo_position_4] ON [dbo].[tbl_dispo_position]([auf_id] ASC)
go
CREATE NONCLUSTERED INDEX [IX_tbl_dispo_position_5] ON [dbo].[tbl_dispo_position]([auf_id] ASC)
go
ALTER TABLE [dbo].[tbl_dispo_position] ALTER COLUMN [auf_id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_dispo_position] ADD CONSTRAINT [PK_tbl_dispo_position] PRIMARY KEY CLUSTERED ([auf_id])
go
CREATE NONCLUSTERED INDEX [IX_tbl_dispo_position] ON [dbo].[tbl_dispo_position]([auf_id] ASC)
go
