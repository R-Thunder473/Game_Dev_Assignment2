
namespace Learn_A_Language_Kids
{
    partial class Frm2
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
            this.btnFrench = new System.Windows.Forms.Button();
            this.btnSpanish = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFrench
            // 
            this.btnFrench.BackgroundImage = global::Learn_A_Language_Kids.Properties.Resources.france;
            this.btnFrench.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrench.Location = new System.Drawing.Point(241, 108);
            this.btnFrench.Name = "btnFrench";
            this.btnFrench.Size = new System.Drawing.Size(93, 68);
            this.btnFrench.TabIndex = 0;
            this.btnFrench.UseVisualStyleBackColor = true;
            this.btnFrench.Click += new System.EventHandler(this.btnFrench_Click);
            // 
            // btnSpanish
            // 
            this.btnSpanish.BackgroundImage = global::Learn_A_Language_Kids.Properties.Resources.spain;
            this.btnSpanish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpanish.Location = new System.Drawing.Point(241, 202);
            this.btnSpanish.Name = "btnSpanish";
            this.btnSpanish.Size = new System.Drawing.Size(93, 68);
            this.btnSpanish.TabIndex = 1;
            this.btnSpanish.UseVisualStyleBackColor = true;
            this.btnSpanish.Click += new System.EventHandler(this.btnSpanish_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(241, 300);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 68);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(130, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(328, 42);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Label1";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnSpanish);
            this.Controls.Add(this.btnFrench);
            this.Name = "Frm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFrench;
        private System.Windows.Forms.Button btnSpanish;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lbl1;
    }
}