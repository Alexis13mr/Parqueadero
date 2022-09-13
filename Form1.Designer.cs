
namespace Parqueadero
{
    partial class MainW
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbtit = new System.Windows.Forms.Label();
            this.btIn = new System.Windows.Forms.Button();
            this.btEx = new System.Windows.Forms.Button();
            this.lbdate = new System.Windows.Forms.Label();
            this.tmtime = new System.Windows.Forms.Timer(this.components);
            this.btTime = new System.Windows.Forms.Button();
            this.pnlIn = new System.Windows.Forms.Panel();
            this.btSal = new System.Windows.Forms.Button();
            this.cbcsc = new System.Windows.Forms.ComboBox();
            this.btingr = new System.Windows.Forms.Button();
            this.gbing = new System.Windows.Forms.GroupBox();
            this.lbtin = new System.Windows.Forms.Label();
            this.rbhor = new System.Windows.Forms.RadioButton();
            this.rbDia = new System.Windows.Forms.RadioButton();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.gbve = new System.Windows.Forms.GroupBox();
            this.lbtyp = new System.Windows.Forms.Label();
            this.rbcar = new System.Windows.Forms.RadioButton();
            this.rbmot = new System.Windows.Forms.RadioButton();
            this.txplac = new System.Windows.Forms.TextBox();
            this.lbCasc = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbting = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgsal = new System.Windows.Forms.DataGridView();
            this.gbinf = new System.Windows.Forms.GroupBox();
            this.lbPlaca2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbinftarif = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btconsult = new System.Windows.Forms.Button();
            this.pnlIn.SuspendLayout();
            this.gbing.SuspendLayout();
            this.gbve.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsal)).BeginInit();
            this.gbinf.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtit
            // 
            this.lbtit.AutoSize = true;
            this.lbtit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtit.Location = new System.Drawing.Point(101, 15);
            this.lbtit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtit.Name = "lbtit";
            this.lbtit.Size = new System.Drawing.Size(284, 39);
            this.lbtit.TabIndex = 0;
            this.lbtit.Text = "PARQUEADERO";
            // 
            // btIn
            // 
            this.btIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.Location = new System.Drawing.Point(24, 74);
            this.btIn.Margin = new System.Windows.Forms.Padding(4);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(133, 43);
            this.btIn.TabIndex = 1;
            this.btIn.Text = "Ingreso";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btEx
            // 
            this.btEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEx.Location = new System.Drawing.Point(165, 74);
            this.btEx.Margin = new System.Windows.Forms.Padding(4);
            this.btEx.Name = "btEx";
            this.btEx.Size = new System.Drawing.Size(133, 43);
            this.btEx.TabIndex = 2;
            this.btEx.Text = "Salida";
            this.btEx.UseVisualStyleBackColor = true;
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(675, 40);
            this.lbdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(0, 20);
            this.lbdate.TabIndex = 3;
            this.lbdate.Visible = false;
            // 
            // tmtime
            // 
            this.tmtime.Tick += new System.EventHandler(this.tmtime_Tick);
            // 
            // btTime
            // 
            this.btTime.Location = new System.Drawing.Point(567, 32);
            this.btTime.Margin = new System.Windows.Forms.Padding(4);
            this.btTime.Name = "btTime";
            this.btTime.Size = new System.Drawing.Size(100, 28);
            this.btTime.TabIndex = 4;
            this.btTime.Text = "Mostrar hora";
            this.btTime.UseVisualStyleBackColor = true;
            this.btTime.Click += new System.EventHandler(this.btTime_Click);
            // 
            // pnlIn
            // 
            this.pnlIn.Controls.Add(this.btconsult);
            this.pnlIn.Controls.Add(this.btSal);
            this.pnlIn.Controls.Add(this.cbcsc);
            this.pnlIn.Controls.Add(this.btingr);
            this.pnlIn.Controls.Add(this.gbing);
            this.pnlIn.Controls.Add(this.gbve);
            this.pnlIn.Controls.Add(this.txplac);
            this.pnlIn.Controls.Add(this.lbCasc);
            this.pnlIn.Controls.Add(this.lbPlaca);
            this.pnlIn.Controls.Add(this.lbting);
            this.pnlIn.Location = new System.Drawing.Point(24, 150);
            this.pnlIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIn.Name = "pnlIn";
            this.pnlIn.Size = new System.Drawing.Size(549, 206);
            this.pnlIn.TabIndex = 5;
            this.pnlIn.Visible = false;
            // 
            // btSal
            // 
            this.btSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSal.Location = new System.Drawing.Point(280, 158);
            this.btSal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSal.Name = "btSal";
            this.btSal.Size = new System.Drawing.Size(100, 34);
            this.btSal.TabIndex = 13;
            this.btSal.Text = "Salir";
            this.btSal.UseVisualStyleBackColor = true;
            this.btSal.Click += new System.EventHandler(this.btSal_Click);
            // 
            // cbcsc
            // 
            this.cbcsc.Enabled = false;
            this.cbcsc.FormattingEnabled = true;
            this.cbcsc.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbcsc.Location = new System.Drawing.Point(85, 81);
            this.cbcsc.Margin = new System.Windows.Forms.Padding(4);
            this.cbcsc.Name = "cbcsc";
            this.cbcsc.Size = new System.Drawing.Size(47, 24);
            this.cbcsc.TabIndex = 7;
            // 
            // btingr
            // 
            this.btingr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btingr.Location = new System.Drawing.Point(174, 158);
            this.btingr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btingr.Name = "btingr";
            this.btingr.Size = new System.Drawing.Size(100, 34);
            this.btingr.TabIndex = 12;
            this.btingr.Text = "Ingresar";
            this.btingr.UseVisualStyleBackColor = true;
            this.btingr.Click += new System.EventHandler(this.btingr_Click);
            // 
            // gbing
            // 
            this.gbing.Controls.Add(this.lbtin);
            this.gbing.Controls.Add(this.rbhor);
            this.gbing.Controls.Add(this.rbDia);
            this.gbing.Controls.Add(this.rbMes);
            this.gbing.Location = new System.Drawing.Point(417, 25);
            this.gbing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbing.Name = "gbing";
            this.gbing.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbing.Size = new System.Drawing.Size(107, 126);
            this.gbing.TabIndex = 11;
            this.gbing.TabStop = false;
            // 
            // lbtin
            // 
            this.lbtin.AutoSize = true;
            this.lbtin.Location = new System.Drawing.Point(5, 10);
            this.lbtin.Name = "lbtin";
            this.lbtin.Size = new System.Drawing.Size(87, 17);
            this.lbtin.TabIndex = 5;
            this.lbtin.Text = "Tipo ingreso";
            // 
            // rbhor
            // 
            this.rbhor.AutoSize = true;
            this.rbhor.Location = new System.Drawing.Point(9, 42);
            this.rbhor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbhor.Name = "rbhor";
            this.rbhor.Size = new System.Drawing.Size(73, 21);
            this.rbhor.TabIndex = 11;
            this.rbhor.TabStop = true;
            this.rbhor.Text = "X Hora";
            this.rbhor.UseVisualStyleBackColor = true;
            // 
            // rbDia
            // 
            this.rbDia.AutoSize = true;
            this.rbDia.Location = new System.Drawing.Point(9, 71);
            this.rbDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDia.Name = "rbDia";
            this.rbDia.Size = new System.Drawing.Size(63, 21);
            this.rbDia.TabIndex = 13;
            this.rbDia.TabStop = true;
            this.rbDia.Text = "X Día";
            this.rbDia.UseVisualStyleBackColor = true;
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.Location = new System.Drawing.Point(9, 98);
            this.rbMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(68, 21);
            this.rbMes.TabIndex = 12;
            this.rbMes.TabStop = true;
            this.rbMes.Text = "X Mes";
            this.rbMes.UseVisualStyleBackColor = true;
            // 
            // gbve
            // 
            this.gbve.Controls.Add(this.lbtyp);
            this.gbve.Controls.Add(this.rbcar);
            this.gbve.Controls.Add(this.rbmot);
            this.gbve.Location = new System.Drawing.Point(280, 25);
            this.gbve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbve.Name = "gbve";
            this.gbve.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbve.Size = new System.Drawing.Size(105, 100);
            this.gbve.TabIndex = 6;
            this.gbve.TabStop = false;
            // 
            // lbtyp
            // 
            this.lbtyp.AutoSize = true;
            this.lbtyp.Location = new System.Drawing.Point(3, 10);
            this.lbtyp.Name = "lbtyp";
            this.lbtyp.Size = new System.Drawing.Size(92, 17);
            this.lbtyp.TabIndex = 1;
            this.lbtyp.Text = "Tipo vehiculo";
            // 
            // rbcar
            // 
            this.rbcar.AutoSize = true;
            this.rbcar.Location = new System.Drawing.Point(5, 44);
            this.rbcar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbcar.Name = "rbcar";
            this.rbcar.Size = new System.Drawing.Size(64, 21);
            this.rbcar.TabIndex = 9;
            this.rbcar.TabStop = true;
            this.rbcar.Text = "Carro";
            this.rbcar.UseVisualStyleBackColor = true;
            // 
            // rbmot
            // 
            this.rbmot.AutoSize = true;
            this.rbmot.Location = new System.Drawing.Point(5, 71);
            this.rbmot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbmot.Name = "rbmot";
            this.rbmot.Size = new System.Drawing.Size(60, 21);
            this.rbmot.TabIndex = 10;
            this.rbmot.TabStop = true;
            this.rbmot.Text = "Moto";
            this.rbmot.UseVisualStyleBackColor = true;
            this.rbmot.CheckedChanged += new System.EventHandler(this.rbmot_CheckedChanged);
            // 
            // txplac
            // 
            this.txplac.Location = new System.Drawing.Point(84, 46);
            this.txplac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txplac.Name = "txplac";
            this.txplac.Size = new System.Drawing.Size(100, 22);
            this.txplac.TabIndex = 6;
            // 
            // lbCasc
            // 
            this.lbCasc.AutoSize = true;
            this.lbCasc.Enabled = false;
            this.lbCasc.Location = new System.Drawing.Point(4, 85);
            this.lbCasc.Name = "lbCasc";
            this.lbCasc.Size = new System.Drawing.Size(47, 17);
            this.lbCasc.TabIndex = 4;
            this.lbCasc.Text = "Casco";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(4, 46);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(43, 17);
            this.lbPlaca.TabIndex = 2;
            this.lbPlaca.Text = "Placa";
            // 
            // lbting
            // 
            this.lbting.AutoSize = true;
            this.lbting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbting.Location = new System.Drawing.Point(3, 0);
            this.lbting.Name = "lbting";
            this.lbting.Size = new System.Drawing.Size(152, 24);
            this.lbting.TabIndex = 0;
            this.lbting.Text = "Datos de ingreso";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(986, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem,
            this.tarifasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // tarifasToolStripMenuItem
            // 
            this.tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
            this.tarifasToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.tarifasToolStripMenuItem.Text = "Tarifas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dgsal
            // 
            this.dgsal.AllowUserToAddRows = false;
            this.dgsal.AllowUserToDeleteRows = false;
            this.dgsal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgsal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgsal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsal.Location = new System.Drawing.Point(31, 361);
            this.dgsal.Name = "dgsal";
            this.dgsal.RowHeadersWidth = 51;
            this.dgsal.RowTemplate.Height = 24;
            this.dgsal.Size = new System.Drawing.Size(924, 146);
            this.dgsal.TabIndex = 7;
            // 
            // gbinf
            // 
            this.gbinf.Controls.Add(this.label3);
            this.gbinf.Controls.Add(this.lbinftarif);
            this.gbinf.Controls.Add(this.label2);
            this.gbinf.Controls.Add(this.label1);
            this.gbinf.Controls.Add(this.lbPlaca2);
            this.gbinf.Location = new System.Drawing.Point(588, 150);
            this.gbinf.Name = "gbinf";
            this.gbinf.Size = new System.Drawing.Size(716, 100);
            this.gbinf.TabIndex = 8;
            this.gbinf.TabStop = false;
            // 
            // lbPlaca2
            // 
            this.lbPlaca2.AutoSize = true;
            this.lbPlaca2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaca2.Location = new System.Drawing.Point(6, 11);
            this.lbPlaca2.Name = "lbPlaca2";
            this.lbPlaca2.Size = new System.Drawing.Size(62, 17);
            this.lbPlaca2.TabIndex = 0;
            this.lbPlaca2.Text = "PLACA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "HORA INGRESO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "HORA SALIDA:";
            // 
            // lbinftarif
            // 
            this.lbinftarif.AutoSize = true;
            this.lbinftarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinftarif.Location = new System.Drawing.Point(6, 80);
            this.lbinftarif.Name = "lbinftarif";
            this.lbinftarif.Size = new System.Drawing.Size(132, 17);
            this.lbinftarif.TabIndex = 3;
            this.lbinftarif.Text = "TARIFA ACTUAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "TIPO DE VEHICULO";
            // 
            // btconsult
            // 
            this.btconsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconsult.Location = new System.Drawing.Point(7, 158);
            this.btconsult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btconsult.Name = "btconsult";
            this.btconsult.Size = new System.Drawing.Size(100, 34);
            this.btconsult.TabIndex = 14;
            this.btconsult.Text = "Consultar";
            this.btconsult.UseVisualStyleBackColor = true;
            this.btconsult.Click += new System.EventHandler(this.btconsult_Click);
            // 
            // MainW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 519);
            this.Controls.Add(this.gbinf);
            this.Controls.Add(this.dgsal);
            this.Controls.Add(this.pnlIn);
            this.Controls.Add(this.btTime);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.btEx);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.lbtit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainW";
            this.Text = "Park";
            this.Load += new System.EventHandler(this.MainW_Load);
            this.pnlIn.ResumeLayout(false);
            this.pnlIn.PerformLayout();
            this.gbing.ResumeLayout(false);
            this.gbing.PerformLayout();
            this.gbve.ResumeLayout(false);
            this.gbve.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsal)).EndInit();
            this.gbinf.ResumeLayout(false);
            this.gbinf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtit;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btEx;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Timer tmtime;
        private System.Windows.Forms.Button btTime;
        private System.Windows.Forms.Panel pnlIn;
        private System.Windows.Forms.Label lbCasc;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbtyp;
        private System.Windows.Forms.Label lbting;
        private System.Windows.Forms.RadioButton rbDia;
        private System.Windows.Forms.RadioButton rbMes;
        private System.Windows.Forms.RadioButton rbhor;
        private System.Windows.Forms.RadioButton rbmot;
        private System.Windows.Forms.RadioButton rbcar;
        private System.Windows.Forms.TextBox txplac;
        private System.Windows.Forms.Label lbtin;
        private System.Windows.Forms.GroupBox gbing;
        private System.Windows.Forms.GroupBox gbve;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btingr;
        private System.Windows.Forms.ComboBox cbcsc;
        private System.Windows.Forms.Button btSal;
        private System.Windows.Forms.DataGridView dgsal;
        private System.Windows.Forms.GroupBox gbinf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbinftarif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPlaca2;
        private System.Windows.Forms.Button btconsult;
    }
}

