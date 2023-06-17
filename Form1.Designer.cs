namespace Adli_İşlemler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1=new MenuStrip();
            davalıToolStripMenuItem=new ToolStripMenuItem();
            davalıEkleToolStripMenuItem=new ToolStripMenuItem();
            davalıSilToolStripMenuItem=new ToolStripMenuItem();
            davacıToolStripMenuItem=new ToolStripMenuItem();
            davacıEkleToolStripMenuItem=new ToolStripMenuItem();
            davacıSilGüncelleToolStripMenuItem=new ToolStripMenuItem();
            hakimToolStripMenuItem=new ToolStripMenuItem();
            hakimEkleToolStripMenuItem=new ToolStripMenuItem();
            hakimSilGüncelleToolStripMenuItem=new ToolStripMenuItem();
            çıkışToolStripMenuItem=new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { davalıToolStripMenuItem, davacıToolStripMenuItem, hakimToolStripMenuItem, çıkışToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(1226, 24);
            menuStrip1.TabIndex=1;
            menuStrip1.Text="menuStrip1";
            menuStrip1.ItemClicked+=menuStrip1_ItemClicked;
            // 
            // davalıToolStripMenuItem
            // 
            davalıToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { davalıEkleToolStripMenuItem, davalıSilToolStripMenuItem });
            davalıToolStripMenuItem.Name="davalıToolStripMenuItem";
            davalıToolStripMenuItem.Size=new Size(51, 20);
            davalıToolStripMenuItem.Text="Davalı";
            // 
            // davalıEkleToolStripMenuItem
            // 
            davalıEkleToolStripMenuItem.Name="davalıEkleToolStripMenuItem";
            davalıEkleToolStripMenuItem.Size=new Size(172, 22);
            davalıEkleToolStripMenuItem.Text="Davalı Ekle";
            // 
            // davalıSilToolStripMenuItem
            // 
            davalıSilToolStripMenuItem.Name="davalıSilToolStripMenuItem";
            davalıSilToolStripMenuItem.Size=new Size(172, 22);
            davalıSilToolStripMenuItem.Text="Davalı Sil/Güncelle";
            davalıSilToolStripMenuItem.Click+=davalıSilToolStripMenuItem_Click;
            // 
            // davacıToolStripMenuItem
            // 
            davacıToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { davacıEkleToolStripMenuItem, davacıSilGüncelleToolStripMenuItem });
            davacıToolStripMenuItem.Name="davacıToolStripMenuItem";
            davacıToolStripMenuItem.Size=new Size(54, 20);
            davacıToolStripMenuItem.Text="Davacı";
            // 
            // davacıEkleToolStripMenuItem
            // 
            davacıEkleToolStripMenuItem.Name="davacıEkleToolStripMenuItem";
            davacıEkleToolStripMenuItem.Size=new Size(180, 22);
            davacıEkleToolStripMenuItem.Text="Davacı Ekle";
            davacıEkleToolStripMenuItem.Click+=davacıEkleToolStripMenuItem_Click;
            // 
            // davacıSilGüncelleToolStripMenuItem
            // 
            davacıSilGüncelleToolStripMenuItem.Name="davacıSilGüncelleToolStripMenuItem";
            davacıSilGüncelleToolStripMenuItem.Size=new Size(180, 22);
            davacıSilGüncelleToolStripMenuItem.Text="Davacı Sil/Güncelle";
            davacıSilGüncelleToolStripMenuItem.Click+=davacıSilGüncelleToolStripMenuItem_Click;
            // 
            // hakimToolStripMenuItem
            // 
            hakimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakimEkleToolStripMenuItem, hakimSilGüncelleToolStripMenuItem });
            hakimToolStripMenuItem.Name="hakimToolStripMenuItem";
            hakimToolStripMenuItem.Size=new Size(54, 20);
            hakimToolStripMenuItem.Text="Hakim";
            // 
            // hakimEkleToolStripMenuItem
            // 
            hakimEkleToolStripMenuItem.Name="hakimEkleToolStripMenuItem";
            hakimEkleToolStripMenuItem.Size=new Size(175, 22);
            hakimEkleToolStripMenuItem.Text="Hakim Ekle";
            // 
            // hakimSilGüncelleToolStripMenuItem
            // 
            hakimSilGüncelleToolStripMenuItem.Name="hakimSilGüncelleToolStripMenuItem";
            hakimSilGüncelleToolStripMenuItem.Size=new Size(175, 22);
            hakimSilGüncelleToolStripMenuItem.Text="Hakim Sil/Güncelle";
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name="çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size=new Size(44, 20);
            çıkışToolStripMenuItem.Text="Çıkış";
            çıkışToolStripMenuItem.Click+=çıkışToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AccessibleRole=AccessibleRole.MenuBar;
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1226, 660);
            Controls.Add(menuStrip1);
            IsMdiContainer=true;
            MainMenuStrip=menuStrip1;
            Name="Form1";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Adli İşlemler";
            Load+=Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem davalıToolStripMenuItem;
        private ToolStripMenuItem davalıEkleToolStripMenuItem;
        private ToolStripMenuItem davalıSilToolStripMenuItem;
        private ToolStripMenuItem davacıToolStripMenuItem;
        private ToolStripMenuItem hakimToolStripMenuItem;
        private ToolStripMenuItem davacıEkleToolStripMenuItem;
        private ToolStripMenuItem davacıSilGüncelleToolStripMenuItem;
        private ToolStripMenuItem hakimEkleToolStripMenuItem;
        private ToolStripMenuItem hakimSilGüncelleToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
    }
}