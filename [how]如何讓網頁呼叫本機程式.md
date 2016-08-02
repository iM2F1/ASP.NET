## 如何讓網頁呼叫本機程式##
原本很天真的想經由網頁直接呼叫本地端程式
System.Diagnostics.Process.Start

對我這個不熟網頁程式的人來說，這想法很自然卻也太天真了。
後來找到方法另外的解法，如連結。

[Reference](http://carolhsu.github.io/blog/2013/07/31/how-to-open-local-application-via-website-url/)
[從網頁呼叫使用者電腦應用程式](http://kmmr.pixnet.net/blog/post/34454099-%E5%BE%9E%E7%B6%B2%E9%A0%81%E5%91%BC%E5%8F%AB%E4%BD%BF%E7%94%A8%E8%80%85%E9%9B%BB%E8%85%A6%E6%87%89%E7%94%A8%E7%A8%8B%E5%BC%8F)
[Registering an Application to a URL Protocol](https://msdn.microsoft.com/en-us/library/Aa767914.aspx)

###方式
####產生一個 reg 檔
```
Windows Registry Editor Version 5.00


[HKEY_CLASSES_ROOT\EleOutputMap]
@="URL:EleOutputGraph Protocol"     
# 註冊 protocol "EleOutputMap"
"URL Protocol"=""


[HKEY_CLASSES_ROOT\EleOutputMap\DefaultIcon]
@="D:\\App\\Fortune\\bin\\EleOutputGraph.exe"
# 程式 EleOutputGraph.exe 的路徑

[HKEY_CLASSES_ROOT\EleOutputMap\shell]
@=""


[HKEY_CLASSES_ROOT\EleOutputMap\shell\open]
@=""


[HKEY_CLASSES_ROOT\EleOutputMap\shell\open\command]
@="D:\\App\\Fortune\\bin\\EleOutputGraph.exe \"%1\""
# 這裡會打開 shell 執行命令，"%1" 可以將URL本身傳為 EleOutputMap.exe 的外部參數
```
傳入的網址可以當參數，有空格依然會視為同一個參數，最後會加上\
