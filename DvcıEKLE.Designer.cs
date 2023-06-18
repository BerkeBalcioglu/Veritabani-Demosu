namespace Adli_İşlemler
{
    partial class DvcıEKLE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container();
            contextMenuStrip1=new ContextMenuStrip(components);
            comboBox1=new ComboBox();
            adı=new Label();
            soyadı=new Label();
            ıd=new Label();
            label4=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            label1=new Label();
            label2=new Label();
            ekle=new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size(61, 4);
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle=FlatStyle.Flat;
            comboBox1.FormattingEnabled=true;
            comboBox1.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkâri", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" });
            comboBox1.Location=new Point(84, 125);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(114, 23);
            comboBox1.Sorted=true;
            comboBox1.TabIndex=13;
            comboBox1.SelectedIndexChanged+=comboBox1_SelectedIndexChanged_1;
            // 
            // adı
            // 
            adı.AutoSize=true;
            adı.Location=new Point(16, 27);
            adı.Name="adı";
            adı.Size=new Size(31, 15);
            adı.TabIndex=0;
            adı.Text="Adı :";
            adı.Click+=label1_Click;
            // 
            // soyadı
            // 
            soyadı.AutoSize=true;
            soyadı.Location=new Point(16, 57);
            soyadı.Name="soyadı";
            soyadı.Size=new Size(48, 15);
            soyadı.TabIndex=1;
            soyadı.Text="Soyadı :";
            // 
            // ıd
            // 
            ıd.AutoSize=true;
            ıd.Location=new Point(16, 88);
            ıd.Name="ıd";
            ıd.Size=new Size(65, 15);
            ıd.TabIndex=2;
            ıd.Text="Davaci ID : ";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(16, 128);
            label4.Name="label4";
            label4.Size=new Size(10, 15);
            label4.TabIndex=3;
            label4.Text=" ";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(84, 85);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(114, 23);
            textBox1.TabIndex=4;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(84, 54);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(114, 23);
            textBox2.TabIndex=5;
            // 
            // textBox3
            // 
            textBox3.Location=new Point(84, 25);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(114, 23);
            textBox3.TabIndex=6;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(12, 208);
            label1.Name="label1";
            label1.Size=new Size(617, 15);
            label1.TabIndex=7;
            label1.Text="!! KULANICI HAKLARI NEDENİ İLE KİMLİK BİLGİSİ SORMAYINIZ ONUN YERİNE SİZLERE ATANAN ID İLE İŞLEM YAPINIZ";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(16, 128);
            label2.Name="label2";
            label2.Size=new Size(51, 15);
            label2.TabIndex=8;
            label2.Text="Dava İli :";
            // 
            // ekle
            // 
            ekle.Location=new Point(84, 164);
            ekle.Name="ekle";
            ekle.Size=new Size(121, 28);
            ekle.TabIndex=10;
            ekle.Text="Davacı Ekle";
            ekle.UseVisualStyleBackColor=true;
            ekle.Click+=ekle_Click;
            // 
            // DvcıEKLE
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(ekle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(ıd);
            Controls.Add(soyadı);
            Controls.Add(adı);
            Name="DvcıEKLE";
            Text="DvcıEKLE";
            Load+=DvcıEKLE_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox1;
        private Label adı;
        private Label soyadı;
        private Label ıd;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Button ekle;
    }
}