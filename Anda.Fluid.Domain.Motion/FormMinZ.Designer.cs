﻿namespace Anda.Fluid.Domain.Motion
{
    partial class FormMinZ
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
            this.jogControl1 = new Anda.Fluid.Domain.Motion.JogControl();
            this.txtMinZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jogControl1
            // 
            this.jogControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogControl1.Location = new System.Drawing.Point(16, 42);
            this.jogControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.jogControl1.Name = "jogControl1";
            this.jogControl1.Size = new System.Drawing.Size(179, 236);
            this.jogControl1.TabIndex = 0;
            // 
            // txtMinZ
            // 
            this.txtMinZ.Location = new System.Drawing.Point(63, 12);
            this.txtMinZ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinZ.Name = "txtMinZ";
            this.txtMinZ.Size = new System.Drawing.Size(132, 22);
            this.txtMinZ.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min Z";
            // 
            // btnTeach
            // 
            this.btnTeach.Location = new System.Drawing.Point(203, 9);
            this.btnTeach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTeach.Name = "btnTeach";
            this.btnTeach.Size = new System.Drawing.Size(100, 27);
            this.btnTeach.TabIndex = 3;
            this.btnTeach.Text = "Teach";
            this.btnTeach.UseVisualStyleBackColor = true;
            // 
            // FormMinZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 257);
            this.Controls.Add(this.btnTeach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinZ);
            this.Controls.Add(this.jogControl1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMinZ";
            this.Text = "FormMinZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Domain.Motion.JogControl jogControl1;
        private System.Windows.Forms.TextBox txtMinZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTeach;
    }
}