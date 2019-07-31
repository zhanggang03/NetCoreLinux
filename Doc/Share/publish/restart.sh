#！/bin/bash
#停止后台服务
kill -9 `ps -ef | grep dotnet | awk '{print $2}'`
#后台执行
nohup dotnet WebCore.dll >/dev/null 2>&1 &
