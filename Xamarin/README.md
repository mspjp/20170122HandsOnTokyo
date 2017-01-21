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

作成が成功したらNuGetの更新をしましょう
プロジェクト名.UWPを右クリックしてNuGet パッケージの管理を選択しましょう
![img](https://github.com/mspjp/20170122HandsOnTokyo/blob/recoverreadmd/Xamarin/img/NuGet%E7%AE%A1%E7%90%86.png)

ここでおそらく更新プログラムにXamarin.Formsがあると思いますので選択して更新しましょう！
![img](https://github.com/mspjp/20170122HandsOnTokyo/blob/recoverreadmd/Xamarin/img/NuGet%E6%9B%B4%E6%96%B0PNG_LI.jpg)


正しく生成、更新できたか確認するために一旦ビルドしましょう。

下記の画像のようにビルドの設定を変えましょう
![xamarinForms初期ビルド](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/xamarin%E5%88%9D%E6%9C%9F%E3%83%93%E3%83%AB%E3%83%89.jpg)

変更できたらローカルコンピューターの左にある矢印を押して実行しましょう

このような実行結果が得られたらひとまず成功です。
![初期ビルド成功](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/%E5%88%9D%E6%9C%9F%E3%83%93%E3%83%AB%E3%83%89%E6%88%90%E5%8A%9F.PNG)

## 2.画面をデザインしよう

xamarinの開発においても今回はC#とXAMLという2つの言語を使います。

今回編集する箇所は以下の画像のMainPage.xaml内になります。

「ソリューションエクスプローラー」から「自身の作成したプロジェクト名(画像ではsamplexamarin)」内の「MainPage.xaml」をダブルクリックして開きます。

![Xaml編集場所xaml](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/xaml%E7%B7%A8%E9%9B%86%E5%A0%B4%E6%89%80.PNG)

するとXamlエディタが表示されます。

![Xaml開いた](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/xaml%E9%96%8B%E3%81%84%E3%81%9F.PNG)

UWPと違ってXamarinの方はグラフィカルビューがありませんのでご注意ください。

なのでコードを直接記述してレイアウトの編集を行っていきます。


## 2.1 初期に作られたコードを理解しよう！

まずはMainPage.xamlのコードを見てみましょう

![Xaml開いたコード](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/Xaml%E9%96%8B%E3%81%84%E3%81%9F%E3%82%B3%E3%83%BC%E3%83%89.PNG)

ここの7行目~10行目にある

```cs

<Label Text="Welcome to Xamarin Forms!"
         VerticalOptions="Center"
         HorizontalOptions="Center" />

```

このコードによって先ほど実行した画面のWelcome to Xamarin Forms!が表示されています。

この中の

```cs

<Label Text="Welcome to Xamarin Forms!"

```

を

```cs

<Label Text="Hello World!"

```

と変えることで実行画面が以下のようにかわるます

初めに実行したようにローカルコンピューターの右側の三角形を押します。他の設定は変えないでください。

![Hello World ビルド](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/Hello%20World%E3%83%93%E3%83%AB%E3%83%89%E6%88%90%E5%8A%9F.png)

このように変更されたことがわかります。

ここから色々と変えていきましょう

文字の色を変えてみよう！

MainPage.xaml.cs内のLabel x:Name内に

```cs

 TextColor="Blue" FontSize="Medium"

```

を追加してみましょう

TextColorで文字の色を変更でき、FontSizeで文字の大きさを変更できます。自身で好きな値に変更してもらっても大丈夫です。

追加した結果のコードは以下のようになります

```cs

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:helloxamarin"
             x:Class="helloxamarin.MainPage"
             Title="Hello world">
<StackLayout>

  <Button x:Name="button" Text="Button" VerticalOptions="Center" HorizontalOptions="Center" />
  <Label x:Name="labelHelloWorld" Text="Change??"  TextColor="Blue" FontSize="Medium"
         VerticalOptions="Center"        
         HorizontalOptions="Center"/>
  </StackLayout>

</ContentPage>


```

これで起動してみましょう。

![文字色変更](https://github.com/mspjp/20170122HandsOnTokyo/blob/recoverreadmd/Xamarin/img/%E6%96%87%E5%AD%97%E8%89%B2%E5%A4%89%E6%9B%B4.png)

## 2.2 ボタンとラベルを配置してみよう！

MainPage.xaml内の

```cs

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:samplexamarin"
             x:Class="samplexamarin.MainPage">

	<Label Text="Hello World!"
           VerticalOptions="Center"
           HorizontalOptions="Center" />

</ContentPage>

```

を

```cs

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:helloxamarin"
             x:Class="helloxamarin.MainPage"
             Title="Hello world">
  <StackLayout>

  <Button x:Name="button" Text="Button" VerticalOptions="Center" HorizontalOptions="Center" />
  <Label x:Name="labelHelloWorld" Text="Change??"  VerticalOptions="Center" HorizontalOptions="Center"/>
  </StackLayout>

</ContentPage>]

```

に変えましょう。x:Nameというものがありますがこれはx:Class属性というものでコードビハインドとXAMLファイルを紐づけるためのタグとなります。コードビハインドクラスは5行目の             x:Class="helloxamarin.MainPage"によってhelloxamarin.MainPageになることがわかります。

変更したことによって以下のような画像になります。

![xaml画像ビルド](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/xaml%E7%94%BB%E5%83%8F%E3%83%93%E3%83%AB%E3%83%89.png)

## 2.3 ボタンを押したときにラベルを変化させよう！

MainPage.xaml.csを編集していきます。
以下のように編集しましょう

![Mainpage.xamal.cs編集画面](https://github.com/mspjp/20170122HandsOnTokyo/blob/master/Xamarin/img/Mainpage.xaml.cs%E7%B7%A8%E9%9B%86%E7%94%BB%E9%9D%A2.PNG)

上の画像はこのコードを追加したものです。

```cs
button.Clicked += (sender, e) =>
{
    this.labelHelloWorld.Text = "Hello World!";
};

```

上記の式はラムダ式と呼ばれるもので

```

(引数1, 引数2...) => 式

```

で定義されるものでプログラムの書き方のひとつになります。


コードの記入ができたら実行してみましょう

![xamlラベル変更ビルド](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/xaml%E3%83%A9%E3%83%99%E3%83%AB%E5%A4%89%E6%9B%B4%E7%94%BB%E9%9D%A2.png)

上の画像はクリックした結果になります。

クリックしてラベルの文字が変更されれば成功です。

何かエラーが発生した場合はメンターに質問してください。
