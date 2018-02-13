﻿using System;
using System.IO;
using System.Windows.Forms;
using Arbingersys.Audio.Aumplib;

namespace AudioConverter
{
    partial class Window
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceFileButton = new System.Windows.Forms.Button();
            this.destFileButton = new System.Windows.Forms.Button();
            this.sourceFileLabel = new System.Windows.Forms.Label();
            this.destFileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourceFileButton
            // 
            this.sourceFileButton.Location = new System.Drawing.Point(12, 12);
            this.sourceFileButton.Name = "sourceFileButton";
            this.sourceFileButton.Size = new System.Drawing.Size(95, 35);
            this.sourceFileButton.TabIndex = 0;
            this.sourceFileButton.Text = "open";
            this.sourceFileButton.UseVisualStyleBackColor = true;
            // 
            // destFileButton
            // 
            this.destFileButton.Location = new System.Drawing.Point(13, 106);
            this.destFileButton.Name = "destFileButton";
            this.destFileButton.Size = new System.Drawing.Size(94, 35);
            this.destFileButton.TabIndex = 1;
            this.destFileButton.Text = "save";
            this.destFileButton.UseVisualStyleBackColor = true;
            // 
            // sourceFileLabel
            // 
            this.sourceFileLabel.AutoSize = true;
            this.sourceFileLabel.Location = new System.Drawing.Point(188, 17);
            this.sourceFileLabel.Name = "sourceFileLabel";
            this.sourceFileLabel.Size = new System.Drawing.Size(111, 25);
            this.sourceFileLabel.TabIndex = 2;
            this.sourceFileLabel.Text = "Not selected";
            // 
            // destFileLabel
            // 
            this.destFileLabel.AutoSize = true;
            this.destFileLabel.Location = new System.Drawing.Point(188, 106);
            this.destFileLabel.Name = "destFileLabel";
            this.destFileLabel.Size = new System.Drawing.Size(111, 25);
            this.destFileLabel.TabIndex = 3;
            this.destFileLabel.Text = "Not selected";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 321);
            this.Controls.Add(this.destFileLabel);
            this.Controls.Add(this.sourceFileLabel);
            this.Controls.Add(this.destFileButton);
            this.Controls.Add(this.sourceFileButton);
            this.Name = "Window";
            this.Text = "Audio Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sourceFileButton;
        private Button destFileButton;
        private Label sourceFileLabel;
        private Label destFileLabel;
    }
}

