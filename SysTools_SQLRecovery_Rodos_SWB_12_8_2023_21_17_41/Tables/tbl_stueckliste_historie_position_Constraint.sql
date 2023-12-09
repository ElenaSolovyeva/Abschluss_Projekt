ALTER TABLE [dbo].[tbl_stueckliste_historie_position] ALTER COLUMN [id] bigint NOT NULL
go
ALTER TABLE [dbo].[tbl_stueckliste_historie_position] ADD CONSTRAINT [PK_tbl_stueckliste_historie_position] PRIMARY KEY CLUSTERED ([id])
go
CREATE NONCLUSTERED INDEX [IX_tbl_stueckliste_H_position] ON [dbo].[tbl_stueckliste_historie_position]([id] ASC)
go
