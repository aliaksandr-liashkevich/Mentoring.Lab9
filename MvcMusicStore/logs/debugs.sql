SELECT [TEXT] AS Debug
INTO %file%_report_debugs.xml
FROM %file%
WHERE Text LIKE '%DEBUG%'