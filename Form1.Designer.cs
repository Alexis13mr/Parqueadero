
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
            this.lbdate = new System.Windows.Forms.Label();
            this.tmtime = new System.Windows.Forms.Timer(this.components);
            this.pnlIn = new System.Windows.Forms.Panel();
            this.btconsult = new System.Windows.Forms.Button();
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
            this.lbsaltiping = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbsaltiemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbsaltar = new System.Windows.Forms.Label();
            this.lbsaltipveh = new System.Windows.Forms.Label();
            this.lbsalhorsal = new System.Windows.Forms.Label();
            this.lbsalhoring = new System.Windows.Forms.Label();
            this.lbsalpla = new System.Windows.Forms.Label();
            this.lbtii4 = new System.Windows.Forms.Label();
            this.lbtii5 = new System.Windows.Forms.Label();
            this.lbtii3 = new System.Windows.Forms.Label();
            this.lbtii2 = new System.Windows.Forms.Label();
            this.lbtii1 = new System.Windows.Forms.Label();
            this.lbhor = new System.Windows.Forms.Label();
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
            this.lbtit.Location = new System.Drawing.Point(76, 12);
            this.lbtit.Name = "lbtit";
            this.lbtit.Size = new System.Drawing.Size(226, 31);
            this.lbtit.TabIndex = 0;
            this.lbtit.Text = "PARQUEADERO";
            // 
            // btIn
            // 
            this.btIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.Location = new System.Drawing.Point(264, 145);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(76, 28);
            this.btIn.TabIndex = 1;
            this.btIn.Text = "Limpiar";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(506, 32);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(0, 17);
            this.lbdate.TabIndex = 3;
            // 
            // tmtime
            // 
            this.tmtime.Enabled = true;
            this.tmtime.Tick += new System.EventHandler(this.tmtime_Tick);
            // 
            // pnlIn
            // 
            this.pnlIn.Controls.Add(this.btconsult);
            this.pnlIn.Controls.Add(this.btSal);
            this.pnlIn.Controls.Add(this.cbcsc);
            this.pnlIn.Controls.Add(this.btingr);
            this.pnlIn.Controls.Add(this.gbing);
            this.pnlIn.Controls.Add(this.btIn);
            this.pnlIn.Controls.Add(this.gbve);
            this.pnlIn.Controls.Add(this.txplac);
            this.pnlIn.Controls.Add(this.lbCasc);
            this.pnlIn.Controls.Add(this.lbPlaca);
            this.pnlIn.Controls.Add(this.lbting);
            this.pnlIn.Location = new System.Drawing.Point(18, 65);
            this.pnlIn.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIn.Name = "pnlIn";
            this.pnlIn.Size = new System.Drawing.Size(412, 184);
            this.pnlIn.TabIndex = 5;
            // 
            // btconsult
            // 
            this.btconsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconsult.Location = new System.Drawing.Point(6, 145);
            this.btconsult.Margin = new System.Windows.Forms.Padding(2);
            this.btconsult.Name = "btconsult";
            this.btconsult.Size = new System.Drawing.Size(95, 28);
            this.btconsult.TabIndex = 14;
            this.btconsult.Text = "Consultar";
            this.btconsult.UseVisualStyleBackColor = true;
            this.btconsult.Click += new System.EventHandler(this.btconsult_Click);
            // 
            // btSal
            // 
            this.btSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSal.Location = new System.Drawing.Point(184, 145);
            this.btSal.Margin = new System.Windows.Forms.Padding(2);
            this.btSal.Name = "btSal";
            this.btSal.Size = new System.Drawing.Size(75, 28);
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
            this.cbcsc.Location = new System.Drawing.Point(64, 66);
            this.cbcsc.Name = "cbcsc";
            this.cbcsc.Size = new System.Drawing.Size(36, 21);
            this.cbcsc.TabIndex = 7;
            // 
            // btingr
            // 
            this.btingr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btingr.Location = new System.Drawing.Point(105, 145);
            this.btingr.Margin = new System.Windows.Forms.Padding(2);
            this.btingr.Name = "btingr";
            this.btingr.Size = new System.Drawing.Size(75, 28);
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
            this.gbing.Location = new System.Drawing.Point(313, 20);
            this.gbing.Margin = new System.Windows.Forms.Padding(2);
            this.gbing.Name = "gbing";
            this.gbing.Padding = new System.Windows.Forms.Padding(2);
            this.gbing.Size = new System.Drawing.Size(80, 102);
            this.gbing.TabIndex = 11;
            this.gbing.TabStop = false;
            // 
            // lbtin
            // 
            this.lbtin.AutoSize = true;
            this.lbtin.Location = new System.Drawing.Point(4, 8);
            this.lbtin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtin.Name = "lbtin";
            this.lbtin.Size = new System.Drawing.Size(65, 13);
            this.lbtin.TabIndex = 5;
            this.lbtin.Text = "Tipo ingreso";
            // 
            // rbhor
            // 
            this.rbhor.AutoSize = true;
            this.rbhor.Location = new System.Drawing.Point(7, 34);
            this.rbhor.Margin = new System.Windows.Forms.Padding(2);
            this.rbhor.Name = "rbhor";
            this.rbhor.Size = new System.Drawing.Size(58, 17);
            this.rbhor.TabIndex = 11;
            this.rbhor.TabStop = true;
            this.rbhor.Text = "X Hora";
            this.rbhor.UseVisualStyleBackColor = true;
            // 
            // rbDia
            // 
            this.rbDia.AutoSize = true;
            this.rbDia.Location = new System.Drawing.Point(7, 58);
            this.rbDia.Margin = new System.Windows.Forms.Padding(2);
            this.rbDia.Name = "rbDia";
            this.rbDia.Size = new System.Drawing.Size(53, 17);
            this.rbDia.TabIndex = 13;
            this.rbDia.TabStop = true;
            this.rbDia.Text = "X Día";
            this.rbDia.UseVisualStyleBackColor = true;
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.Location = new System.Drawing.Point(7, 80);
            this.rbMes.Margin = new System.Windows.Forms.Padding(2);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(55, 17);
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
            this.gbve.Location = new System.Drawing.Point(210, 20);
            this.gbve.Margin = new System.Windows.Forms.Padding(2);
            this.gbve.Name = "gbve";
            this.gbve.Padding = new System.Windows.Forms.Padding(2);
            this.gbve.Size = new System.Drawing.Size(79, 81);
            this.gbve.TabIndex = 6;
            this.gbve.TabStop = false;
            // 
            // lbtyp
            // 
            this.lbtyp.AutoSize = true;
            this.lbtyp.Location = new System.Drawing.Point(2, 8);
            this.lbtyp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtyp.Name = "lbtyp";
            this.lbtyp.Size = new System.Drawing.Size(71, 13);
            this.lbtyp.TabIndex = 1;
            this.lbtyp.Text = "Tipo vehiculo";
            // 
            // rbcar
            // 
            this.rbcar.AutoSize = true;
            this.rbcar.Location = new System.Drawing.Point(4, 36);
            this.rbcar.Margin = new System.Windows.Forms.Padding(2);
            this.rbcar.Name = "rbcar";
            this.rbcar.Size = new System.Drawing.Size(50, 17);
            this.rbcar.TabIndex = 9;
            this.rbcar.TabStop = true;
            this.rbcar.Text = "Carro";
            this.rbcar.UseVisualStyleBackColor = true;
            // 
            // rbmot
            // 
            this.rbmot.AutoSize = true;
            this.rbmot.Location = new System.Drawing.Point(4, 58);
            this.rbmot.Margin = new System.Windows.Forms.Padding(2);
            this.rbmot.Name = "rbmot";
            this.rbmot.Size = new System.Drawing.Size(49, 17);
            this.rbmot.TabIndex = 10;
            this.rbmot.TabStop = true;
            this.rbmot.Text = "Moto";
            this.rbmot.UseVisualStyleBackColor = true;
            this.rbmot.CheckedChanged += new System.EventHandler(this.rbmot_CheckedChanged);
            // 
            // txplac
            // 
            this.txplac.Location = new System.Drawing.Point(63, 37);
            this.txplac.Margin = new System.Windows.Forms.Padding(2);
            this.txplac.Name = "txplac";
            this.txplac.Size = new System.Drawing.Size(76, 20);
            this.txplac.TabIndex = 6;
            // 
            // lbCasc
            // 
            this.lbCasc.AutoSize = true;
            this.lbCasc.Enabled = false;
            this.lbCasc.Location = new System.Drawing.Point(3, 69);
            this.lbCasc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCasc.Name = "lbCasc";
            this.lbCasc.Size = new System.Drawing.Size(37, 13);
            this.lbCasc.TabIndex = 4;
            this.lbCasc.Text = "Casco";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(3, 37);
            this.lbPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(34, 13);
            this.lbPlaca.TabIndex = 2;
            this.lbPlaca.Text = "Placa";
            // 
            // lbting
            // 
            this.lbting.AutoSize = true;
            this.lbting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbting.Location = new System.Drawing.Point(3, 5);
            this.lbting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbting.Name = "lbting";
            this.lbting.Size = new System.Drawing.Size(192, 18);
            this.lbting.TabIndex = 0;
            this.lbting.Text = "Datos de ingreso y consulta";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
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
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // tarifasToolStripMenuItem
            // 
            this.tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
            this.tarifasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tarifasToolStripMenuItem.Text = "Tarifas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dgsal
            // 
            this.dgsal.AllowUserToAddRows = false;
            this.dgsal.AllowUserToDeleteRows = false;
            this.dgsal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgsal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgsal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsal.Location = new System.Drawing.Point(18, 265);
            this.dgsal.Margin = new System.Windows.Forms.Padding(2);
            this.dgsal.Name = "dgsal";
            this.dgsal.RowHeadersWidth = 51;
            this.dgsal.RowTemplate.Height = 24;
            this.dgsal.Size = new System.Drawing.Size(704, 147);
            this.dgsal.TabIndex = 7;
            this.dgsal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsal_CellContentClick);
            this.dgsal.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsal_CellContentDoubleClick);
            // 
            // gbinf
            // 
            this.gbinf.Controls.Add(this.lbsaltiping);
            this.gbinf.Controls.Add(this.label3);
            this.gbinf.Controls.Add(this.lbsaltiemp);
            this.gbinf.Controls.Add(this.label1);
            this.gbinf.Controls.Add(this.lbsaltar);
            this.gbinf.Controls.Add(this.lbsaltipveh);
            this.gbinf.Controls.Add(this.lbsalhorsal);
            this.gbinf.Controls.Add(this.lbsalhoring);
            this.gbinf.Controls.Add(this.lbsalpla);
            this.gbinf.Controls.Add(this.lbtii4);
            this.gbinf.Controls.Add(this.lbtii5);
            this.gbinf.Controls.Add(this.lbtii3);
            this.gbinf.Controls.Add(this.lbtii2);
            this.gbinf.Controls.Add(this.lbtii1);
            this.gbinf.Location = new System.Drawing.Point(441, 105);
            this.gbinf.Margin = new System.Windows.Forms.Padding(2);
            this.gbinf.Name = "gbinf";
            this.gbinf.Padding = new System.Windows.Forms.Padding(2);
            this.gbinf.Size = new System.Drawing.Size(288, 144);
            this.gbinf.TabIndex = 8;
            this.gbinf.TabStop = false;
            // 
            // lbsaltiping
            // 
            this.lbsaltiping.AutoSize = true;
            this.lbsaltiping.Location = new System.Drawing.Point(136, 35);
            this.lbsaltiping.Name = "lbsaltiping";
            this.lbsaltiping.Size = new System.Drawing.Size(0, 13);
            this.lbsaltiping.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "TIPO DE INGRESO:";
            // 
            // lbsaltiemp
            // 
            this.lbsaltiemp.AutoSize = true;
            this.lbsaltiemp.Location = new System.Drawing.Point(136, 75);
            this.lbsaltiemp.Name = "lbsaltiemp";
            this.lbsaltiemp.Size = new System.Drawing.Size(0, 13);
            this.lbsaltiemp.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TIEMPO ACTUAL:";
            // 
            // lbsaltar
            // 
            this.lbsaltar.AutoSize = true;
            this.lbsaltar.Location = new System.Drawing.Point(136, 88);
            this.lbsaltar.Name = "lbsaltar";
            this.lbsaltar.Size = new System.Drawing.Size(0, 13);
            this.lbsaltar.TabIndex = 9;
            // 
            // lbsaltipveh
            // 
            this.lbsaltipveh.AutoSize = true;
            this.lbsaltipveh.Location = new System.Drawing.Point(136, 22);
            this.lbsaltipveh.Name = "lbsaltipveh";
            this.lbsaltipveh.Size = new System.Drawing.Size(0, 13);
            this.lbsaltipveh.TabIndex = 8;
            // 
            // lbsalhorsal
            // 
            this.lbsalhorsal.AutoSize = true;
            this.lbsalhorsal.Location = new System.Drawing.Point(136, 62);
            this.lbsalhorsal.Name = "lbsalhorsal";
            this.lbsalhorsal.Size = new System.Drawing.Size(0, 13);
            this.lbsalhorsal.TabIndex = 7;
            this.lbsalhorsal.Visible = false;
            // 
            // lbsalhoring
            // 
            this.lbsalhoring.AutoSize = true;
            this.lbsalhoring.Location = new System.Drawing.Point(136, 48);
            this.lbsalhoring.Name = "lbsalhoring";
            this.lbsalhoring.Size = new System.Drawing.Size(0, 13);
            this.lbsalhoring.TabIndex = 6;
            // 
            // lbsalpla
            // 
            this.lbsalpla.AutoSize = true;
            this.lbsalpla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsalpla.Location = new System.Drawing.Point(136, 9);
            this.lbsalpla.Name = "lbsalpla";
            this.lbsalpla.Size = new System.Drawing.Size(0, 13);
            this.lbsalpla.TabIndex = 5;
            // 
            // lbtii4
            // 
            this.lbtii4.AutoSize = true;
            this.lbtii4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtii4.Location = new System.Drawing.Point(4, 22);
            this.lbtii4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtii4.Name = "lbtii4";
            this.lbtii4.Size = new System.Drawing.Size(127, 13);
            this.lbtii4.TabIndex = 4;
            this.lbtii4.Text = "TIPO DE VEHICULO:";
            // 
            // lbtii5
            // 
            this.lbtii5.AutoSize = true;
            this.lbtii5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtii5.Location = new System.Drawing.Point(5, 88);
            this.lbtii5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtii5.Name = "lbtii5";
            this.lbtii5.Size = new System.Drawing.Size(107, 13);
            this.lbtii5.TabIndex = 3;
            this.lbtii5.Text = "TARIFA ACTUAL:";
            // 
            // lbtii3
            // 
            this.lbtii3.AutoSize = true;
            this.lbtii3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtii3.Location = new System.Drawing.Point(5, 62);
            this.lbtii3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtii3.Name = "lbtii3";
            this.lbtii3.Size = new System.Drawing.Size(94, 13);
            this.lbtii3.TabIndex = 2;
            this.lbtii3.Text = "HORA SALIDA:";
            this.lbtii3.Visible = false;
            // 
            // lbtii2
            // 
            this.lbtii2.AutoSize = true;
            this.lbtii2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtii2.Location = new System.Drawing.Point(5, 48);
            this.lbtii2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtii2.Name = "lbtii2";
            this.lbtii2.Size = new System.Drawing.Size(106, 13);
            this.lbtii2.TabIndex = 1;
            this.lbtii2.Text = "HORA INGRESO:";
            // 
            // lbtii1
            // 
            this.lbtii1.AutoSize = true;
            this.lbtii1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtii1.Location = new System.Drawing.Point(5, 9);
            this.lbtii1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtii1.Name = "lbtii1";
            this.lbtii1.Size = new System.Drawing.Size(50, 13);
            this.lbtii1.TabIndex = 0;
            this.lbtii1.Text = "PLACA:";
            // 
            // lbhor
            // 
            this.lbhor.AutoSize = true;
            this.lbhor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhor.Location = new System.Drawing.Point(458, 32);
            this.lbhor.Name = "lbhor";
            this.lbhor.Size = new System.Drawing.Size(48, 17);
            this.lbhor.TabIndex = 9;
            this.lbhor.Text = "Hora:";
            // 
            // MainW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 422);
            this.Controls.Add(this.lbhor);
            this.Controls.Add(this.gbinf);
            this.Controls.Add(this.dgsal);
            this.Controls.Add(this.pnlIn);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.lbtit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Timer tmtime;
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
        private System.Windows.Forms.Label lbtii4;
        private System.Windows.Forms.Label lbtii5;
        private System.Windows.Forms.Label lbtii3;
        private System.Windows.Forms.Label lbtii2;
        private System.Windows.Forms.Label lbtii1;
        private System.Windows.Forms.Button btconsult;
        private System.Windows.Forms.Label lbsaltar;
        private System.Windows.Forms.Label lbsaltipveh;
        private System.Windows.Forms.Label lbsalhorsal;
        private System.Windows.Forms.Label lbsalhoring;
        private System.Windows.Forms.Label lbsalpla;
        private System.Windows.Forms.Label lbsaltiemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbsaltiping;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbhor;
    }
}

