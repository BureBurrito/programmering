namespace Positioner__Fungerande_
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
            this.tbxPosition = new System.Windows.Forms.RichTextBox();
            this.btnPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPosition
            // 
            this.tbxPosition.Location = new System.Drawing.Point(12, 12);
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.Size = new System.Drawing.Size(244, 128);
            this.tbxPosition.TabIndex = 0;
            this.tbxPosition.Text = "";
            // 
            // btnPosition
            // 
            this.btnPosition.Location = new System.Drawing.Point(68, 146);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(125, 25);
            this.btnPosition.TabIndex = 1;
            this.btnPosition.Text = "Visa position";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.BtnPosition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 182);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.tbxPosition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbxPosition;
        private System.Windows.Forms.Button btnPosition;
    }
}

