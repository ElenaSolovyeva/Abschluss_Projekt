ALTER TABLE [dbo].[tbl_liste1_preis] ALTER COLUMN [id] char(10) NOT NULL
go
ALTER TABLE [dbo].[tbl_liste1_preis] ADD CONSTRAINT [PK_tbl_liste1_preis] PRIMARY KEY CLUSTERED (,[id])
go
