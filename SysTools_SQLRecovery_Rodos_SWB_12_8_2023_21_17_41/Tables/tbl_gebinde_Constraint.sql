ALTER TABLE [dbo].[tbl_gebinde] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_gebinde] ADD CONSTRAINT [PK_tbl_gebinde] PRIMARY KEY CLUSTERED ([id])
go
