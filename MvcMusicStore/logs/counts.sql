SELECT SUBSTR([TEXT], 25, 5) AS LogLevel, COUNT([TEXT]) AS TotalCount
INTO %file%_report_counts.xml
FROM %file%
GROUP BY LogLevel
HAVING TRIM(LogLevel) = 'INFO' OR LogLevel = 'DEBUG' OR LogLevel = 'ERROR'