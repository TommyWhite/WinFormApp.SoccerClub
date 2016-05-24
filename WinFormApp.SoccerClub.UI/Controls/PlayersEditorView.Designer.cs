namespace WinFormApp.SoccerClub.UI.Controls
{
    partial class PlayersEditorView
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
            this.tableLayoutCurrentPlayer = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.domainUpDownAge = new System.Windows.Forms.DomainUpDown();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCurrentID = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutCurrentPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutCurrentPlayer
            // 
            this.tableLayoutCurrentPlayer.ColumnCount = 2;
            this.tableLayoutCurrentPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.97059F));
            this.tableLayoutCurrentPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.02941F));
            this.tableLayoutCurrentPlayer.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutCurrentPlayer.Controls.Add(this.lblAge, 0, 2);
            this.tableLayoutCurrentPlayer.Controls.Add(this.lblPosition, 0, 3);
            this.tableLayoutCurrentPlayer.Controls.Add(this.txtBoxName, 1, 1);
            this.tableLayoutCurrentPlayer.Controls.Add(this.domainUpDownAge, 1, 2);
            this.tableLayoutCurrentPlayer.Controls.Add(this.comboBoxPosition, 1, 3);
            this.tableLayoutCurrentPlayer.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutCurrentPlayer.Controls.Add(this.lblCurrentID, 1, 0);
            this.tableLayoutCurrentPlayer.Controls.Add(this.btnOK, 0, 4);
            this.tableLayoutCurrentPlayer.Controls.Add(this.btnCancel, 1, 4);
            this.tableLayoutCurrentPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutCurrentPlayer.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutCurrentPlayer.Name = "tableLayoutCurrentPlayer";
            this.tableLayoutCurrentPlayer.RowCount = 5;
            this.tableLayoutCurrentPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutCurrentPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutCurrentPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutCurrentPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutCurrentPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutCurrentPlayer.Size = new System.Drawing.Size(301, 154);
            this.tableLayoutCurrentPlayer.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAge.Location = new System.Drawing.Point(3, 44);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(111, 31);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosition.Location = new System.Drawing.Point(3, 75);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(111, 27);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxName.Location = new System.Drawing.Point(120, 21);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(178, 20);
            this.txtBoxName.TabIndex = 3;
            // 
            // domainUpDownAge
            // 
            this.domainUpDownAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.domainUpDownAge.Location = new System.Drawing.Point(120, 52);
            this.domainUpDownAge.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.domainUpDownAge.Name = "domainUpDownAge";
            this.domainUpDownAge.Size = new System.Drawing.Size(178, 20);
            this.domainUpDownAge.TabIndex = 4;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(120, 78);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(178, 21);
            this.comboBoxPosition.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(111, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentID
            // 
            this.lblCurrentID.AutoSize = true;
            this.lblCurrentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentID.Location = new System.Drawing.Point(120, 0);
            this.lblCurrentID.Name = "lblCurrentID";
            this.lblCurrentID.Size = new System.Drawing.Size(178, 13);
            this.lblCurrentID.TabIndex = 7;
            this.lblCurrentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Location = new System.Drawing.Point(10, 112);
            this.btnOK.Margin = new System.Windows.Forms.Padding(10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 32);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(127, 112);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PlayersEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutCurrentPlayer);
            this.Name = "PlayersEditorView";
            this.Size = new System.Drawing.Size(301, 154);
            this.tableLayoutCurrentPlayer.ResumeLayout(false);
            this.tableLayoutCurrentPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Label lblCurrentID;
        protected internal System.Windows.Forms.Label lblID;
        protected internal System.Windows.Forms.ComboBox comboBoxPosition;
        protected internal System.Windows.Forms.DomainUpDown domainUpDownAge;
        protected internal System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCurrentPlayer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
