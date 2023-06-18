using System.Security.Cryptography;

namespace Adli_İşlemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void davalıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void davacıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DvcıEKLE frm = new DvcıEKLE();  //davacı formunu seçilen kategoriye ekler.
            frm.MdiParent = this; //MDI ana formunun bir çocuk formu olarak belirlemek için kullanılır
            frm.Dock = DockStyle.Fill; //tam dock boyutunda yapar.
            frm.Show(); //formu görünür kılar.
            // yukarıdaki kodlar ile açılan yeni formu ana ekran yerine yeni form koyarak açar.
            
        }

        private void davacıSilGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DvcSİL frm = new DvcSİL();  //davacı formunu seçilen kategoriye ekler.
            frm.MdiParent = this; //MDI ana formunun bir çocuk formu olarak belirlemek için kullanılır
            frm.Dock = DockStyle.Fill; //tam dock boyutunda yapar.
            frm.Show(); //formu görünür kılar.


        }
    }
}