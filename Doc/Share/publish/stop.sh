#��/bin/bash
#ֹͣ��̨����
kill -9 `ps -ef | grep dotnet | awk '{print $2}'`
