ALTER TABLE [dbo].[__MigrationHistory] ALTER COLUMN [ContextKey] nvarchar(300) NOT NULL
go
ALTER TABLE [dbo].[__MigrationHistory] ADD CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED ([ContextKey])
go
