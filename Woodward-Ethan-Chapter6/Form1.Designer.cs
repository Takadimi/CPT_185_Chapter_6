﻿namespace Woodward_Ethan_Chapter6
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
            this.components = new System.ComponentModel.Container();
            this.grpbxOilAndLube = new System.Windows.Forms.GroupBox();
            this.chkbxLubeJob = new System.Windows.Forms.CheckBox();
            this.chkbxOilChange = new System.Windows.Forms.CheckBox();
            this.grpbxFlushes = new System.Windows.Forms.GroupBox();
            this.chkbxTransFlush = new System.Windows.Forms.CheckBox();
            this.chkbxRadFlush = new System.Windows.Forms.CheckBox();
            this.grpbxMisc = new System.Windows.Forms.GroupBox();
            this.chkbxTireRot = new System.Windows.Forms.CheckBox();
            this.chkbxReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.chkbxInspection = new System.Windows.Forms.CheckBox();
            this.grpbxPartsAndLabor = new System.Windows.Forms.GroupBox();
            this.lblLabor = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.txtbxLabor = new System.Windows.Forms.TextBox();
            this.txtbxParts = new System.Windows.Forms.TextBox();
            this.grpbxSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblPartsSummary = new System.Windows.Forms.Label();
            this.lblServicesAndLabor = new System.Windows.Forms.Label();
            this.txtbxTotal = new System.Windows.Forms.TextBox();
            this.txtbxTax = new System.Windows.Forms.TextBox();
            this.txtbxPartsSummary = new System.Windows.Forms.TextBox();
            this.txtbxServicesAndLabor = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbxOilAndLube.SuspendLayout();
            this.grpbxFlushes.SuspendLayout();
            this.grpbxMisc.SuspendLayout();
            this.grpbxPartsAndLabor.SuspendLayout();
            this.grpbxSummary.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxOilAndLube
            // 
            this.grpbxOilAndLube.Controls.Add(this.chkbxLubeJob);
            this.grpbxOilAndLube.Controls.Add(this.chkbxOilChange);
            this.grpbxOilAndLube.Location = new System.Drawing.Point(13, 33);
            this.grpbxOilAndLube.Name = "grpbxOilAndLube";
            this.grpbxOilAndLube.Size = new System.Drawing.Size(220, 112);
            this.grpbxOilAndLube.TabIndex = 0;
            this.grpbxOilAndLube.TabStop = false;
            this.grpbxOilAndLube.Text = "Oil && Lube";
            // 
            // chkbxLubeJob
            // 
            this.chkbxLubeJob.AutoSize = true;
            this.chkbxLubeJob.Location = new System.Drawing.Point(11, 69);
            this.chkbxLubeJob.Name = "chkbxLubeJob";
            this.chkbxLubeJob.Size = new System.Drawing.Size(149, 20);
            this.chkbxLubeJob.TabIndex = 1;
            this.chkbxLubeJob.Text = "Lube Job ($18.00)";
            this.chkbxLubeJob.UseVisualStyleBackColor = true;
            // 
            // chkbxOilChange
            // 
            this.chkbxOilChange.AutoSize = true;
            this.chkbxOilChange.Location = new System.Drawing.Point(11, 31);
            this.chkbxOilChange.Name = "chkbxOilChange";
            this.chkbxOilChange.Size = new System.Drawing.Size(161, 20);
            this.chkbxOilChange.TabIndex = 0;
            this.chkbxOilChange.Text = "Oil Change ($26.00)";
            this.chkbxOilChange.UseVisualStyleBackColor = true;
            // 
            // grpbxFlushes
            // 
            this.grpbxFlushes.Controls.Add(this.chkbxTransFlush);
            this.grpbxFlushes.Controls.Add(this.chkbxRadFlush);
            this.grpbxFlushes.Location = new System.Drawing.Point(243, 33);
            this.grpbxFlushes.Name = "grpbxFlushes";
            this.grpbxFlushes.Size = new System.Drawing.Size(252, 112);
            this.grpbxFlushes.TabIndex = 2;
            this.grpbxFlushes.TabStop = false;
            this.grpbxFlushes.Text = "Flushes";
            // 
            // chkbxTransFlush
            // 
            this.chkbxTransFlush.AutoSize = true;
            this.chkbxTransFlush.Location = new System.Drawing.Point(16, 69);
            this.chkbxTransFlush.Name = "chkbxTransFlush";
            this.chkbxTransFlush.Size = new System.Drawing.Size(219, 20);
            this.chkbxTransFlush.TabIndex = 1;
            this.chkbxTransFlush.Text = "Transmission Flush ($80.00)";
            this.chkbxTransFlush.UseVisualStyleBackColor = true;
            // 
            // chkbxRadFlush
            // 
            this.chkbxRadFlush.AutoSize = true;
            this.chkbxRadFlush.Location = new System.Drawing.Point(16, 31);
            this.chkbxRadFlush.Name = "chkbxRadFlush";
            this.chkbxRadFlush.Size = new System.Drawing.Size(186, 20);
            this.chkbxRadFlush.TabIndex = 0;
            this.chkbxRadFlush.Text = "Radiator Flush ($30.00)";
            this.chkbxRadFlush.UseVisualStyleBackColor = true;
            // 
            // grpbxMisc
            // 
            this.grpbxMisc.Controls.Add(this.chkbxTireRot);
            this.grpbxMisc.Controls.Add(this.chkbxReplaceMuffler);
            this.grpbxMisc.Controls.Add(this.chkbxInspection);
            this.grpbxMisc.Location = new System.Drawing.Point(13, 151);
            this.grpbxMisc.Name = "grpbxMisc";
            this.grpbxMisc.Size = new System.Drawing.Size(220, 187);
            this.grpbxMisc.TabIndex = 1;
            this.grpbxMisc.TabStop = false;
            this.grpbxMisc.Text = "Misc";
            // 
            // chkbxTireRot
            // 
            this.chkbxTireRot.AutoSize = true;
            this.chkbxTireRot.Location = new System.Drawing.Point(11, 133);
            this.chkbxTireRot.Name = "chkbxTireRot";
            this.chkbxTireRot.Size = new System.Drawing.Size(175, 20);
            this.chkbxTireRot.TabIndex = 2;
            this.chkbxTireRot.Text = "Tire Rotation ($20.00)";
            this.chkbxTireRot.UseVisualStyleBackColor = true;
            // 
            // chkbxReplaceMuffler
            // 
            this.chkbxReplaceMuffler.AutoSize = true;
            this.chkbxReplaceMuffler.Location = new System.Drawing.Point(11, 90);
            this.chkbxReplaceMuffler.Name = "chkbxReplaceMuffler";
            this.chkbxReplaceMuffler.Size = new System.Drawing.Size(202, 20);
            this.chkbxReplaceMuffler.TabIndex = 1;
            this.chkbxReplaceMuffler.Text = "Replace Muffler ($100.00)";
            this.chkbxReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // chkbxInspection
            // 
            this.chkbxInspection.AutoSize = true;
            this.chkbxInspection.Location = new System.Drawing.Point(11, 46);
            this.chkbxInspection.Name = "chkbxInspection";
            this.chkbxInspection.Size = new System.Drawing.Size(156, 20);
            this.chkbxInspection.TabIndex = 0;
            this.chkbxInspection.Text = "Inspection ($15.00)";
            this.chkbxInspection.UseVisualStyleBackColor = true;
            // 
            // grpbxPartsAndLabor
            // 
            this.grpbxPartsAndLabor.Controls.Add(this.lblLabor);
            this.grpbxPartsAndLabor.Controls.Add(this.lblParts);
            this.grpbxPartsAndLabor.Controls.Add(this.txtbxLabor);
            this.grpbxPartsAndLabor.Controls.Add(this.txtbxParts);
            this.grpbxPartsAndLabor.Location = new System.Drawing.Point(243, 151);
            this.grpbxPartsAndLabor.Name = "grpbxPartsAndLabor";
            this.grpbxPartsAndLabor.Size = new System.Drawing.Size(252, 187);
            this.grpbxPartsAndLabor.TabIndex = 3;
            this.grpbxPartsAndLabor.TabStop = false;
            this.grpbxPartsAndLabor.Text = "Parts && Labor";
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(29, 118);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(70, 16);
            this.lblLabor.TabIndex = 3;
            this.lblLabor.Text = "Labor ($)";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(55, 47);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(44, 16);
            this.lblParts.TabIndex = 2;
            this.lblParts.Text = "Parts";
            // 
            // txtbxLabor
            // 
            this.txtbxLabor.Location = new System.Drawing.Point(105, 115);
            this.txtbxLabor.Name = "txtbxLabor";
            this.txtbxLabor.Size = new System.Drawing.Size(73, 22);
            this.txtbxLabor.TabIndex = 1;
            this.txtbxLabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbxParts
            // 
            this.txtbxParts.Location = new System.Drawing.Point(105, 46);
            this.txtbxParts.Name = "txtbxParts";
            this.txtbxParts.Size = new System.Drawing.Size(73, 22);
            this.txtbxParts.TabIndex = 0;
            this.txtbxParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpbxSummary
            // 
            this.grpbxSummary.Controls.Add(this.lblTotalFees);
            this.grpbxSummary.Controls.Add(this.lblTax);
            this.grpbxSummary.Controls.Add(this.lblPartsSummary);
            this.grpbxSummary.Controls.Add(this.lblServicesAndLabor);
            this.grpbxSummary.Controls.Add(this.txtbxTotal);
            this.grpbxSummary.Controls.Add(this.txtbxTax);
            this.grpbxSummary.Controls.Add(this.txtbxPartsSummary);
            this.grpbxSummary.Controls.Add(this.txtbxServicesAndLabor);
            this.grpbxSummary.Location = new System.Drawing.Point(13, 344);
            this.grpbxSummary.Name = "grpbxSummary";
            this.grpbxSummary.Size = new System.Drawing.Size(482, 187);
            this.grpbxSummary.TabIndex = 4;
            this.grpbxSummary.TabStop = false;
            this.grpbxSummary.Text = "Summary";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(66, 153);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(83, 16);
            this.lblTotalFees.TabIndex = 8;
            this.lblTotalFees.Text = "Total Fees";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(45, 111);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(104, 16);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "Tax (on parts)";
            // 
            // lblPartsSummary
            // 
            this.lblPartsSummary.AutoSize = true;
            this.lblPartsSummary.Location = new System.Drawing.Point(105, 71);
            this.lblPartsSummary.Name = "lblPartsSummary";
            this.lblPartsSummary.Size = new System.Drawing.Size(44, 16);
            this.lblPartsSummary.TabIndex = 6;
            this.lblPartsSummary.Text = "Parts";
            // 
            // lblServicesAndLabor
            // 
            this.lblServicesAndLabor.AutoSize = true;
            this.lblServicesAndLabor.Location = new System.Drawing.Point(22, 27);
            this.lblServicesAndLabor.Name = "lblServicesAndLabor";
            this.lblServicesAndLabor.Size = new System.Drawing.Size(127, 16);
            this.lblServicesAndLabor.TabIndex = 4;
            this.lblServicesAndLabor.Text = "Services && Labor";
            // 
            // txtbxTotal
            // 
            this.txtbxTotal.Enabled = false;
            this.txtbxTotal.Location = new System.Drawing.Point(173, 150);
            this.txtbxTotal.Name = "txtbxTotal";
            this.txtbxTotal.Size = new System.Drawing.Size(100, 22);
            this.txtbxTotal.TabIndex = 3;
            this.txtbxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbxTax
            // 
            this.txtbxTax.Enabled = false;
            this.txtbxTax.Location = new System.Drawing.Point(173, 108);
            this.txtbxTax.Name = "txtbxTax";
            this.txtbxTax.Size = new System.Drawing.Size(100, 22);
            this.txtbxTax.TabIndex = 2;
            this.txtbxTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbxPartsSummary
            // 
            this.txtbxPartsSummary.Enabled = false;
            this.txtbxPartsSummary.Location = new System.Drawing.Point(173, 68);
            this.txtbxPartsSummary.Name = "txtbxPartsSummary";
            this.txtbxPartsSummary.Size = new System.Drawing.Size(100, 22);
            this.txtbxPartsSummary.TabIndex = 1;
            this.txtbxPartsSummary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbxServicesAndLabor
            // 
            this.txtbxServicesAndLabor.Enabled = false;
            this.txtbxServicesAndLabor.Location = new System.Drawing.Point(173, 24);
            this.txtbxServicesAndLabor.Name = "txtbxServicesAndLabor";
            this.txtbxServicesAndLabor.Size = new System.Drawing.Size(100, 22);
            this.txtbxServicesAndLabor.TabIndex = 0;
            this.txtbxServicesAndLabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(35, 543);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(138, 45);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "&Calculate Total";
            this.toolTip1.SetToolTip(this.btnCalc, "Calculate the sum of all services and parts");
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 543);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 45);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C&lear";
            this.toolTip1.SetToolTip(this.btnClear, "Clear ALL fields");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(340, 543);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 45);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the program");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen;
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(507, 599);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpbxSummary);
            this.Controls.Add(this.grpbxPartsAndLabor);
            this.Controls.Add(this.grpbxMisc);
            this.Controls.Add(this.grpbxFlushes);
            this.Controls.Add(this.grpbxOilAndLube);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joe\'s Automotive Shop";
            this.grpbxOilAndLube.ResumeLayout(false);
            this.grpbxOilAndLube.PerformLayout();
            this.grpbxFlushes.ResumeLayout(false);
            this.grpbxFlushes.PerformLayout();
            this.grpbxMisc.ResumeLayout(false);
            this.grpbxMisc.PerformLayout();
            this.grpbxPartsAndLabor.ResumeLayout(false);
            this.grpbxPartsAndLabor.PerformLayout();
            this.grpbxSummary.ResumeLayout(false);
            this.grpbxSummary.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxOilAndLube;
        private System.Windows.Forms.GroupBox grpbxFlushes;
        private System.Windows.Forms.GroupBox grpbxMisc;
        private System.Windows.Forms.GroupBox grpbxPartsAndLabor;
        private System.Windows.Forms.GroupBox grpbxSummary;
        private System.Windows.Forms.CheckBox chkbxLubeJob;
        private System.Windows.Forms.CheckBox chkbxOilChange;
        private System.Windows.Forms.CheckBox chkbxTransFlush;
        private System.Windows.Forms.CheckBox chkbxRadFlush;
        private System.Windows.Forms.CheckBox chkbxTireRot;
        private System.Windows.Forms.CheckBox chkbxReplaceMuffler;
        private System.Windows.Forms.CheckBox chkbxInspection;
        private System.Windows.Forms.TextBox txtbxLabor;
        private System.Windows.Forms.TextBox txtbxParts;
        private System.Windows.Forms.TextBox txtbxTotal;
        private System.Windows.Forms.TextBox txtbxTax;
        private System.Windows.Forms.TextBox txtbxPartsSummary;
        private System.Windows.Forms.TextBox txtbxServicesAndLabor;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblPartsSummary;
        private System.Windows.Forms.Label lblServicesAndLabor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

