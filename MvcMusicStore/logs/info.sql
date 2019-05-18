SELECT [TEXT] AS Info
INTO %file%_report_info.xml
FROM %file%
WHERE Text LIKE '%INFO%'