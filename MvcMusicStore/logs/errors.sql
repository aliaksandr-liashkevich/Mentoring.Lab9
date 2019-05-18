SELECT [TEXT] AS Error
INTO %file%_report_errors.xml
FROM %file%
WHERE Text LIKE '%ERROR%'