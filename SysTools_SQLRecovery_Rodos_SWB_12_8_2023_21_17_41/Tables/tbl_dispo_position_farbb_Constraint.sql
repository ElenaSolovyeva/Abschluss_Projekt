ALTER TABLE [dbo].[tbl_dispo_position_farbb] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_dispo_position_farbb] ADD CONSTRAINT [PK_tbl_dsipo_position_farbb] PRIMARY KEY CLUSTERED ([id])
go
CREATE NONCLUSTERED INDEX [IX_tbl_dsipo_position_farbb] ON [dbo].[tbl_dispo_position_farbb]([id] ASC,[auf_id] ASC)
go
