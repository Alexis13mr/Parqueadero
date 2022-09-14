
namespace Parqueadero
{
    partial class IngCli
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
            this.dgcli = new System.Windows.Forms.DataGridView();
            this.lbtit1 = new System.Windows.Forms.Label();
            this.lbtit2 = new System.Windows.Forms.Label();
            this.lbtit3 = new System.Windows.Forms.Label();
            this.txCed = new System.Windows.Forms.TextBox();
            this.txNom = new System.Windows.Forms.TextBox();
            this.txTel = new System.Windows.Forms.TextBox();
            this.lbtit = new System.Windows.Forms.Label();
            this.btselct = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgcli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcli
            // 
            this.dgcli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgcli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgcli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcli.Location = new System.Drawing.Point(12, 35);
            this.dgcli.Name = "dgcli";
            this.dgcli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgcli.Size = new System.Drawing.Size(287, 150);
            this.dgcli.TabIndex = 0;
            this.dgcli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcli_CellClick);
            // 
            // lbtit1
            // 
            this.lbtit1.AutoSize = true;
            this.lbtit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtit1.Location = new System.Drawing.Point(9, 237);
            this.lbtit1.Name = "lbtit1";
            this.lbtit1.Size = new System.Drawing.Size(84, 17);
            this.lbtit1.TabIndex = 1;
            this.lbtit1.Text = "Documento:";
            // 
            // lbtit2
            // 
            this.lbtit2.AutoSize = true;
            this.lbtit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtit2.Location = new System.Drawing.Point(9, 211);
            this.lbtit2.Name = "lbtit2";
            this.lbtit2.Size = new System.Drawing.Size(62, 17);
            this.lbtit2.TabIndex = 2;
            this.lbtit2.Text = "Nombre:";
            // 
            // lbtit3
            // 
            this.lbtit3.AutoSize = true;
            this.lbtit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtit3.Location = new System.Drawing.Point(9, 263);
            this.lbtit3.Name = "lbtit3";
            this.lbtit3.Size = new System.Drawing.Size(68, 17);
            this.lbtit3.TabIndex = 3;
            this.lbtit3.Text = "Telefono:";
            // 
            // txCed
            // 
            this.txCed.Location = new System.Drawing.Point(99, 237);
            this.txCed.MaxLength = 11;
            this.txCed.Name = "txCed";
            this.txCed.Size = new System.Drawing.Size(85, 20);
            this.txCed.TabIndex = 4;
            // 
            // txNom
            // 
            this.txNom.Location = new System.Drawing.Point(99, 211);
            this.txNom.MaxLength = 50;
            this.txNom.Name = "txNom";
            this.txNom.Size = new System.Drawing.Size(200, 20);
            this.txNom.TabIndex = 5;
            // 
            // txTel
            // 
            this.txTel.Location = new System.Drawing.Point(99, 263);
            this.txTel.MaxLength = 11;
            this.txTel.Name = "txTel";
            this.txTel.Size = new System.Drawing.Size(85, 20);
            this.txTel.TabIndex = 6;
            // 
            // lbtit
            // 
            this.lbtit.AutoSize = true;
            this.lbtit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtit.Location = new System.Drawing.Point(122, 9);
            this.lbtit.Name = "lbtit";
            this.lbtit.Size = new System.Drawing.Size(74, 17);
            this.lbtit.TabIndex = 7;
            this.lbtit.Text = "CLIENTES";
            // 
            // btselct
            // 
            this.btselct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btselct.Location = new System.Drawing.Point(12, 304);
            this.btselct.Name = "btselct";
            this.btselct.Size = new System.Drawing.Size(105, 30);
            this.btselct.TabIndex = 8;
            this.btselct.Text = "Seleccionar";
            this.btselct.UseVisualStyleBackColor = true;
            this.btselct.Click += new System.EventHandler(this.btselct_Click);
            // 
            // btsave
            // 
            this.btsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.Location = new System.Drawing.Point(123, 304);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(176, 30);
            this.btsave.TabIndex = 9;
            this.btsave.Text = "Guardar y seleccionar";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // IngCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 348);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.btselct);
            this.Controls.Add(this.lbtit);
            this.Controls.Add(this.txTel);
            this.Controls.Add(this.txNom);
            this.Controls.Add(this.txCed);
            this.Controls.Add(this.lbtit3);
            this.Controls.Add(this.lbtit2);
            this.Controls.Add(this.lbtit1);
            this.Controls.Add(this.dgcli);
            this.Name = "IngCli";
            this.Text = "IngCli";
            ((System.ComponentModel.ISupportInitialize)(this.dgcli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgcli;
        private System.Windows.Forms.Label lbtit1;
        private System.Windows.Forms.Label lbtit2;
        private System.Windows.Forms.Label lbtit3;
        private System.Windows.Forms.TextBox txCed;
        private System.Windows.Forms.TextBox txNom;
        private System.Windows.Forms.TextBox txTel;
        private System.Windows.Forms.Label lbtit;
        private System.Windows.Forms.Button btselct;
        private System.Windows.Forms.Button btsave;
    }
}