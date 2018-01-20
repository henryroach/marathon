namespace Marathon
{
    partial class AdministrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationForm));
            this.HomePointsLabel = new System.Windows.Forms.Label();
            this.GuestAddPointButton = new System.Windows.Forms.Button();
            this.GuestRemovePointButton = new System.Windows.Forms.Button();
            this.GuestPointsLabel = new System.Windows.Forms.Label();
            this.HomeAddPointButton = new System.Windows.Forms.Button();
            this.HomeRemovePointButton = new System.Windows.Forms.Button();
            this.HomeGroupBox = new System.Windows.Forms.GroupBox();
            this.GuestGroupBox = new System.Windows.Forms.GroupBox();
            this.CurrentPlayers = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GuestPlayerTwoComboBox = new System.Windows.Forms.ComboBox();
            this.GuestPlayerTwoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GuestPlayerOneComboBox = new System.Windows.Forms.ComboBox();
            this.GuestPlayerOneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HomePlayerTwoComboBox = new System.Windows.Forms.ComboBox();
            this.HomePlayerTwoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HomePlayerOneComboBox = new System.Windows.Forms.ComboBox();
            this.HomePlayerOneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HomePlayersGridView = new System.Windows.Forms.DataGridView();
            this.HomePlayerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomePlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomePlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GuestPlayersGridView = new System.Windows.Forms.DataGridView();
            this.GuestPlayerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestPlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StartMarathonButton = new System.Windows.Forms.Button();
            this.ActualTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PlayedTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RemainingTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ShowResultsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReverseSideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.marathonTimer = new System.Windows.Forms.Timer(this.components);
            this.HomeGroupBox.SuspendLayout();
            this.GuestGroupBox.SuspendLayout();
            this.CurrentPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestPlayerTwoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestPlayerOneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePlayerTwoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePlayerOneBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePlayersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePlayerBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestPlayersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestPlayerBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePointsLabel
            // 
            this.HomePointsLabel.AutoSize = true;
            this.HomePointsLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomePointsLabel.Location = new System.Drawing.Point(26, 42);
            this.HomePointsLabel.Name = "HomePointsLabel";
            this.HomePointsLabel.Size = new System.Drawing.Size(37, 41);
            this.HomePointsLabel.TabIndex = 2;
            this.HomePointsLabel.Text = "0";
            // 
            // GuestAddPointButton
            // 
            this.GuestAddPointButton.Font = new System.Drawing.Font("Consolas", 13.71428F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuestAddPointButton.Location = new System.Drawing.Point(6, 111);
            this.GuestAddPointButton.Name = "GuestAddPointButton";
            this.GuestAddPointButton.Size = new System.Drawing.Size(43, 34);
            this.GuestAddPointButton.TabIndex = 4;
            this.GuestAddPointButton.Text = "+";
            this.GuestAddPointButton.UseVisualStyleBackColor = true;
            this.GuestAddPointButton.Click += new System.EventHandler(this.GuestAddPointButton_Click);
            // 
            // GuestRemovePointButton
            // 
            this.GuestRemovePointButton.Font = new System.Drawing.Font("Consolas", 13.71428F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuestRemovePointButton.Location = new System.Drawing.Point(88, 111);
            this.GuestRemovePointButton.Name = "GuestRemovePointButton";
            this.GuestRemovePointButton.Size = new System.Drawing.Size(43, 34);
            this.GuestRemovePointButton.TabIndex = 5;
            this.GuestRemovePointButton.Text = "-";
            this.GuestRemovePointButton.UseVisualStyleBackColor = true;
            this.GuestRemovePointButton.Click += new System.EventHandler(this.GuestRemovePointButton_Click);
            // 
            // GuestPointsLabel
            // 
            this.GuestPointsLabel.AutoSize = true;
            this.GuestPointsLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuestPointsLabel.Location = new System.Drawing.Point(20, 42);
            this.GuestPointsLabel.Name = "GuestPointsLabel";
            this.GuestPointsLabel.Size = new System.Drawing.Size(37, 41);
            this.GuestPointsLabel.TabIndex = 6;
            this.GuestPointsLabel.Text = "0";
            // 
            // HomeAddPointButton
            // 
            this.HomeAddPointButton.Font = new System.Drawing.Font("Consolas", 13.71428F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeAddPointButton.Location = new System.Drawing.Point(6, 111);
            this.HomeAddPointButton.Name = "HomeAddPointButton";
            this.HomeAddPointButton.Size = new System.Drawing.Size(43, 34);
            this.HomeAddPointButton.TabIndex = 7;
            this.HomeAddPointButton.Text = "+";
            this.HomeAddPointButton.UseVisualStyleBackColor = true;
            this.HomeAddPointButton.Click += new System.EventHandler(this.HomeAddPointButton_Click);
            // 
            // HomeRemovePointButton
            // 
            this.HomeRemovePointButton.Font = new System.Drawing.Font("Consolas", 13.71428F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeRemovePointButton.Location = new System.Drawing.Point(88, 111);
            this.HomeRemovePointButton.Name = "HomeRemovePointButton";
            this.HomeRemovePointButton.Size = new System.Drawing.Size(43, 34);
            this.HomeRemovePointButton.TabIndex = 8;
            this.HomeRemovePointButton.Text = "-";
            this.HomeRemovePointButton.UseVisualStyleBackColor = true;
            this.HomeRemovePointButton.Click += new System.EventHandler(this.HomeRemovePointButton_Click);
            // 
            // HomeGroupBox
            // 
            this.HomeGroupBox.Controls.Add(this.HomePointsLabel);
            this.HomeGroupBox.Controls.Add(this.HomeAddPointButton);
            this.HomeGroupBox.Controls.Add(this.HomeRemovePointButton);
            this.HomeGroupBox.Location = new System.Drawing.Point(12, 28);
            this.HomeGroupBox.Name = "HomeGroupBox";
            this.HomeGroupBox.Size = new System.Drawing.Size(140, 201);
            this.HomeGroupBox.TabIndex = 9;
            this.HomeGroupBox.TabStop = false;
            this.HomeGroupBox.Text = "Domácí";
            // 
            // GuestGroupBox
            // 
            this.GuestGroupBox.Controls.Add(this.GuestPointsLabel);
            this.GuestGroupBox.Controls.Add(this.GuestAddPointButton);
            this.GuestGroupBox.Controls.Add(this.GuestRemovePointButton);
            this.GuestGroupBox.Location = new System.Drawing.Point(158, 28);
            this.GuestGroupBox.Name = "GuestGroupBox";
            this.GuestGroupBox.Size = new System.Drawing.Size(143, 201);
            this.GuestGroupBox.TabIndex = 10;
            this.GuestGroupBox.TabStop = false;
            this.GuestGroupBox.Text = "Hosté";
            // 
            // CurrentPlayers
            // 
            this.CurrentPlayers.Controls.Add(this.label7);
            this.CurrentPlayers.Controls.Add(this.label8);
            this.CurrentPlayers.Controls.Add(this.GuestPlayerTwoComboBox);
            this.CurrentPlayers.Controls.Add(this.GuestPlayerOneComboBox);
            this.CurrentPlayers.Controls.Add(this.label6);
            this.CurrentPlayers.Controls.Add(this.label5);
            this.CurrentPlayers.Controls.Add(this.HomePlayerTwoComboBox);
            this.CurrentPlayers.Controls.Add(this.HomePlayerOneComboBox);
            this.CurrentPlayers.Controls.Add(this.label4);
            this.CurrentPlayers.Controls.Add(this.label3);
            this.CurrentPlayers.Location = new System.Drawing.Point(307, 28);
            this.CurrentPlayers.Name = "CurrentPlayers";
            this.CurrentPlayers.Size = new System.Drawing.Size(511, 201);
            this.CurrentPlayers.TabIndex = 11;
            this.CurrentPlayers.TabStop = false;
            this.CurrentPlayers.Text = "Aktuálně hrající";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hráč 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hráč 1";
            // 
            // GuestPlayerTwoComboBox
            // 
            this.GuestPlayerTwoComboBox.DataSource = this.GuestPlayerTwoBindingSource;
            this.GuestPlayerTwoComboBox.DisplayMember = "Name";
            this.GuestPlayerTwoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GuestPlayerTwoComboBox.FormattingEnabled = true;
            this.GuestPlayerTwoComboBox.Location = new System.Drawing.Point(285, 111);
            this.GuestPlayerTwoComboBox.Name = "GuestPlayerTwoComboBox";
            this.GuestPlayerTwoComboBox.Size = new System.Drawing.Size(215, 21);
            this.GuestPlayerTwoComboBox.TabIndex = 7;
            this.GuestPlayerTwoComboBox.ValueMember = "Id";
            this.GuestPlayerTwoComboBox.SelectedIndexChanged += new System.EventHandler(this.PlayerComboBox_SelectedIndexChanged);
            // 
            // GuestPlayerTwoBindingSource
            // 
            this.GuestPlayerTwoBindingSource.DataSource = typeof(Marathon.Entities.Player);
            // 
            // GuestPlayerOneComboBox
            // 
            this.GuestPlayerOneComboBox.DataSource = this.GuestPlayerOneBindingSource;
            this.GuestPlayerOneComboBox.DisplayMember = "Name";
            this.GuestPlayerOneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GuestPlayerOneComboBox.FormattingEnabled = true;
            this.GuestPlayerOneComboBox.Location = new System.Drawing.Point(285, 62);
            this.GuestPlayerOneComboBox.Name = "GuestPlayerOneComboBox";
            this.GuestPlayerOneComboBox.Size = new System.Drawing.Size(215, 21);
            this.GuestPlayerOneComboBox.TabIndex = 6;
            this.GuestPlayerOneComboBox.ValueMember = "Id";
            this.GuestPlayerOneComboBox.SelectedIndexChanged += new System.EventHandler(this.PlayerComboBox_SelectedIndexChanged);
            // 
            // GuestPlayerOneBindingSource
            // 
            this.GuestPlayerOneBindingSource.DataSource = typeof(Marathon.Entities.Player);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hráč 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hráč 1";
            // 
            // HomePlayerTwoComboBox
            // 
            this.HomePlayerTwoComboBox.DataSource = this.HomePlayerTwoBindingSource;
            this.HomePlayerTwoComboBox.DisplayMember = "Name";
            this.HomePlayerTwoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HomePlayerTwoComboBox.FormattingEnabled = true;
            this.HomePlayerTwoComboBox.Location = new System.Drawing.Point(6, 111);
            this.HomePlayerTwoComboBox.Name = "HomePlayerTwoComboBox";
            this.HomePlayerTwoComboBox.Size = new System.Drawing.Size(215, 21);
            this.HomePlayerTwoComboBox.TabIndex = 3;
            this.HomePlayerTwoComboBox.ValueMember = "Id";
            this.HomePlayerTwoComboBox.SelectedIndexChanged += new System.EventHandler(this.PlayerComboBox_SelectedIndexChanged);
            // 
            // HomePlayerTwoBindingSource
            // 
            this.HomePlayerTwoBindingSource.DataSource = typeof(Marathon.Entities.Player);
            // 
            // HomePlayerOneComboBox
            // 
            this.HomePlayerOneComboBox.DataSource = this.HomePlayerOneBindingSource;
            this.HomePlayerOneComboBox.DisplayMember = "Name";
            this.HomePlayerOneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HomePlayerOneComboBox.FormattingEnabled = true;
            this.HomePlayerOneComboBox.Location = new System.Drawing.Point(6, 62);
            this.HomePlayerOneComboBox.Name = "HomePlayerOneComboBox";
            this.HomePlayerOneComboBox.Size = new System.Drawing.Size(215, 21);
            this.HomePlayerOneComboBox.TabIndex = 2;
            this.HomePlayerOneComboBox.ValueMember = "Id";
            this.HomePlayerOneComboBox.SelectedIndexChanged += new System.EventHandler(this.PlayerComboBox_SelectedIndexChanged);
            // 
            // HomePlayerOneBindingSource
            // 
            this.HomePlayerOneBindingSource.DataSource = typeof(Marathon.Entities.Player);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hosté";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Domácí";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HomePlayersGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 250);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seznam hráčů - domácí";
            // 
            // HomePlayersGridView
            // 
            this.HomePlayersGridView.AllowUserToDeleteRows = false;
            this.HomePlayersGridView.AllowUserToResizeColumns = false;
            this.HomePlayersGridView.AllowUserToResizeRows = false;
            this.HomePlayersGridView.AutoGenerateColumns = false;
            this.HomePlayersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HomePlayersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HomePlayerId,
            this.HomePlayerName,
            this.teamIdDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn});
            this.HomePlayersGridView.DataSource = this.HomePlayerBindingSource;
            this.HomePlayersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePlayersGridView.Location = new System.Drawing.Point(3, 16);
            this.HomePlayersGridView.Name = "HomePlayersGridView";
            this.HomePlayersGridView.Size = new System.Drawing.Size(394, 231);
            this.HomePlayersGridView.TabIndex = 0;
            this.HomePlayersGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.HomePlayersGridView_CellEndEdit);
            this.HomePlayersGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GridView_DataBindingComplete);
            // 
            // HomePlayerId
            // 
            this.HomePlayerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HomePlayerId.DataPropertyName = "Id";
            this.HomePlayerId.HeaderText = "Id";
            this.HomePlayerId.Name = "HomePlayerId";
            this.HomePlayerId.Visible = false;
            // 
            // HomePlayerName
            // 
            this.HomePlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HomePlayerName.DataPropertyName = "Name";
            this.HomePlayerName.HeaderText = "Name";
            this.HomePlayerName.MaxInputLength = 100;
            this.HomePlayerName.Name = "HomePlayerName";
            // 
            // teamIdDataGridViewTextBoxColumn
            // 
            this.teamIdDataGridViewTextBoxColumn.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.Name = "teamIdDataGridViewTextBoxColumn";
            this.teamIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.Visible = false;
            // 
            // HomePlayerBindingSource
            // 
            this.HomePlayerBindingSource.DataSource = typeof(Marathon.Entities.Player);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GuestPlayersGridView);
            this.groupBox2.Location = new System.Drawing.Point(418, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 250);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seznam hráčů - hosté";
            // 
            // GuestPlayersGridView
            // 
            this.GuestPlayersGridView.AllowUserToDeleteRows = false;
            this.GuestPlayersGridView.AllowUserToResizeColumns = false;
            this.GuestPlayersGridView.AllowUserToResizeRows = false;
            this.GuestPlayersGridView.AutoGenerateColumns = false;
            this.GuestPlayersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestPlayersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestPlayerId,
            this.GuestPlayerName,
            this.teamIdDataGridViewTextBoxColumn1,
            this.teamDataGridViewTextBoxColumn1});
            this.GuestPlayersGridView.DataSource = this.GuestPlayerBindingSource;
            this.GuestPlayersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GuestPlayersGridView.Location = new System.Drawing.Point(3, 16);
            this.GuestPlayersGridView.Name = "GuestPlayersGridView";
            this.GuestPlayersGridView.Size = new System.Drawing.Size(394, 231);
            this.GuestPlayersGridView.TabIndex = 0;
            this.GuestPlayersGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GuestPlayersGridView_CellEndEdit);
            this.GuestPlayersGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GridView_DataBindingComplete);
            // 
            // GuestPlayerId
            // 
            this.GuestPlayerId.DataPropertyName = "Id";
            this.GuestPlayerId.HeaderText = "Id";
            this.GuestPlayerId.Name = "GuestPlayerId";
            this.GuestPlayerId.Visible = false;
            // 
            // GuestPlayerName
            // 
            this.GuestPlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GuestPlayerName.DataPropertyName = "Name";
            this.GuestPlayerName.HeaderText = "Name";
            this.GuestPlayerName.MaxInputLength = 100;
            this.GuestPlayerName.Name = "GuestPlayerName";
            // 
            // teamIdDataGridViewTextBoxColumn1
            // 
            this.teamIdDataGridViewTextBoxColumn1.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn1.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn1.Name = "teamIdDataGridViewTextBoxColumn1";
            this.teamIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // teamDataGridViewTextBoxColumn1
            // 
            this.teamDataGridViewTextBoxColumn1.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn1.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn1.Name = "teamDataGridViewTextBoxColumn1";
            this.teamDataGridViewTextBoxColumn1.Visible = false;
            // 
            // GuestPlayerBindingSource
            // 
            this.GuestPlayerBindingSource.DataSource = typeof(Marathon.Entities.Player);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.StartMarathonButton);
            this.groupBox3.Controls.Add(this.ActualTimeTextBox);
            this.groupBox3.Controls.Add(this.StartTimeTextBox);
            this.groupBox3.Controls.Add(this.PlayedTimeTextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.RemainingTimeTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 491);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(806, 106);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Čas";
            // 
            // StartMarathonButton
            // 
            this.StartMarathonButton.Location = new System.Drawing.Point(11, 61);
            this.StartMarathonButton.Name = "StartMarathonButton";
            this.StartMarathonButton.Size = new System.Drawing.Size(75, 23);
            this.StartMarathonButton.TabIndex = 8;
            this.StartMarathonButton.Text = "Start!!!";
            this.StartMarathonButton.UseVisualStyleBackColor = true;
            this.StartMarathonButton.Click += new System.EventHandler(this.StartMarathonButton_Click);
            // 
            // ActualTimeTextBox
            // 
            this.ActualTimeTextBox.Location = new System.Drawing.Point(11, 35);
            this.ActualTimeTextBox.Name = "ActualTimeTextBox";
            this.ActualTimeTextBox.ReadOnly = true;
            this.ActualTimeTextBox.Size = new System.Drawing.Size(139, 20);
            this.ActualTimeTextBox.TabIndex = 7;
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.Location = new System.Drawing.Point(156, 35);
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.ReadOnly = true;
            this.StartTimeTextBox.Size = new System.Drawing.Size(157, 20);
            this.StartTimeTextBox.TabIndex = 6;
            // 
            // PlayedTimeTextBox
            // 
            this.PlayedTimeTextBox.Location = new System.Drawing.Point(319, 35);
            this.PlayedTimeTextBox.Name = "PlayedTimeTextBox";
            this.PlayedTimeTextBox.ReadOnly = true;
            this.PlayedTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlayedTimeTextBox.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(153, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Začátek";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Odehráno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Zbývá do konce";
            // 
            // RemainingTimeTextBox
            // 
            this.RemainingTimeTextBox.Location = new System.Drawing.Point(425, 35);
            this.RemainingTimeTextBox.Name = "RemainingTimeTextBox";
            this.RemainingTimeTextBox.ReadOnly = true;
            this.RemainingTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.RemainingTimeTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Aktuální čas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowResultsMenuItem,
            this.ReverseSideMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 25);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ShowResultsMenuItem
            // 
            this.ShowResultsMenuItem.Name = "ShowResultsMenuItem";
            this.ShowResultsMenuItem.Size = new System.Drawing.Size(120, 21);
            this.ShowResultsMenuItem.Text = "Zobrazit výsledky";
            this.ShowResultsMenuItem.Click += new System.EventHandler(this.ShowResultsMenuItem_Click);
            // 
            // ReverseSideMenuItem
            // 
            this.ReverseSideMenuItem.Name = "ReverseSideMenuItem";
            this.ReverseSideMenuItem.Size = new System.Drawing.Size(94, 21);
            this.ReverseSideMenuItem.Text = "Otočit strany";
            this.ReverseSideMenuItem.Click += new System.EventHandler(this.ReverseSideMenuItem_Click);
            // 
            // actualTimeTimer
            // 
            this.actualTimeTimer.Interval = 500;
            this.actualTimeTimer.Tick += new System.EventHandler(this.actualTimeTimer_Tick);
            // 
            // marathonTimer
            // 
            this.marathonTimer.Interval = 500;
            this.marathonTimer.Tick += new System.EventHandler(this.marathonTimer_Tick);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CurrentPlayers);
            this.Controls.Add(this.GuestGroupBox);
            this.Controls.Add(this.HomeGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministrationForm";
            this.Text = "Maraton - Jílové u Prahy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministrationForm_FormClosing);
            this.HomeGroupBox.ResumeLayout(false);
            this.HomeGroupBox.PerformLayout();
            this.GuestGroupBox.ResumeLayout(false);
            this.GuestGroupBox.PerformLayout();
            this.CurrentPlayers.ResumeLayout(false);
            this.CurrentPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestPlayerTwoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestPlayerOneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePlayerTwoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePlayerOneBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomePlayersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePlayerBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GuestPlayersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestPlayerBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GuestAddPointButton;
        private System.Windows.Forms.Button GuestRemovePointButton;
        private System.Windows.Forms.Button HomeAddPointButton;
        private System.Windows.Forms.Button HomeRemovePointButton;
        private System.Windows.Forms.GroupBox HomeGroupBox;
        private System.Windows.Forms.GroupBox GuestGroupBox;
        private System.Windows.Forms.GroupBox CurrentPlayers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox GuestPlayerTwoComboBox;
        private System.Windows.Forms.ComboBox GuestPlayerOneComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox HomePlayerTwoComboBox;
        private System.Windows.Forms.ComboBox HomePlayerOneComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView HomePlayersGridView;
        private System.Windows.Forms.DataGridView GuestPlayersGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox ActualTimeTextBox;
        private System.Windows.Forms.MaskedTextBox StartTimeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowResultsMenuItem;
        public System.Windows.Forms.MaskedTextBox PlayedTimeTextBox;
        public System.Windows.Forms.MaskedTextBox RemainingTimeTextBox;
        private System.Windows.Forms.Label HomePointsLabel;
        private System.Windows.Forms.Label GuestPointsLabel;
        private System.Windows.Forms.Timer actualTimeTimer;
        private System.Windows.Forms.Button StartMarathonButton;
        private System.Windows.Forms.Timer marathonTimer;
        private System.Windows.Forms.BindingSource HomePlayerBindingSource;
        private System.Windows.Forms.BindingSource GuestPlayerBindingSource;
        private System.Windows.Forms.BindingSource HomePlayerTwoBindingSource;
        private System.Windows.Forms.BindingSource HomePlayerOneBindingSource;
        private System.Windows.Forms.BindingSource GuestPlayerTwoBindingSource;
        private System.Windows.Forms.BindingSource GuestPlayerOneBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomePlayerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomePlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerOnePointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerTwoPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestPlayerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestPlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerOnePointsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerTwoPointsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem ReverseSideMenuItem;
    }
}

