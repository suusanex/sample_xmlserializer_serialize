# sample_xmlserializer_serialize
Code experimenting with several cases of serialization deserialization using XmlSerializer.

バージョンアップでクラスに変更が入った場合、古いバージョンの文字列を新しいバージョンのクラスへデシリアライズできるかどうかの実験。

.NET Framework 4.7.2を使用。

前提条件：XmlSerializerは、シリアライズした時のXMLのルート要素が「クラス名」になる。そのため、別のクラスに対してデシリアライズすることができない。このサンプルでは、名前空間を分けることで新旧のクラスのクラス名を同一にしている。

変数の追加：デシリアライズ成功。追加された変数は、new時のデフォルト値となった

変数の削除：デシリアライズ成功。削除された変数は、無視された。

注意点：Listにデフォルト値がある場合、デシリアライズ時に上書きではなく追加される（直観と反する動き）
