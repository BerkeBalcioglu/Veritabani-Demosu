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
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(12, 92);
            label1.Name="label1";
            label1.Size=new Size(31, 15);
            label1.TabIndex=0;
            label1.Text="Adı :";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(115, 92);
            label2.Name="label2";
            label2.Size=new Size(51, 15);
            label2.TabIndex=1;
            label2.Text=" Soyadı :";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(256, 54);
            label3.Name="label3";
            label3.Size=new Size(38, 15);
            label3.TabIndex=2;
            label3.Text="label3";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(317, 54);
            label4.Name="label4";
            label4.Size=new Size(38, 15);
            label4.TabIndex=3;
            label4.Text="label4";
            // 
            // DvcıEKLE
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="DvcıEKLE";
            Text="DvcıEKLE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}