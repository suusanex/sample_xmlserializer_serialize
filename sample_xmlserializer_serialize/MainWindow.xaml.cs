using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace sample_xmlserializer_serialize
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnBtnTest1(object sender, RoutedEventArgs e)
        {
            //バージョンアップでクラスに変更が入った場合、古いバージョンの文字列を新しいバージョンのクラスへデシリアライズできるかどうかの実験。
            //.NET Framework 4.7.2を使用。
            //前提条件：XmlSerializerは、シリアライズした時のXMLのルート要素が「クラス名」になる。そのため、別のクラスに対してデシリアライズすることができない。このサンプルでは、名前空間を分けることで新旧のクラスのクラス名を同一にしている。
            //変数の追加：デシリアライズ成功。追加された変数は、new時のデフォルト値となった
            //変数の削除：デシリアライズ成功。削除された変数は、無視された。
            //注意点：Listにデフォルト値がある場合、デシリアライズ時に上書きではなく追加される（直観と反する動き）


            var v1 = new Datav1.Data
            {
                child = new Datav1.DataChild()
                {
                    dataChild1 = 2
                },
                data1 = 3,
                data2 = new List<string> { "1", "2" }
            };

            var writer = new StringWriter();
            var serializer_v1 = new XmlSerializer(typeof(Datav1.Data));
            serializer_v1.Serialize(writer, v1);
            var v1str = writer.ToString();

            var serializer_v2 = new XmlSerializer(typeof(Datav2.Data));
            var v2 = (Datav2.Data)serializer_v2.Deserialize(new StringReader(v1str));

            MessageBox.Show($"{nameof(v2.data3)}={v2.data3},{nameof(v2.child2.dataChild1)}={v2.child2?.dataChild1},{nameof(v2.data2)}={string.Join(",", v2.data2)}");

        }
    }
}
