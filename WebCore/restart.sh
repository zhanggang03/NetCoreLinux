#��/bin/bash
#ֹͣ��̨����
kill -9 `ps -ef | grep dotnet | awk '{print $2}'`
#��ִ̨��
nohup dotnet WebCore.dll >/dev/null 2>&1 &
