using System.Drawing;
using System.Windows.Forms;
using System;

namespace CPU_Scheduling_RoundRobin_Simulator
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessNameTextBox = new System.Windows.Forms.TextBox();
            this.ArrivalTimeTextBox = new System.Windows.Forms.TextBox();
            this.BurstTimeTextBox = new System.Windows.Forms.TextBox();
            this.AddTimeButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.GantButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.QuantumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTurnAroundTime = new System.Windows.Forms.Label();
            this.labelWaitTime = new System.Windows.Forms.Label();
            this.labelGantt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.DataGridView1.Location = new System.Drawing.Point(12, 12);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(563, 259);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Arrival Time";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Burst Time";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // ProcessNameTextBox
            // 
            this.ProcessNameTextBox.Location = new System.Drawing.Point(867, 35);
            this.ProcessNameTextBox.Name = "ProcessNameTextBox";
            this.ProcessNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.ProcessNameTextBox.TabIndex = 1;
            // 
            // ArrivalTimeTextBox
            // 
            this.ArrivalTimeTextBox.Location = new System.Drawing.Point(974, 35);
            this.ArrivalTimeTextBox.Name = "ArrivalTimeTextBox";
            this.ArrivalTimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.ArrivalTimeTextBox.TabIndex = 2;
            // 
            // BurstTimeTextBox
            // 
            this.BurstTimeTextBox.Location = new System.Drawing.Point(1081, 35);
            this.BurstTimeTextBox.Name = "BurstTimeTextBox";
            this.BurstTimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.BurstTimeTextBox.TabIndex = 3;
            // 
            // AddTimeButton
            // 
            this.AddTimeButton.Location = new System.Drawing.Point(1013, 73);
            this.AddTimeButton.Name = "AddTimeButton";
            this.AddTimeButton.Size = new System.Drawing.Size(138, 35);
            this.AddTimeButton.TabIndex = 5;
            this.AddTimeButton.Text = "Add Time";
            this.AddTimeButton.UseVisualStyleBackColor = true;
            this.AddTimeButton.Click += new System.EventHandler(this.AddTimeButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(54, 277);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(110, 32);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // GantButton
            // 
            this.GantButton.Location = new System.Drawing.Point(228, 277);
            this.GantButton.Name = "GantButton";
            this.GantButton.Size = new System.Drawing.Size(119, 32);
            this.GantButton.TabIndex = 7;
            this.GantButton.Text = "Gant Chart";
            this.GantButton.UseVisualStyleBackColor = true;
            this.GantButton.Click += new System.EventHandler(this.GantButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(402, 277);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(132, 32);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // QuantumTextBox
            // 
            this.QuantumTextBox.Location = new System.Drawing.Point(1186, 35);
            this.QuantumTextBox.Name = "QuantumTextBox";
            this.QuantumTextBox.Size = new System.Drawing.Size(100, 22);
            this.QuantumTextBox.TabIndex = 9;
            this.QuantumTextBox.TextChanged += new System.EventHandler(this.QuantumTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(896, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(982, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Arrival Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1093, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Burst Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1205, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantum";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DataGridView2
            // 
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.DataGridView2.Location = new System.Drawing.Point(12, 315);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.RowHeadersWidth = 51;
            this.DataGridView2.RowTemplate.Height = 24;
            this.DataGridView2.Size = new System.Drawing.Size(563, 197);
            this.DataGridView2.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Waiting Time";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Turnaround Time";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // labelTurnAroundTime
            // 
            this.labelTurnAroundTime.AutoSize = true;
            this.labelTurnAroundTime.Location = new System.Drawing.Point(575, 315);
            this.labelTurnAroundTime.Name = "labelTurnAroundTime";
            this.labelTurnAroundTime.Size = new System.Drawing.Size(0, 16);
            this.labelTurnAroundTime.TabIndex = 10;
            // 
            // labelWaitTime
            // 
            this.labelWaitTime.AutoSize = true;
            this.labelWaitTime.Location = new System.Drawing.Point(575, 339);
            this.labelWaitTime.Name = "labelWaitTime";
            this.labelWaitTime.Size = new System.Drawing.Size(0, 16);
            this.labelWaitTime.TabIndex = 10;
            // 
            // labelGantt
            // 
            this.labelGantt.AutoSize = true;
            this.labelGantt.Location = new System.Drawing.Point(12, 518);
            this.labelGantt.Name = "labelGantt";
            this.labelGantt.Size = new System.Drawing.Size(0, 16);
            this.labelGantt.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(89, 518);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 30);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label);
            this.panel2.Location = new System.Drawing.Point(89, 560);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 34);
            this.panel2.TabIndex = 17;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 18);
            this.label.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 640);
            this.Controls.Add(this.DataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuantumTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.GantButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AddTimeButton);
            this.Controls.Add(this.BurstTimeTextBox);
            this.Controls.Add(this.ArrivalTimeTextBox);
            this.Controls.Add(this.ProcessNameTextBox);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.labelWaitTime);
            this.Controls.Add(this.labelGantt);
            this.Controls.Add(this.labelTurnAroundTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.Text = "Round Robin CPU Scheduler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.TextBox ProcessNameTextBox;
        private System.Windows.Forms.TextBox ArrivalTimeTextBox;
        private System.Windows.Forms.TextBox BurstTimeTextBox;
        private System.Windows.Forms.Button AddTimeButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button GantButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox QuantumTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DataGridView2;
        private System.Windows.Forms.Label labelWaitTime;
        private System.Windows.Forms.Label labelTurnAroundTime;
        private System.Windows.Forms.Label labelGantt;
        private FlowLayoutPanel panel1;
        private FlowLayoutPanel panel2;
        private Label label;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

