using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
	public partial class FrmEvaluation : Form
	{
		private Student student;

		public FrmEvaluation(Models.Student selectedStudent)
		{
			InitializeComponent();
			student = selectedStudent;
		}

		private void FrmEvaluation_Load(object sender, EventArgs e)
		{
			Text = student.FirstName + " " + student.LastName;
			List<Activity> activities = ActivityRepository.GetActivities();
			comboBox1.DataSource = activities;
		}

		private void comboBox1_SelectedIndexchange(object sender, EventArgs e)
		{
			Activity currentActivity = comboBox1.SelectedItem as Activity;
			txtDescription.Text = currentActivity.Description;
			txtGrade.Text = currentActivity.MinPointsForGrade + "/" + currentActivity.MaxPoints;
			txtSignature.Text = currentActivity.MinPointsForSignature + "/" + currentActivity.MaxPoints;
			numericUpDown1.Minimum = 0;
			numericUpDown1.Maximum = currentActivity.MaxPoints;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
