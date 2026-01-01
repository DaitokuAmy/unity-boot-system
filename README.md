# unity-boot-system
Unityでシーンを手順に従って起動サポートするためのシステム
## 概要
#### 特徴
* EntryPointとなるUnityシーンを定め、任意のSceneを再生時に適切にEntoryPoint経由で処理をさせるための機能群
## セットアップ
#### インストール
1. Window > Package ManagerからPackage Managerを開く
2. 「+」ボタン > Add package from git URL
3. 以下を入力してインストール
   * https://github.com/DaitokuAmy/unity-boot-system.git?path=/Packages/com.daitokuamy.unitybootsystem
   ![image](https://user-images.githubusercontent.com/6957962/209446846-c9b35922-d8cb-4ba3-961b-52a81515c808.png)

あるいはPackages/manifest.jsonを開き、dependenciesブロックに以下を追記します。
```json
{
    "dependencies": {
        "com.daitokuamy.gameaibehaviour": "https://github.com/DaitokuAmy/unity-boot-system.git?path=/Packages/com.daitokuamy.unitybootsystem"
    }
}
```
バージョンを指定したい場合には以下のように記述します。  
https://github.com/DaitokuAmy/unity-boot-system.git?path=/Packages/com.daitokuamy.unitybootsystem#1.0.0
