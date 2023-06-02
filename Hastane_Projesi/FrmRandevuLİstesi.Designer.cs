namespace Hastane_Projesi
{
    partial class FrmRandevuLİstesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuLİstesi));
            this.DgwRandevuListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgwRandevuListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // DgwRandevuListesi
            // 
            this.DgwRandevuListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwRandevuListesi.BackgroundColor = System.Drawing.Color.White;
            this.DgwRandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwRandevuListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgwRandevuListesi.Location = new System.Drawing.Point(0, 0);
            this.DgwRandevuListesi.Name = "DgwRandevuListesi";
            this.DgwRandevuListesi.Size = new System.Drawing.Size(1304, 631);
            this.DgwRandevuListesi.TabIndex = 0;
            this.DgwRandevuListesi.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // FrmRandevuLİstesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1304, 631);
            this.Controls.Add(this.DgwRandevuListesi);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmRandevuLİstesi";
            this.Text = "Randevu Lİstesi";
            this.Load += new System.EventHandler(this.FrmRandevuLİstesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwRandevuListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwRandevuListesi;
    }
}