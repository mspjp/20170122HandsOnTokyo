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

## 2.画面をデザインしよう

xamarinの開発においても今回はC#とXAMLという2つの言語を使います。

今回編集する箇所は以下の画像のMainPage.xaml内になります。

「ソリューションエクスプローラー」から「自身の作成したプロジェクト名(画像ではsamplexamarin)」内の「MainPage.xaml」をダブルクリックして開きます。

![Xaml編集場所xaml](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/xaml%E7%B7%A8%E9%9B%86%E5%A0%B4%E6%89%80.PNG)

するとXamlエディタが表示されます。

![Xaml開いた](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/xaml%E9%96%8B%E3%81%84%E3%81%9F.PNG)

UWPと違ってXamarinの方はグラフィカルビューがありませんのでご注意ください。

なのでコードを直接記述してレイアウトの編集を行っていきます。


### 2.1 初期に作られたコードを理解しよう！

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

### 2.2 ボタンとラベルを配置してみよう！

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

  <Button x:Name="Button" Text="Button" VerticalOptions="Center" HorizontalOptions="Center" />
  <Label x:Name="labelHelloWorld" Text="Change??"  VerticalOptions="Center" HorizontalOptions="Center"/>
  </StackLayout>

</ContentPage>]

```

に変えましょう。x:Nameというものがありますがこれはx:Class属性というものでコードビハインドとXAMLファイルを紐づけるためのタグとなります。コードビハインドクラスは5行目の             x:Class="helloxamarin.MainPage"によってhelloxamarin.MainPageになることがわかります。

変更したことによって以下のような画像になります。

![xaml画像ビルド](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/xaml%E7%94%BB%E5%83%8F%E3%83%93%E3%83%AB%E3%83%89.png)

### 2.3 ボタンを押したときにラベルを変化させよう！

MainPage.xaml.csを編集していきます。
以下のように編集しましょう

![Mainpage.xamal.cs編集画面](https://github.com/mspjp/20170122HandsOnTokyo/blob/addxamarinreadmd/Xamarin/img/Xaml%E9%96%8B%E3%81%84%E3%81%9F%E3%82%B3%E3%83%BC%E3%83%89.PNG)

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


# 発展課題1 Githubのリポジトリ一覧をラベルに表示する
昨今のアプリケーションではインターネットが当たり前となり、ネットからデータを取得したり、サーバとやり取りを行うことが少なくありません。
この課題ではその一例として「ボタン」を押すと、GithubのAPIと接続し「エントリ」で指定したユーザのリポジトリ一覧を「ラベル」に表示するものを作成します。


## 1. エントリの追加
基本課題にコンポーネントを追加していきます。
今回は文字入力を行う事ができるコンポーネントであるエントリ(Entry)を追加します。

MainPage.xamlに以下のようになるように編集します.

``` MainPage.xaml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:helloxamarin"
             x:Class="helloxamarin.MainPage"
             Title="Hello world">
  <StackLayout>
    <Entry /> <!-- Added  -->
    <Button x:Name="Button" Text="Button" VerticalOptions="Center" HorizontalOptions="Center" />
    <Label x:Name="labelHelloWorld" Text="Change??"  VerticalOptions="Center" HorizontalOptions="Center"/>
  </StackLayout>
</ContentPage>
```

さらにC#コード側から操作できるようにコンポーネントに名前をつけます.ここでは`Entry`という名前をつけることにします。

``` MainPage.xaml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:helloxamarin"
             x:Class="helloxamarin.MainPage"
             Title="Hello world">
  <StackLayout>
    <Entry x:Name="Entry" /> <!-- Added  -->
    <Button x:Name="Button" Text="Button" VerticalOptions="Center" HorizontalOptions="Center" />
    <Label x:Name="labelHelloWorld" Text="Change??"  VerticalOptions="Center" HorizontalOptions="Center"/>
  </StackLayout>
</ContentPage>
```

余裕があればプロパティを変更して自分好みのUIに仕上げましょう!

Androidの場合はこんな感じになるはずです。

図 Android Debug


## 2. エントリに入力された文字を取得する

続けてエントリに入力された文字列を取得します。
ここではここでは実際に取得できたことを確認するため、`ボタン`を押すと、`エントリ`に入力された文字が`ラベル`に表示される物を作ります。

ボタンのクリックイベントが起きた時に呼び出される`button_Click`メソッドを変更します。

```MainPage.xaml.cs
private async void Button_ClickedAsync(object sender, EventArgs e)
{
    var name = this.Entry.Text;
    this.Label.Text = name; 
}
```

まずメソッドの`void`の前に非同期処理を示す`async`キーワードを追加します。
さらに非同期処理を行う関数なので関数名を`Button_Clicked`から`Button_ClickedAsync`に変更します。(これは可読性を上げるためですのでやらなくてもOKです)

そしてコンストラクタに変更を加えます。

```MainPage.xaml.cs
public MainPage()
{
    InitializeComponent();
    this.Button.Clicked += Button_ClickedAsync; // changed
}
```

エントリに入力された文字はEntryプロパティに格納されているので、これを取り出し、ラベルのTextプロパティにセットします。
こうすることでエントリに入力された文字列がラベル上に表示されます。

この状態でアプリケーションを立ち上げ、エントリに文字を入力しボタンを押すと図のようにラベルに同じ文字が表示されます。

## 3. GithubのAPIを呼び出す
次は実際にGithubのAPIを呼び出し、指定したユーザのリポジトリ一覧を取得します。

今回利用するAPIのエンドポイント(接続URL)は
[https://api.github.com/users/ユーザー名/repos](https://api.github.com/users/ユーザー名/repos)

実際にブラウザでアクセスしてみると指定したユーザのリポジトリ一覧がjson形式で返ってきます。

今回はGithubのAPIサーバーを呼び出すのにHttpClientクラスを利用します。
このクラスはブラウザのようにHTTPサーバーに接続し、データを受信できるクラスです。

まずはMainPage.xaml.csにGithubのAPIを呼び出し、呼び出した結果を取得するメソッドを作成します。

```MainPage.xaml.cs
public async Task<string> GetGithubRepos(string userName)
{
    /*これから実装*/
}
```
UWPの発展課題に挑戦した方ならお気づきだと思いますが、GithubのAPIと接続するソースコードはUWPと共有することができます.

これから作成する関数は検索するユーザ名を引数とし、取得結果をstring型で返却する非同期関数です。

今回はネットワーク等結果が得られるか不確定な部分があるので、try-catchという手法を用います。

```MainPage.xaml.cs
try
{

}
catch(Exception e)
{

}
```
これを記述することでtryブロックに含まれるソースコードが、実行中にエラーが起きた場合、アプリケーションが落ちるのを防いでくれます。
ここから先のコードはtryブロックの内部に記述していきます。

次にHttpClientクラスのインスタンスを作成し設定を行います。HttpClientは処理が終わったらきちんと解放したいためusingブロックを用います。
これを用いることで処理が終わった後に自動的にCloseしてくれます。
```MainPage.xaml.cs
using(httpClient = new HttpClient())
{
  httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2;WOW64; Trident / 6.0)");
}
```
GithubのAPIではHTTPヘッダにユーザエージェントを指定することが必須となっているため、3行目にてその設定を行っています。

次にURLを作成します。
```MainPage.xaml.cs
var url = string.Format("https://api.github.com/users/{0}/repos", userName);
```

文字列結合の方法は複数存在しますが今回はstring.Formatを使用します。
そしてにGetStringAsyncメソッドを用いて結果を取得します。

```MainPage.xaml.cs
return await httpClient.GetStringAsync(url);
```

最後にエラーが発生した場合にエラーメッセージを表示したいのでcatchブロックの中に以下を記述します。

```MainPage.xaml.cs
await DisplayAlert("Error", e.ToString(), "OK");
```

ここまでをまとめるとGetGithubReposメソッドは以下のようになります。
```MainPage.xaml.cs
public async Task<string> GetGithubRepos(string userName)
{                                  
    try
    {
        using (var httpClient = new HttpClient())
        {
            httpClient.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2;WOW64; Trident / 6.0)");
            return await httpClient.GetStringAsync(string.Format("https://api.github.com/users/{0}/repos", userName));
        }
    }
    catch (Exception e)
    {
        await DisplayAlert("Error", e.ToString(), "OK");       
    }   
}

```
このメソッドを先程修正したButton_ClickedAsyncメソッドの中で呼び出してやればテキストボックスに指定したユーザーのGithubのリポジトリ一覧を含むjsonがテキストブロックに表示されます。

```MainPage.xaml.cs
private async void Button_ClickedAsync(object sender, EventArgs e)
{
    var name = this.Entry.Text;
    var result = await GetGithubRepos(name); 
    this.Label.Text = result;
}
```
このこまで実装した状態で、実行し、テキストボックスにGithubのユーザー名を入力してボタンを押すと以下のようになります。

図　実行時

















