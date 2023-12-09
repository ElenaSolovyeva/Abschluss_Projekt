ALTER TABLE [dbo].[tbl_dispo_swb] ALTER COLUMN [start_time] datetime NOT NULL
go
ALTER TABLE [dbo].[tbl_dispo_swb] ALTER COLUMN [end_time] datetime NOT NULL
go
ALTER TABLE [dbo].[tbl_dispo_swb] ADD CONSTRAINT [PK_dbo.tbl_dispo_swb] PRIMARY KEY CLUSTERED ([start_time],[end_time])
go
