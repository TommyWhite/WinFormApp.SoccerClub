namespace WinFormApp.SoccerClub.UI.Controls
{
    partial class PlayersView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layerPlayerView = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridPlayers = new System.Windows.Forms.DataGridView();
            this.tableLayoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tableLayoutCurrentPlayer = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.domainUpDownAge = new System.Windows.Forms.DomainUpDown();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCurrentID = new System.Windows.Forms.Label();
            this.layerPlayerView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayers)).BeginInit();
            this.tableLayoutButtons.SuspendLayout();
            this.tableLayoutCurrentPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // layerPlayerView
            // 
            this.layerPlayerView.ColumnCount = 2;
            this.layerPlayerView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.34825F));
            this.layerPlayerView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.65175F));
            this.layerPlayerView.Controls.Add(this.dataGridPlayers, 0, 0);
            this.layerPlayerView.Controls.Add(this.tableLayoutButtons, 2, 1);
            this.layerPlayerView.Controls.Add(this.tableLayoutCurrentPlayer, 1, 0);
            this.layerPlayerView.Location = new System.Drawing.Point(3, 3);
            this.layerPlayerView.Name = "layerPlayerView";
            this.layerPlayerView.RowCount = 2;
            this.layerPlayerView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.16102F));
            this.layerPlayerView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.838983F));
            this.layerPlayerView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layerPlayerView.Size = new System.Drawing.Size(827, 472);
            this.layerPlayerView.TabIndex = 0;
            // 
            // dataGridPlayers
            // 
            this.dataGridPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPlayers.Location = new System.Drawing.Point(3, 3);
            this.dataGridPlayers.Name = "dataGridPlayers";
            this.layerPlayerView.SetRowSpan(this.dataGridPlayers, 2);
            this.dataGridPlayers.Size = new System.Drawing.Size(460, 466);
            this.dataGridPlayers.TabIndex = 0;
            // 
            // tableLayoutButtons
            // 
            this.tableLayoutButtons.ColumnCount = 3;
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutButtons.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutButtons.Controls.Add(this.btnUpdate, 1, 0);
            this.tableLayoutButtons.Controls.Add(this.btnCreate, 0, 0);
            this.tableLayoutButtons.Location = new System.Drawing.Point(469, 438);
            this.tableLayoutButtons.Name = "tableLayoutButtons";
            this.tableLayoutButtons.RowCount = 1;
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutButtons.Size = new System.Drawing.Size(355, 31);
            this.tableLayoutButtons.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(235, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 25);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(120, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 25);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(111, 25);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // tableLayoutCurrentPlayer
            // 
            this.tableLayoutCurrentPlayer.ColumnCount = 2;
            this.tableLayoutCurrentPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.97059F));
            this.tableLayoutCurrentPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.02941F));
            this.tableLayoutCurrentPlayer.Controls.Add(this.lblName, 0, 2);
            this.tableLayoutCurrentPlayer.Controls.Add(this.lblAge, 0, 3);
            this.tableLayoutCurrentPlayer.Controls.Add(this.lblPosition, 0, 4);
            this.tableLayoutCurrentPlayer.Controls.Add(this.txtBoxName, 1, 2);
            this.tableLayoutCurrentPlayer.Controls.Add(this.domainUpDownAge, 1, 3);
            this.tableLayoutCurrentPlayer.Controls.Add(this.comboBoxPosition, 1, 4);
            this.tableLayoutCurrentPlayer.Controls.Add(this.lblID, 0, 1);
            this.tableLayoutCurrentPlayer.Controls.Add(this.lblCurrentID, 1, 1);
            this.tableLayoutCurrentPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutCurrentPlayer.Location = new System.Drawing.Point(469, 3);
            this.tableLayoutCurrentPlayer.Name = "tableLayoutCurrentPlayer";
            this.tableLayoutCurrentPlayer.RowCount = 6;
            this.tableLayoutCurrentPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.31746F));
            this.tableLayoutCurrentPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.68254F));
            this.tableLayoutCurrentPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutCurrentPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutCurrentPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutCurrentPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutCurrentPlayer.Size = new System.Drawing.Size(355, 429);
            this.tableLayoutCurrentPlayer.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 212);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAge.Location = new System.Drawing.Point(3, 244);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(132, 33);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosition.Location = new System.Drawing.Point(3, 277);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(132, 25);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxName.Location = new System.Drawing.Point(141, 220);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(211, 20);
            this.txtBoxName.TabIndex = 3;
            // 
            // domainUpDownAge
            // 
            this.domainUpDownAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.domainUpDownAge.Location = new System.Drawing.Point(141, 252);
            this.domainUpDownAge.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.domainUpDownAge.Name = "domainUpDownAge";
            this.domainUpDownAge.Size = new System.Drawing.Size(211, 20);
            this.domainUpDownAge.TabIndex = 4;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(141, 280);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(211, 21);
            this.comboBoxPosition.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Location = new System.Drawing.Point(3, 181);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(132, 31);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentID
            // 
            this.lblCurrentID.AutoSize = true;
            this.lblCurrentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentID.Location = new System.Drawing.Point(141, 181);
            this.lblCurrentID.Name = "lblCurrentID";
            this.lblCurrentID.Size = new System.Drawing.Size(211, 31);
            this.lblCurrentID.TabIndex = 7;
            this.lblCurrentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layerPlayerView);
            this.Name = "PlayersView";
            this.Size = new System.Drawing.Size(833, 478);
            this.layerPlayerView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayers)).EndInit();
            this.tableLayoutButtons.ResumeLayout(false);
            this.tableLayoutCurrentPlayer.ResumeLayout(false);
            this.tableLayoutCurrentPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layerPlayerView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCurrentPlayer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPosition;
        protected internal System.Windows.Forms.TextBox txtBoxName;
        protected internal System.Windows.Forms.DomainUpDown domainUpDownAge;
        protected internal System.Windows.Forms.ComboBox comboBoxPosition;
        protected internal System.Windows.Forms.Button btnUpdate;
        protected internal System.Windows.Forms.Button btnDelete;
        protected internal System.Windows.Forms.DataGridView dataGridPlayers;
        protected internal System.Windows.Forms.Label lblID;
        protected internal System.Windows.Forms.Label lblCurrentID;
        private System.Windows.Forms.Button btnCreate;
    }
}
