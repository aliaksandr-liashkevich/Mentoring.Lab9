SET logFile=%1
.\LogParser.exe -i "TEXTLINE" file:info.sql?file=%logFile% -o "XML" -filemode 1
.\LogParser.exe -i "TEXTLINE" file:debugs.sql?file=%logFile% -o "XML" -filemode 1
.\LogParser.exe -i "TEXTLINE" file:errors.sql?file=%logFile% -o "XML" -filemode 1
.\LogParser.exe -i "TEXTLINE" file:counts.sql?file=%logFile% -o "XML" -filemode 1