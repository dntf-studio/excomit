
## csvの記述方法

### 親(学校)データ: 

コンマまたは改行で区切ります。

(例): `親1,親2,親3,親4` 

### 子(生徒)データ:

団体の区別はアスタリスク`*`
個体の区別はコンマまたは改行で行います。

(例): `親1の子a,親1の子b*親2の子a,親1の子b` 

## ダウンロード

### zipファイルの解凍(cmd)

1.エクスプローラーからダウンロードフォルダへ移動、パスをコピー

2.`windowsキー+s`で検索フォーム起動、cmdと入力しcmdを起動

3.`cd "(コピーしたパス)"`と入力(`""`は必須)、ダウンロードパスへ移動

4.`call powershell -command "Expand-Archive -Force excomit-master.zip excomit"`で解凍、保存

##### または(gitインストール済みの場合)

1.cmdで保存したいパスへ移動

2.`git clone https://github.com/dntf-studio/excomit`

