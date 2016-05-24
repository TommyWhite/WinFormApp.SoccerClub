using WinFormApp.SoccerClub.UI.Controls;

namespace WinFormApp.SoccerClub.UI
{
    partial class MainForm
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
            this.playersView = new WinFormApp.SoccerClub.UI.Controls.PlayersView();
            this.SuspendLayout();
            // 
            // playersView
            // 
            this.playersView.Location = new System.Drawing.Point(12, 2);
            this.playersView.Name = "playersView";
            this.playersView.Presenter = null;
            this.playersView.Size = new System.Drawing.Size(833, 478);
            this.playersView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 485);
            this.Controls.Add(this.playersView);
            this.Name = "MainForm";
            this.Text = "Soccer Club";
            this.ResumeLayout(false);

        }

        #endregion

        protected internal PlayersView playersView;
    }
}

