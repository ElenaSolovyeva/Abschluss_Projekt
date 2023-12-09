CREATE TABLE [dbo].[tbl_lager] ([id] [bigint] NOT NULL IDENTITY(98,1) ,[gruppe] [varchar](50) NOT NULL,[fid_material] [bigint] NOT NULL,[bezeichnung] [varchar](50) NOT NULL,[sap_bezeichnung] [varchar](50) NOT NULL,[bestand_aktuell] [float] NOT NULL,[bestand_max] [float] NOT NULL,[bestand_min] [float] NOT NULL,[kapazität] [float] NOT NULL,[opc_kapaz] [varchar](50) NOT NULL,[opc_bestand] [varchar](50) NOT NULL,[opc_bestand_max] [varchar](50) NOT NULL,[opc_bestand_min] [varchar](50) NOT NULL,[aktiv] [int] NOT NULL,[aktiv1] [int])

go
