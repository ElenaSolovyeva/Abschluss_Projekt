ALTER TABLE [dbo].[tbl_stueckliste_position] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_stueckliste_position] ADD CONSTRAINT [PK_tbl_stueckliste_position] PRIMARY KEY CLUSTERED ([id])
go
