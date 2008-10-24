/*
    WoW Combatlog Splitter
    Copyright (C) 2008 Frank Gehann (Takoura EU-Perenolde)
	
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace WoW_Combatlog_Splitter
{
    partial class WoWCombatlogSplitter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WoWCombatlogSplitter));
            this.btn_combatlog = new System.Windows.Forms.Button();
            this.lbl_combatlog = new System.Windows.Forms.Label();
            this.dlg_combatlog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.prg_parse = new System.Windows.Forms.ProgressBar();
            this.btn_parse = new System.Windows.Forms.Button();
            this.btn_abort = new System.Windows.Forms.Button();
            this.lbl_link = new System.Windows.Forms.LinkLabel();
            this.edt_dateformat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_splittime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_combatlog
            // 
            this.btn_combatlog.Location = new System.Drawing.Point(12, 12);
            this.btn_combatlog.Name = "btn_combatlog";
            this.btn_combatlog.Size = new System.Drawing.Size(119, 23);
            this.btn_combatlog.TabIndex = 0;
            this.btn_combatlog.Text = "Load CombatLog";
            this.btn_combatlog.UseVisualStyleBackColor = true;
            this.btn_combatlog.Click += new System.EventHandler(this.btn_combatlog_Click);
            // 
            // lbl_combatlog
            // 
            this.lbl_combatlog.Location = new System.Drawing.Point(137, 12);
            this.lbl_combatlog.Name = "lbl_combatlog";
            this.lbl_combatlog.Size = new System.Drawing.Size(298, 23);
            this.lbl_combatlog.TabIndex = 1;
            this.lbl_combatlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dlg_combatlog
            // 
            this.dlg_combatlog.FileName = "WoWCombatLog.txt";
            this.dlg_combatlog.Filter = "Text Dateien|*.txt|Alle Dateien|*.*";
            this.dlg_combatlog.FileOk += new System.ComponentModel.CancelEventHandler(this.dlg_combatlog_FileOk);
            // 
            // lbl_filename
            // 
            this.lbl_filename.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_filename.Location = new System.Drawing.Point(143, -93);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(252, 23);
            this.lbl_filename.TabIndex = 2;
            this.lbl_filename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prg_parse
            // 
            this.prg_parse.Location = new System.Drawing.Point(12, 72);
            this.prg_parse.Name = "prg_parse";
            this.prg_parse.Size = new System.Drawing.Size(423, 23);
            this.prg_parse.Step = 1;
            this.prg_parse.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prg_parse.TabIndex = 3;
            this.prg_parse.Visible = false;
            // 
            // btn_parse
            // 
            this.btn_parse.Enabled = false;
            this.btn_parse.Location = new System.Drawing.Point(12, 42);
            this.btn_parse.Name = "btn_parse";
            this.btn_parse.Size = new System.Drawing.Size(119, 23);
            this.btn_parse.TabIndex = 4;
            this.btn_parse.Text = "Parse";
            this.btn_parse.UseVisualStyleBackColor = true;
            this.btn_parse.Visible = false;
            this.btn_parse.Click += new System.EventHandler(this.btn_parse_Click);
            // 
            // btn_abort
            // 
            this.btn_abort.Location = new System.Drawing.Point(13, 43);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(118, 23);
            this.btn_abort.TabIndex = 5;
            this.btn_abort.Text = "Cancel";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Visible = false;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // lbl_link
            // 
            this.lbl_link.AutoSize = true;
            this.lbl_link.Location = new System.Drawing.Point(143, 98);
            this.lbl_link.Name = "lbl_link";
            this.lbl_link.Size = new System.Drawing.Size(161, 13);
            this.lbl_link.TabIndex = 7;
            this.lbl_link.TabStop = true;
            this.lbl_link.Text = "http://wowclsp.googlecode.com";
            this.lbl_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_link_LinkClicked);
            // 
            // edt_dateformat
            // 
            this.edt_dateformat.Location = new System.Drawing.Point(183, 46);
            this.edt_dateformat.Name = "edt_dateformat";
            this.edt_dateformat.Size = new System.Drawing.Size(113, 20);
            this.edt_dateformat.TabIndex = 8;
            this.edt_dateformat.Text = "yyyy.MM.dd_HHss";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Split time (minutes):";
            // 
            // edt_splittime
            // 
            this.edt_splittime.Location = new System.Drawing.Point(405, 45);
            this.edt_splittime.MaxLength = 5;
            this.edt_splittime.Name = "edt_splittime";
            this.edt_splittime.Size = new System.Drawing.Size(30, 20);
            this.edt_splittime.TabIndex = 11;
            this.edt_splittime.Text = "120";
            // 
            // WoWCombatlogSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 116);
            this.Controls.Add(this.edt_splittime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edt_dateformat);
            this.Controls.Add(this.lbl_link);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.btn_parse);
            this.Controls.Add(this.prg_parse);
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.lbl_combatlog);
            this.Controls.Add(this.btn_combatlog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WoWCombatlogSplitter";
            this.Text = "WoW Combatlog Splitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_combatlog;
        private System.Windows.Forms.Label lbl_combatlog;
        private System.Windows.Forms.OpenFileDialog dlg_combatlog;
        private System.Windows.Forms.Label lbl_filename;
        private System.Windows.Forms.ProgressBar prg_parse;
        private System.Windows.Forms.Button btn_parse;
        private System.Windows.Forms.Button btn_abort;
        private System.Windows.Forms.LinkLabel lbl_link;
        private System.Windows.Forms.TextBox edt_dateformat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edt_splittime;
    }
}

