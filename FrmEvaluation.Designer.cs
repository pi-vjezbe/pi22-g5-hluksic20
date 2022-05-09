namespace Evaluation_Manager
{
	partial class FrmEvaluation
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.txtTeacher = new System.Windows.Forms.Label();
			this.txtEvaluationDate = new System.Windows.Forms.Label();
			this.numPoints = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(20, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Aktivnost:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(320, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Uvjet za potpis:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(591, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Uvjet za ocjenu:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(323, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(150, 20);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(594, 38);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(150, 20);
			this.textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(23, 110);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(721, 191);
			this.textBox3.TabIndex = 5;
			// 
			// txtTeacher
			// 
			this.txtTeacher.AutoSize = true;
			this.txtTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.txtTeacher.Location = new System.Drawing.Point(342, 321);
			this.txtTeacher.Name = "txtTeacher";
			this.txtTeacher.Size = new System.Drawing.Size(73, 17);
			this.txtTeacher.TabIndex = 6;
			this.txtTeacher.Text = "Ocjenjivač";
			this.txtTeacher.Click += new System.EventHandler(this.label4_Click);
			// 
			// txtEvaluationDate
			// 
			this.txtEvaluationDate.AutoSize = true;
			this.txtEvaluationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.txtEvaluationDate.Location = new System.Drawing.Point(516, 321);
			this.txtEvaluationDate.Name = "txtEvaluationDate";
			this.txtEvaluationDate.Size = new System.Drawing.Size(116, 17);
			this.txtEvaluationDate.TabIndex = 7;
			this.txtEvaluationDate.Text = "Datum evaluacije";
			this.txtEvaluationDate.Click += new System.EventHandler(this.label4_Click_1);
			// 
			// numPoints
			// 
			this.numPoints.AutoSize = true;
			this.numPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.numPoints.Location = new System.Drawing.Point(671, 321);
			this.numPoints.Name = "numPoints";
			this.numPoints.Size = new System.Drawing.Size(55, 17);
			this.numPoints.TabIndex = 8;
			this.numPoints.Text = "Bodovi:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(674, 341);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(70, 20);
			this.numericUpDown1.TabIndex = 9;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(345, 341);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(128, 20);
			this.textBox4.TabIndex = 10;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(519, 341);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(128, 20);
			this.textBox5.TabIndex = 11;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(541, 385);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(88, 38);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "Spremi";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(656, 385);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(88, 38);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Odustani";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.button2_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(23, 38);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(226, 21);
			this.comboBox1.TabIndex = 14;
			// 
			// FrmEvaluation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 450);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.numPoints);
			this.Controls.Add(this.txtEvaluationDate);
			this.Controls.Add(this.txtTeacher);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmEvaluation";
			this.Text = "FrmEvaluation";
			this.Load += new System.EventHandler(this.FrmEvaluation_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label txtTeacher;
		private System.Windows.Forms.Label txtEvaluationDate;
		private System.Windows.Forms.Label numPoints;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}