using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;  // acces erişimini sağlayan kütüphane

namespace Adli_İşlemler
{
    public partial class DvcıEKLE : Form
    {
        public DvcıEKLE()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DvcıEKLE_Load(object sender, EventArgs e)
        {
            Davaci_ID_Geitr(); // bu yordam aşağıda yazılı olduğu gibi otomatik davacı ID si getirmektedir.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private static string baglanti_cumlesi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath.ToString()+"\\ADLİ-İŞLEMLER.accdb;Persist Security Info=False;\r\n";

        //yukarıdak kod ile acces veritabanına bağlandık. acces dosyasının proje de olduğu yerden çektik. site: https://www.connectionstrings.com/access/ çekip editledik


        private OleDbConnection baglan = new OleDbConnection(baglanti_cumlesi); // veri sağlayıcısı aracılığıyla bir veritabanına bağlanmayı sağlar.


        void Davaci_ID_Geitr()  // yordam ekledik ki davacı id sini otomaitk eklemek için.kolay yol,aşağısı yordamın kodları 
        {
            baglan.Close(); // hata almayalım diye bağlanıt açıksa da kapattık

            try // veirtabanı olası bir hata alırsa diye try catch metosu ile engelliyoruz. olası bir hata olarak
            {
                baglan.Open(); // veritabanına bağlantıyı açtık. !!! Kapatmayı unutma.

                string sql_cumle = "select MAX(DavacıID) +1 from Davacı "; // alttaki kodu çalıştıran sql cümlesi, davacıID otomatik 1 arttıracak.
                OleDbCommand cmd = new OleDbCommand(sql_cumle, baglan); // yeni komu girerken kullanılır. / sql cümlesi ve bağlantı cümlesi yazıcaz parantez içine 

                string DavacId = cmd.ExecuteScalar().ToString(); //ExecuteScalar yöntemini kullanarak bir sorguyu çalıştırır ve dönen tek bir değeri textBox1 adlı bir TextBox kontrolünün metin özelliğine atar.
                textBox1.Text = DavacId;
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Items.Clear();
                textBox3.Focus();
                cmd.Dispose();
                baglan.Close(); // bağlantıyı kapattık.
            }

            catch (Exception e) //temel istisna sınıfını temsil eder. Bu, herhangi bir türdeki istisnaları yakalayabilmek için genel bir yakalama mekanizması sağlar.
            {
                MessageBox.Show(e.ToString());
                MessageBox.Show("Davacı ID alınırken veritabanı Hatası alındı");
            }
        }


        private void ekle_Click(object sender, EventArgs e)
        {

        }

        private DataTable Sehir_Getir()             //1 dataset 1 datatable dan oluşmalı. verileri tablo şeklinde yazılır
        {
            DataTable dt = new DataTable();
            try
            {
                string sql_cumle = "select adres from davacı";
                baglan.Open();
                OleDbCommand cmd = new OleDbCommand(sql_cumle, baglan); //sql_cumle, yürütülecek SQL komutunu temsil eden bir dize ve baglan, veritabanı bağlantısını temsil eden OleDbConnection sınıfının bir örneği.
                OleDbDataAdapter da = new OleDbDataAdapter(cmd); //
                da.Fill(dt); //adlığımız bilgileri dt ye aktarır
                cmd.Dispose();
            }

            catch (Exception e)
            {

            }
            return dt;
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
