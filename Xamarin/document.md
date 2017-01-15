# Microsoftプログラミング技術全国ハンズオン Xamarin編 資料

## 1.注意事項
このハンズオンを行うには以下の環境が必要になります。

・Windows10搭載のPC(Macの方はOSを最新の状態に)

・Windowsの方はVisual Studio Community 2015(もしくはそれ以上のエディション)Macの方はxamarinstudio

・xamarinFormsアプリ開発ツール

準備ができていない方はお近くのスタッフに声をかけてください。

## 2. ファイル構成
xamarin編のフォルダーには以下のものが含まれます。


# 課題 ボタンを押して文字を変えてみよう！

## 1.まずはプロジェクトを作ってみようxamarin編
インストールされたVisual Studioを起動します。起動したら以下の画面が立ち上がります
![VS起動画面](https://github.com/mspjp/20170122HandsOnTokyo/blob/mmitti/add_uwp_document/UWP/img/1-1/1.png)

続けてメニューの「ファイル(F)」から「新規作成(N)」を選択し、「プロジェクト(P)」を選択します。

プロジェクトのテンプレートを選択するダイアログが表示されます。
今回はVisualC#内のCloss-Platform内のBlank Xaml App(Xamarin.FormsShared)
を選択しOKを押しましょう名前はなんでもかまいません。
![VSプロジェクト作成画面](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/2017-01-15.png)

作成時間に時間がかかるので少々お待ちください。

作成時にこのような画面が出るかと思いますがskipしてください
![vsformac](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/vsformac.png)

Windows10のどのバージョン向けにプロジェクトを作成するか聞かれるのでデフォルトのまま「OK」を押します。

![img](https://github.com/mspjp/20170122HandsOnTokyo/blob/mmitti/add_uwp_document/UWP/img/1-1/5.png)

時間がたてばこのような画面が表示されると思います。
![xamarinForms作成成功画面](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/xamarinforms%E4%BD%9C%E6%88%90%E7%94%BB%E9%9D%A2.png)

このような画面が作成されればプロジェクトの作成は成功です。

正しく生成できたか確認するために一旦ビルドしましょう。

下記の画像のようにビルドの設定を変えましょう
![xamarinForms初期ビルド](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/xamarin%E5%88%9D%E6%9C%9F%E3%83%93%E3%83%AB%E3%83%89.jpg)

変更できたらローカルコンピューターの左にある矢印を押して実行しましょう

このような実行結果が得られたらひとまず成功です。
![初期ビルド成功](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/%E5%88%9D%E6%9C%9F%E3%83%93%E3%83%AB%E3%83%89%E6%88%90%E5%8A%9F.PNG)
