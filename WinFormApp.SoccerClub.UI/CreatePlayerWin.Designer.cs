namespace WinFormApp.SoccerClub.UI
{
    partial class CreatePlayerWin
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
            this.SuspendLayout();
            // 
            // playersCreator
            // 
            this.playersCreator = new UI.Controls.PlayersEditorView();
            this.playersCreator.AutoSize = true;
            this.playersCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersCreator.Location = new System.Drawing.Point(0, 0);
            this.playersCreator.Name = "playersCreator";
            this.playersCreator.Size = new System.Drawing.Size(334, 152);
            this.playersCreator.TabIndex = 0;
            // 
            // CreatePlayerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 152);
            this.Controls.Add(this.playersCreator);
            this.Name = "CreatePlayerWin";
            this.Text = "Register Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal Controls.PlayersEditorView playersCreator;
    }
}