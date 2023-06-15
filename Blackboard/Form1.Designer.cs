namespace Blackboard
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
            this.pnlBlackboard = new System.Windows.Forms.Panel();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.rdoYellow = new System.Windows.Forms.RadioButton();
            this.rdoMagenta = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoCyan = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoGray = new System.Windows.Forms.RadioButton();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBlackboard
            // 
            this.pnlBlackboard.BackColor = System.Drawing.Color.Black;
            this.pnlBlackboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBlackboard.Location = new System.Drawing.Point(13, 13);
            this.pnlBlackboard.Name = "pnlBlackboard";
            this.pnlBlackboard.Size = new System.Drawing.Size(684, 415);
            this.pnlBlackboard.TabIndex = 0;
            this.pnlBlackboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBlackboard_MouseDown);
            this.pnlBlackboard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBlackboard_MouseMove);
            this.pnlBlackboard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBlackboard_MouseUp);
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.rdoWhite);
            this.grpColor.Controls.Add(this.rdoYellow);
            this.grpColor.Controls.Add(this.rdoMagenta);
            this.grpColor.Controls.Add(this.rdoRed);
            this.grpColor.Controls.Add(this.rdoCyan);
            this.grpColor.Controls.Add(this.rdoGreen);
            this.grpColor.Controls.Add(this.rdoBlue);
            this.grpColor.Controls.Add(this.rdoGray);
            this.grpColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpColor.Location = new System.Drawing.Point(719, 13);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(166, 249);
            this.grpColor.TabIndex = 1;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            this.grpColor.Enter += new System.EventHandler(this.grpColor_Enter);
            // 
            // rdoWhite
            // 
            this.rdoWhite.AutoSize = true;
            this.rdoWhite.Location = new System.Drawing.Point(36, 182);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(64, 20);
            this.rdoWhite.TabIndex = 7;
            this.rdoWhite.TabStop = true;
            this.rdoWhite.Text = "White";
            this.rdoWhite.UseVisualStyleBackColor = true;
            this.rdoWhite.CheckedChanged += new System.EventHandler(this.rdoWhite_CheckedChanged);
            // 
            // rdoYellow
            // 
            this.rdoYellow.AutoSize = true;
            this.rdoYellow.Location = new System.Drawing.Point(36, 159);
            this.rdoYellow.Name = "rdoYellow";
            this.rdoYellow.Size = new System.Drawing.Size(71, 20);
            this.rdoYellow.TabIndex = 6;
            this.rdoYellow.TabStop = true;
            this.rdoYellow.Text = "Yellow";
            this.rdoYellow.UseVisualStyleBackColor = true;
            this.rdoYellow.CheckedChanged += new System.EventHandler(this.rdoYellow_CheckedChanged);
            // 
            // rdoMagenta
            // 
            this.rdoMagenta.AutoSize = true;
            this.rdoMagenta.Location = new System.Drawing.Point(36, 136);
            this.rdoMagenta.Name = "rdoMagenta";
            this.rdoMagenta.Size = new System.Drawing.Size(85, 20);
            this.rdoMagenta.TabIndex = 5;
            this.rdoMagenta.TabStop = true;
            this.rdoMagenta.Text = "Magenta";
            this.rdoMagenta.UseVisualStyleBackColor = true;
            this.rdoMagenta.CheckedChanged += new System.EventHandler(this.rdoMagenta_CheckedChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(36, 113);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(54, 20);
            this.rdoRed.TabIndex = 4;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // rdoCyan
            // 
            this.rdoCyan.AutoSize = true;
            this.rdoCyan.Location = new System.Drawing.Point(36, 90);
            this.rdoCyan.Name = "rdoCyan";
            this.rdoCyan.Size = new System.Drawing.Size(60, 20);
            this.rdoCyan.TabIndex = 3;
            this.rdoCyan.TabStop = true;
            this.rdoCyan.Text = "Cyan";
            this.rdoCyan.UseVisualStyleBackColor = true;
            this.rdoCyan.CheckedChanged += new System.EventHandler(this.rdoCyan_CheckedChanged);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(36, 67);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(67, 20);
            this.rdoGreen.TabIndex = 2;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Green";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(36, 44);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(56, 20);
            this.rdoBlue.TabIndex = 1;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoGray
            // 
            this.rdoGray.AutoSize = true;
            this.rdoGray.Location = new System.Drawing.Point(36, 21);
            this.rdoGray.Name = "rdoGray";
            this.rdoGray.Size = new System.Drawing.Size(58, 20);
            this.rdoGray.TabIndex = 0;
            this.rdoGray.TabStop = true;
            this.rdoGray.Text = "Gray";
            this.rdoGray.UseVisualStyleBackColor = true;
            this.rdoGray.CheckedChanged += new System.EventHandler(this.rdoGray_CheckedChanged);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(755, 289);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(85, 23);
            this.btnErase.TabIndex = 2;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(755, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 445);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.pnlBlackboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackboard Fun";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBlackboard;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton rdoWhite;
        private System.Windows.Forms.RadioButton rdoYellow;
        private System.Windows.Forms.RadioButton rdoMagenta;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoCyan;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoGray;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnExit;
    }
}

