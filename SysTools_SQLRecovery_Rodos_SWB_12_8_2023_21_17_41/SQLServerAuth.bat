sqlcmd -U %1 -P %2 -S %3 -d %4 -i UserDefinedDatatypes.sql
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\__MigrationHistory_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\__MigrationHistory_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\__MigrationHistory_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\QMImport_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\QMImport_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\QMImport_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\QMProdDataImport_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\QMProdDataImport_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\QMProdDataImport_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_EDI_DC40_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_EDI_DC40_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_EDI_DC40_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Log_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Log_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Log_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_RoDocument_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_RoDocument_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_RoDocument_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2AFKOL000_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2AFKOL000_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2AFKOL000_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2AFVOL000_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2AFVOL000_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2AFVOL000_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2CONF000_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2CONF000_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2CONF000_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2GOODS000_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2GOODS000_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2GOODS000_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2MATNR000_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2MATNR000_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2MATNR000_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2RFMAT000_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2RFMAT000_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2RFMAT000_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2STAT000_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2STAT000_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2STAT000_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2TLINE000_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2TLINE000_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAP_Z2TLINE000_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAPV3_AFKOL_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAPV3_AFKOL_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAPV3_AFKOL_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAPV3_AFVOL_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAPV3_AFVOL_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAPV3_AFVOL_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAPV3_EAN11_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAPV3_EAN11_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAPV3_EAN11_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAPV3_TLINE_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAPV3_TLINE_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\SAPV3_TLINE_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_aktueller_auftrag_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_aktueller_auftrag_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_aktueller_auftrag_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_batch_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_batch_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_batch_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_batch_gruppe_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_batch_gruppe_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_batch_gruppe_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_batch_position_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_batch_position_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_batch_position_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_buchungen_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_buchungen_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_buchungen_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_con_mat_stu_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_con_mat_stu_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_con_mat_stu_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_farbb_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_farbb_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_farbb_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_position_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_position_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_position_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_position_farbb_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_position_farbb_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_position_farbb_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_swb_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_swb_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_swb_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_zeiten_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_zeiten_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_dispo_zeiten_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_equipement_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_equipement_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_equipement_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_equipement_dosier_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_equipement_dosier_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_equipement_dosier_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_equipement_parameter_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_equipement_parameter_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_equipement_parameter_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_gebinde_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_gebinde_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_gebinde_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_Handzugaben_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_Handzugaben_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_Handzugaben_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_Handzugaben_farbb_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_Handzugaben_farbb_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_Handzugaben_farbb_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_kontaminierung_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_kontaminierung_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_kontaminierung_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_lager_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_lager_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_lager_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_lagergruppen_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_lagergruppen_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_lagergruppen_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_laufzeit_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_laufzeit_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_laufzeit_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_liste1_preis_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_liste1_preis_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_liste1_preis_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_material_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_material_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_material_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_misc_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_misc_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_misc_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_protokoll_position_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_protokoll_position_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_protokoll_position_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_stueckliste_historie_kopf_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_stueckliste_historie_kopf_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_stueckliste_historie_kopf_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_stueckliste_historie_position_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_stueckliste_historie_position_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_stueckliste_historie_position_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_stueckliste_position_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_stueckliste_position_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_stueckliste_position_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_technologiclasse_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_technologiclasse_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_technologiclasse_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_user_bedinung_0.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_user_bedinung_1.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i "Tables\tbl_user_bedinung_Constraint.sql"
sqlcmd -U %1 -P %2 -S %3 -d %4 -i foreignKey.sql
sqlcmd -U %1 -P %2 -S %3 -d %4 -i Temp_Stored_Procedure.sql
sqlcmd -U %1 -P %2 -S %3 -d %4 -i Views.sql
sqlcmd -U %1 -P %2 -S %3 -d %4 -i Stored_Procedure.sql 
