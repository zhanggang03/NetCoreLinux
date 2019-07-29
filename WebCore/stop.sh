#！/bin/bash
#停止后台服务
kill -9 `ps -ef | grep dotnet | awk '{print $2}'`
