CREATE VIEW dbo.[Ansicht Fehlerhafte zeitstempel]
AS
SELECT        TOP (100) PERCENT id, start_time, end_time, line_id, auftragsnr, auftragsmenge, chargenanzahl_soll, chargenanzahl_ist, chargen_grösse, chargen_gewicht, Rezept_id, Rezept_version_id, Ziel, reinigung, 
                         auftrags_gewicht, restmenge, last_chargen_grösse, last_chargen_gewicht, chargenanzahl_Rest, status, rt_pack_nr, auftrags_gewicht_ist, rz_nr, handstatus, produktgruppe, gebinde, bemerkung, Lager_Bez, 
                         Material_Bez, Material_SAP, reihenfolge, gebinde_id, farb_id, sap_auftragsnr, sap_verbucht
FROM            dbo.tbl_dispo
WHERE        (end_time < start_time) AND (status = 4)
ORDER BY id DESC


go
