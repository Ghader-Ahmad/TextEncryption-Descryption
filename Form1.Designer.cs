namespace TextEncryption_Descryption
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pEncryption = new System.Windows.Forms.Panel();
            this.btnClearEncrypt = new System.Windows.Forms.Button();
            this.lblProgressEncrypt = new System.Windows.Forms.Label();
            this.pbEncrypt = new System.Windows.Forms.ProgressBar();
            this.btnEncryptionText = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEEncryptText = new System.Windows.Forms.TextBox();
            this.CopyPastClearCutMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pDescryption = new System.Windows.Forms.Panel();
            this.btnClearDescrypt = new System.Windows.Forms.Button();
            this.lblProgressDescrypt = new System.Windows.Forms.Label();
            this.pbDescrypt = new System.Windows.Forms.ProgressBar();
            this.txtDDescryptText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDescryptionText = new System.Windows.Forms.Button();
            this.txtDText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbKey = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnTheme = new System.Windows.Forms.Button();
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.FormMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.btnExist = new System.Windows.Forms.Button();
            this.pEncryption.SuspendLayout();
            this.CopyPastClearCutMenu.SuspendLayout();
            this.pDescryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            this.FormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pEncryption
            // 
            this.pEncryption.BackColor = System.Drawing.Color.DarkGreen;
            this.pEncryption.Controls.Add(this.btnClearEncrypt);
            this.pEncryption.Controls.Add(this.lblProgressEncrypt);
            this.pEncryption.Controls.Add(this.pbEncrypt);
            this.pEncryption.Controls.Add(this.btnEncryptionText);
            this.pEncryption.Controls.Add(this.label5);
            this.pEncryption.Controls.Add(this.txtEEncryptText);
            this.pEncryption.Controls.Add(this.txtEText);
            this.pEncryption.Controls.Add(this.label2);
            this.pEncryption.Controls.Add(this.label3);
            this.pEncryption.Location = new System.Drawing.Point(22, 63);
            this.pEncryption.Name = "pEncryption";
            this.pEncryption.Size = new System.Drawing.Size(397, 457);
            this.pEncryption.TabIndex = 0;
            // 
            // btnClearEncrypt
            // 
            this.btnClearEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClearEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEncrypt.Location = new System.Drawing.Point(304, 427);
            this.btnClearEncrypt.Name = "btnClearEncrypt";
            this.btnClearEncrypt.Size = new System.Drawing.Size(75, 27);
            this.btnClearEncrypt.TabIndex = 15;
            this.btnClearEncrypt.Text = "Clear";
            this.btnClearEncrypt.UseVisualStyleBackColor = false;
            this.btnClearEncrypt.Visible = false;
            this.btnClearEncrypt.Click += new System.EventHandler(this.btnClearEncrypt_Click);
            // 
            // lblProgressEncrypt
            // 
            this.lblProgressEncrypt.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressEncrypt.ForeColor = System.Drawing.Color.Blue;
            this.lblProgressEncrypt.Location = new System.Drawing.Point(157, 214);
            this.lblProgressEncrypt.Name = "lblProgressEncrypt";
            this.lblProgressEncrypt.Size = new System.Drawing.Size(76, 37);
            this.lblProgressEncrypt.TabIndex = 14;
            this.lblProgressEncrypt.Text = "0%";
            this.lblProgressEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProgressEncrypt.Visible = false;
            // 
            // pbEncrypt
            // 
            this.pbEncrypt.Location = new System.Drawing.Point(58, 254);
            this.pbEncrypt.Name = "pbEncrypt";
            this.pbEncrypt.Size = new System.Drawing.Size(290, 33);
            this.pbEncrypt.TabIndex = 9;
            this.pbEncrypt.Visible = false;
            this.pbEncrypt.Click += new System.EventHandler(this.pbEncrypt_Click);
            // 
            // btnEncryptionText
            // 
            this.btnEncryptionText.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEncryptionText.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnEncryptionText.FlatAppearance.BorderSize = 2;
            this.btnEncryptionText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptionText.Location = new System.Drawing.Point(147, 236);
            this.btnEncryptionText.Name = "btnEncryptionText";
            this.btnEncryptionText.Size = new System.Drawing.Size(96, 41);
            this.btnEncryptionText.TabIndex = 8;
            this.btnEncryptionText.Text = "Encryption";
            this.btnEncryptionText.UseVisualStyleBackColor = false;
            this.btnEncryptionText.Click += new System.EventHandler(this.btnEncryptionText_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(125, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Encryption Text :";
            // 
            // txtEEncryptText
            // 
            this.txtEEncryptText.ContextMenuStrip = this.CopyPastClearCutMenu;
            this.txtEEncryptText.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEEncryptText.Location = new System.Drawing.Point(69, 346);
            this.txtEEncryptText.Multiline = true;
            this.txtEEncryptText.Name = "txtEEncryptText";
            this.txtEEncryptText.Size = new System.Drawing.Size(262, 75);
            this.txtEEncryptText.TabIndex = 6;
            // 
            // CopyPastClearCutMenu
            // 
            this.CopyPastClearCutMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pastToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cutToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.CopyPastClearCutMenu.Name = "CopyPastClearCutMenu";
            this.CopyPastClearCutMenu.Size = new System.Drawing.Size(145, 98);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pastToolStripMenuItem
            // 
            this.pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            this.pastToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pastToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pastToolStripMenuItem.Text = "Past";
            this.pastToolStripMenuItem.Click += new System.EventHandler(this.pastToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // txtEText
            // 
            this.txtEText.ContextMenuStrip = this.CopyPastClearCutMenu;
            this.txtEText.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEText.ForeColor = System.Drawing.Color.Gray;
            this.txtEText.Location = new System.Drawing.Point(69, 117);
            this.txtEText.Multiline = true;
            this.txtEText.Name = "txtEText";
            this.txtEText.Size = new System.Drawing.Size(262, 75);
            this.txtEText.TabIndex = 5;
            this.txtEText.Text = "Please Enter The Text!";
            this.txtEText.Enter += new System.EventHandler(this.txtEText_Enter_1);
            this.txtEText.Leave += new System.EventHandler(this.txtEText_Leave_1);
            this.txtEText.Validating += new System.ComponentModel.CancelEventHandler(this.txtEText_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(169, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(120, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Encryption";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Marker", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Peru;
            this.lblTitle.Location = new System.Drawing.Point(410, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 38);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Secure Crypt";
            // 
            // pDescryption
            // 
            this.pDescryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pDescryption.Controls.Add(this.btnClearDescrypt);
            this.pDescryption.Controls.Add(this.lblProgressDescrypt);
            this.pDescryption.Controls.Add(this.pbDescrypt);
            this.pDescryption.Controls.Add(this.txtDDescryptText);
            this.pDescryption.Controls.Add(this.label7);
            this.pDescryption.Controls.Add(this.btnDescryptionText);
            this.pDescryption.Controls.Add(this.txtDText);
            this.pDescryption.Controls.Add(this.label6);
            this.pDescryption.Controls.Add(this.label4);
            this.pDescryption.Location = new System.Drawing.Point(580, 63);
            this.pDescryption.Name = "pDescryption";
            this.pDescryption.Size = new System.Drawing.Size(397, 457);
            this.pDescryption.TabIndex = 4;
            // 
            // btnClearDescrypt
            // 
            this.btnClearDescrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClearDescrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDescrypt.Location = new System.Drawing.Point(303, 427);
            this.btnClearDescrypt.Name = "btnClearDescrypt";
            this.btnClearDescrypt.Size = new System.Drawing.Size(75, 27);
            this.btnClearDescrypt.TabIndex = 16;
            this.btnClearDescrypt.Text = "Clear";
            this.btnClearDescrypt.UseVisualStyleBackColor = false;
            this.btnClearDescrypt.Visible = false;
            this.btnClearDescrypt.Click += new System.EventHandler(this.btnClearDescrypt_Click);
            // 
            // lblProgressDescrypt
            // 
            this.lblProgressDescrypt.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressDescrypt.ForeColor = System.Drawing.Color.Blue;
            this.lblProgressDescrypt.Location = new System.Drawing.Point(164, 214);
            this.lblProgressDescrypt.Name = "lblProgressDescrypt";
            this.lblProgressDescrypt.Size = new System.Drawing.Size(76, 37);
            this.lblProgressDescrypt.TabIndex = 15;
            this.lblProgressDescrypt.Text = "0%";
            this.lblProgressDescrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProgressDescrypt.Visible = false;
            // 
            // pbDescrypt
            // 
            this.pbDescrypt.Location = new System.Drawing.Point(57, 254);
            this.pbDescrypt.Name = "pbDescrypt";
            this.pbDescrypt.Size = new System.Drawing.Size(290, 33);
            this.pbDescrypt.TabIndex = 15;
            this.pbDescrypt.Visible = false;
            // 
            // txtDDescryptText
            // 
            this.txtDDescryptText.ContextMenuStrip = this.CopyPastClearCutMenu;
            this.txtDDescryptText.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDDescryptText.Location = new System.Drawing.Point(73, 346);
            this.txtDDescryptText.Multiline = true;
            this.txtDDescryptText.Name = "txtDDescryptText";
            this.txtDDescryptText.Size = new System.Drawing.Size(262, 75);
            this.txtDDescryptText.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(140, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Descrypt Text :";
            // 
            // btnDescryptionText
            // 
            this.btnDescryptionText.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnDescryptionText.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnDescryptionText.FlatAppearance.BorderSize = 2;
            this.btnDescryptionText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescryptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescryptionText.Location = new System.Drawing.Point(154, 236);
            this.btnDescryptionText.Name = "btnDescryptionText";
            this.btnDescryptionText.Size = new System.Drawing.Size(96, 41);
            this.btnDescryptionText.TabIndex = 9;
            this.btnDescryptionText.Text = "Descrypt";
            this.btnDescryptionText.UseVisualStyleBackColor = false;
            this.btnDescryptionText.Click += new System.EventHandler(this.btnDescryptionText_Click);
            // 
            // txtDText
            // 
            this.txtDText.ContextMenuStrip = this.CopyPastClearCutMenu;
            this.txtDText.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDText.ForeColor = System.Drawing.Color.Gray;
            this.txtDText.Location = new System.Drawing.Point(73, 117);
            this.txtDText.Multiline = true;
            this.txtDText.Name = "txtDText";
            this.txtDText.Size = new System.Drawing.Size(262, 75);
            this.txtDText.TabIndex = 9;
            this.txtDText.Text = "Please Enter The Text!";
            this.txtDText.Enter += new System.EventHandler(this.txtEText_Enter_1);
            this.txtDText.Leave += new System.EventHandler(this.txtEText_Leave_1);
            this.txtDText.Validating += new System.ComponentModel.CancelEventHandler(this.txtEText_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(176, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Text :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Marker", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(115, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Derscryption";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbKey
            // 
            this.tbKey.BackColor = System.Drawing.Color.ForestGreen;
            this.tbKey.Location = new System.Drawing.Point(477, 205);
            this.tbKey.Name = "tbKey";
            this.tbKey.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbKey.Size = new System.Drawing.Size(45, 264);
            this.tbKey.TabIndex = 5;
            this.tbKey.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbKey.Value = 2;
            this.tbKey.Scroll += new System.EventHandler(this.tbKey_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(443, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cryption Key :";
            // 
            // lblKey
            // 
            this.lblKey.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.Blue;
            this.lblKey.Location = new System.Drawing.Point(477, 165);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(45, 37);
            this.lblKey.TabIndex = 11;
            this.lblKey.Text = "2";
            this.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTheme
            // 
            this.btnTheme.BackgroundImage = global::TextEncryption_Descryption.Properties.Resources.BlackTheme;
            this.btnTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Location = new System.Drawing.Point(935, 9);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(42, 45);
            this.btnTheme.TabIndex = 12;
            this.btnTheme.Tag = "1";
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // pbLock
            // 
            this.pbLock.Image = global::TextEncryption_Descryption.Properties.Resources.CloseLock;
            this.pbLock.Location = new System.Drawing.Point(590, 2);
            this.pbLock.Name = "pbLock";
            this.pbLock.Size = new System.Drawing.Size(42, 45);
            this.pbLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLock.TabIndex = 13;
            this.pbLock.TabStop = false;
            // 
            // FormMenu
            // 
            this.FormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem6});
            this.FormMenu.Name = "contextMenuStrip1";
            this.FormMenu.Size = new System.Drawing.Size(184, 48);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItem4.Text = "Clear All";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItem6.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItem6.Text = "Exist";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.ForeColor = System.Drawing.Color.White;
            this.lblDateAndTime.Location = new System.Drawing.Point(40, 22);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(0, 22);
            this.lblDateAndTime.TabIndex = 17;
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.Location = new System.Drawing.Point(462, 490);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(75, 27);
            this.btnExist.TabIndex = 16;
            this.btnExist.Text = "Exist";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTheme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(999, 532);
            this.ContextMenuStrip = this.FormMenu;
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.lblDateAndTime);
            this.Controls.Add(this.pbLock);
            this.Controls.Add(this.btnTheme);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.pDescryption);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pEncryption);
            this.Name = "Form1";
            this.Text = "Encryption&Descryption";
            this.pEncryption.ResumeLayout(false);
            this.pEncryption.PerformLayout();
            this.CopyPastClearCutMenu.ResumeLayout(false);
            this.pDescryption.ResumeLayout(false);
            this.pDescryption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            this.FormMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pEncryption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEncryptionText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEEncryptText;
        private System.Windows.Forms.TextBox txtEText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pDescryption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDDescryptText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDescryptionText;
        private System.Windows.Forms.TextBox txtDText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TrackBar tbKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.PictureBox pbLock;
        private System.Windows.Forms.Label lblProgressEncrypt;
        private System.Windows.Forms.ProgressBar pbEncrypt;
        private System.Windows.Forms.Label lblProgressDescrypt;
        private System.Windows.Forms.ProgressBar pbDescrypt;
        private System.Windows.Forms.Button btnClearEncrypt;
        private System.Windows.Forms.Button btnClearDescrypt;
        private System.Windows.Forms.ContextMenuStrip FormMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.ContextMenuStrip CopyPastClearCutMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

