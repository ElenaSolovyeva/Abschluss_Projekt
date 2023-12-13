SELECT	Material_Bez, 
		chargenanzahl_soll, 
		chargenanzahl_ist, 
		auftrags_gewicht, 
		auftrags_gewicht_ist,
		farb_id,
		line_id,
		start_time

FROM [Rodos_SWB].[dbo].[tbl_dispo] 

WHERE start_time > convert(datetime, '30.07.2023', 105)
and start_time < convert(datetime, '01.08.2023', 105)
and line_id = 0