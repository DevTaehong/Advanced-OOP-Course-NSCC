
namespace FormOneAbcCompany
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
            this.startBT = new System.Windows.Forms.Button();
            this.downLoadPB = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // startBT
            // 
            this.startBT.BackColor = System.Drawing.Color.Silver;
            this.startBT.Location = new System.Drawing.Point(949, 188);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(209, 79);
            this.startBT.TabIndex = 0;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = false;
            this.startBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // downLoadPB
            // 
            this.downLoadPB.Location = new System.Drawing.Point(61, 188);
            this.downLoadPB.Name = "downLoadPB";
            this.downLoadPB.Size = new System.Drawing.Size(766, 79);
            this.downLoadPB.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1348, 397);
            this.Controls.Add(this.downLoadPB);
            this.Controls.Add(this.startBT);
            this.Name = "MainForm";
            this.Text = "ABC Company";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBT; //Creaeting new control object
        private System.Windows.Forms.ProgressBar downLoadPB;
    }
}

