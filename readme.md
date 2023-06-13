# readme

## slackアプリの作成

1. https://api.slack.com/appsにアクセス
2. 「Create New App」をクリック
3. 以下のように入力して「Create App」をクリック
    - App Name: 任意
    - Development Slack Workspace: 任意
4. 「OAuth & Permissions」をクリック
5. Scopesの「Bot Token Scopes」に権限を追加
    - chat:write
    - files:write
6. 「Install to Workspace」をクリック
7. 「Allow」をクリック

## チャンネルへslackアプリを追加

1. チャンネル名の右クリックの「チャンネル詳細を開く → インテグレーション → アプリを追加」でslackアプリを追加。

## API使用

- https://api.slack.com/methods
- https://api.slack.com/methods/chat.postMessage
- https://api.slack.com/methods/files.upload

