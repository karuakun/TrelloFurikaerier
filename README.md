# コレは何？
Trelloで振り返りをしたんだけれど、やっぱりプレーンテキストにエクスポートしたい。
だけれど、無料のTrelloで出力できるのはJSONファイルだけ。
ボードごとのタイトルと、その発言を作成した人の単純なリストをマークダウン形式で出力するためのツールです。

# 使い方
使い方はこんな感じで
```
dotnet run appSettings:TrelloExportFile=trelloexport.json
```

発言した人はいらないという場合は、こんな感じで
```
dotnet run appSettings:TrelloExportFile=trelloexport.json appSettings:showUser=false
```

Backlog 記法で出したい場合は、こんな感じでデフォルトは `markdown`
```
dotnet run appSettings:TrelloExportFile=trelloexport.json appSettings:format=backlog
```

# DTO出力用に使ったツール
Trelloの出力ファイルを、http://json2csharp.com/ を使ってDTOにしました。