### Abschluss_Projekt: Material Status

#Daten aktualisieren

https://learn.microsoft.com/en-us/aspnet/core/mvc/views/view-compilation?view=aspnetcore-8.0&viewFallbackFrom=aspnetcore-3.0&tabs=visual-studio

https://alexanderzeitler.com/articles/refresh-asp-net-core-website-without-reloading-application/

#SQL-Anfragen:


SELECT * FROM tbl_equipement_dosier ORDER BY id -- id, Silo, equipment_id, lager_id
SELECT * FROM tbl_equipement --? E.equipementname,
SELECT * FROM tbl_lager -- L.bestand_aktuell, L.bestand_max, L.bestand_min, L.sap_bezeichnung
SELECT * FROM tbl_material -- M.materialgruppe, M.sap_bezeichnung, M.bezeichnung

-- Rhodos_SWG
SELECT	E.equipementname AS E_equipmentname, 
		M.materialgruppe AS M_materialgruppe, 
		M.sap_bezeichnung AS M_sap_bezeichnung, 
		M.bezeichnung AS M_bezeichnung, 
		L.bestand_aktuell AS L_bestand_aktuell, 
		L.bestand_max AS L_bestand_max,
		L.bestand_min AS L_bestand_min, 		 
		L.sap_bezeichnung AS L_sap_bezeichnung,
		ED.Silo AS ED_Silo,
		ED.lager_id AS ED_lager
FROM tbl_equipement_dosier ED
	INNER JOIN tbl_equipement E ON E.Id = ED.equipement_id
	INNER JOIN tbl_Lager L ON L.Id = ED.lager_id
	INNER JOIN tbl_material M ON L.fid_material = M.id
Where L.aktiv =  1 AND L.aktiv1 = 1

-- Rhodos_SWG
SELECT DISTINCT lager_id FROM [Rodos_SWG].[dbo].[tbl_equipement_dosier] ED
inner join tbl_lager L ON L.ID = ED.lager_id
WHERE L.aktiv = 1 AND L.aktiv =1

SELECT * FROM tbl_lager 
SELECT * FROM tbl_material

-- Rhodos_SWB
SELECT	DISTINCT L.sap_bezeichnung
		--,E.equipementname AS E_equipmentname 
		--,M.materialgruppe AS M_materialgruppe 
		--,M.sap_bezeichnung AS M_sap_bezeichnung 
		--,M.bezeichnung AS M_bezeichnung
		,L.id AS L_id
		--,L.bestand_aktuell AS L_bestand_aktuell 
		--,L.bestand_max AS L_bestand_max
		--,L.bestand_min AS L_bestand_min		 
		--,L.sap_bezeichnung AS L_sap_bezeichnung
		--,ED.Silo AS ED_Silo
		--,ED.lager_id AS ED_lager
FROM 
	tbl_equipement_dosier ED 
	INNER JOIN tbl_equipement E ON E.Id = ED.equipement_id
	INNER JOIN tbl_Lager L ON L.Id = ED.lager_id
	INNER JOIN tbl_material M ON L.fid_material = M.id
WHERE L.aktiv =  1 AND L.aktiv1 = 1 
ORDER BY L.id

#Layout:
 
  - Main page
      https://app.moqups.com/9Pxm92EGu2aTADkX45NgYopDAjEOyRWx/edit/page/ad64222d5
  - Admin area
    https://app.moqups.com/9Pxm92EGu2aTADkX45NgYopDAjEOyRWx/edit/page/ad36aefae
  - Login page
      https://app.moqups.com/9Pxm92EGu2aTADkX45NgYopDAjEOyRWx/edit/page/a7fa57ee6


#Stand wie im Projekt zuvor:
$ git log -1
commit 24a01daf566872bc28f8c4383be89f70376cd82d (HEAD -> master, origin/master, origin/HEAD)
Author: ElenaSolovyeva <elena.solo.mail2014@gmail.com>
Date:   Wed Dec 20 11:19:48 2023 +0100
    Add background color for tables

    
