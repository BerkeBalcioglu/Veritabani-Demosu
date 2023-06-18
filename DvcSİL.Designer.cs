namespace Adli_İşlemler
{
    partial class DvcSİL
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
            il=new ComboBox();
            label2=new Label();
            label1=new Label();
            textBox3=new TextBox();
            textBox2=new TextBox();
            textBox1=new TextBox();
            label4=new Label();
            ıd=new Label();
            soyadı=new Label();
            adı=new Label();
            SuspendLayout();
            // 
            // il
            // 
            il.FormattingEnabled=true;
            il.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkâri", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" });
            il.Location=new Point(99, 128);
            il.Name="il";
            il.Size=new Size(121, 23);
            il.TabIndex=19;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(31, 131);
            label2.Name="label2";
            label2.Size=new Size(51, 15);
            label2.TabIndex=18;
            label2.Text="Dava İli :";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(31, 172);
            label1.Name="label1";
            label1.Size=new Size(670, 15);
            label1.TabIndex=17;
            label1.Text="!! KULANICI HAKLARI NEDENİ İLE KİMLİK BİLGİSİ SORMAYINIZ ONUN YERİNE SİZLERE ATANAN DAVALI ID Sİ İLE İŞLEM YAPINIZ";
            // 
            // textBox3
            // 
            textBox3.Location=new Point(99, 28);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(114, 23);
            textBox3.TabIndex=16;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(99, 57);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(114, 23);
            textBox2.TabIndex=15;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(99, 88);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(114, 23);
            textBox1.TabIndex=14;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(31, 131);
            label4.Name="label4";
            label4.Size=new Size(10, 15);
            label4.TabIndex=13;
            label4.Text=" ";
            // 
            // ıd
            // 
            ıd.AutoSize=true;
            ıd.Location=new Point(31, 91);
            ıd.Name="ıd";
            ıd.Size=new Size(65, 15);
            ıd.TabIndex=12;
            ıd.Text="Davaci ID : ";
            // 
            // soyadı
            // 
            soyadı.AutoSize=true;
            soyadı.Location=new Point(31, 60);
            soyadı.Name="soyadı";
            soyadı.Size=new Size(48, 15);
            soyadı.TabIndex=11;
            soyadı.Text="Soyadı :";
            // 
            // adı
            // 
            adı.AutoSize=true;
            adı.Location=new Point(31, 30);
            adı.Name="adı";
            adı.Size=new Size(31, 15);
            adı.TabIndex=10;
            adı.Text="Adı :";
            // 
            // DvcSİL
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(il);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(ıd);
            Controls.Add(soyadı);
            Controls.Add(adı);
            Name="DvcSİL";
            Text="DvcSİL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox il;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label ıd;
        private Label soyadı;
        private Label adı;
    }
}