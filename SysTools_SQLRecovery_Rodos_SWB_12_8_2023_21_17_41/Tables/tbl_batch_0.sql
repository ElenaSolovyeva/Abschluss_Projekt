CREATE TABLE [dbo].[tbl_batch] ([id] [bigint] NOT NULL IDENTITY(1298,1) ,[bezeichnung] [varchar](50),[ersteller_datum] [varchar](20),[einheiht] [varchar](10),[materialid] [bigint],[stücklistenid] [bigint],[letzte_Änderung] [varchar](20),[rz_version] [bigint],[rz_aktive_version] [bigint],[rezept_menge] [float],[rez_min] [float],[rez_max] [float],[pack_pr] [bigint] NOT NULL,[rz_nr] [varchar](25),[grupp_id] [bigint] NOT NULL,[autor] [varchar](50),[aktiv] [int] NOT NULL,[gebinde] [int] NOT NULL,[gebinde_id] [bigint] NOT NULL)

go
