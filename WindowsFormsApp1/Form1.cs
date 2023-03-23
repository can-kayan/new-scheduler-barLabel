using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HallCustom();
        }
        SqlConnection con = new SqlConnection("Connection");//<==!!
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'labelData.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.labelData.Resources);
            // TODO: This line of code loads data into the 'labelData.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.labelData.Appointments);
            HallCustom();

        }
        string Hall = string.Empty;
        private int HallCount()
        {
            int ID;
            SqlDataAdapter sda = new SqlDataAdapter("Select * from dbo.Label", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("Update dbo.Label set ID='" + (i + 1) + "' where UniqueID='" + dt.Rows[i]["UniqueID"] + "'", con);
                try { con.Open(); cmd.ExecuteNonQuery(); }
                catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message); }
                finally { con.Close(); }
            }
            SqlDataAdapter sad = new SqlDataAdapter("Select Top(1) ID from dbo.Label order by ID desc", con);
            DataTable td = new DataTable();
            sad.Fill(td);
            ID = 0;
            if(td.Rows.Count>0)
                ID = Convert.ToInt32(td.Rows[0]["ID"]) + 1;
            return ID;
        }
        public void HallCustom()
        {
            schedulerControl1.Storage.Appointments.Labels.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from dbo.Label", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            IAppointmentLabelStorage labelStorage = schedulerControl1.Storage.Appointments.Labels;
            labelStorage.Clear();
            IAppointmentLabel lbl = labelStorage.CreateNewLabel(0, Hall);
            lbl.SetColor(Color.White);
            labelStorage.Add(lbl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                string[] Coor = dt.Rows[i]["Color"].ToString().Split('=', ',', ']');
                Color a = Color.FromArgb(Convert.ToInt32(Coor[3]), Convert.ToInt32(Coor[5]), Convert.ToInt32(Coor[7]));
                string Name = dt.Rows[i]["Name"].ToString() ;
                object Mennu = dt.Rows[i]["ID"].ToString();
                schedulerStorage1.Appointments.Labels.BeginUpdate();
                IAppointmentLabel label = labelStorage.CreateNewLabel(i + 1, Name);
                label.SetColor(a);
                labelStorage.Add(label);
                schedulerControl1.DataStorage.RefreshData();
                schedulerStorage1.Appointments.Labels.EndUpdate();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BarHallColor.Color.ToArgb().ToString()) || string.IsNullOrEmpty(BarHallName.Text))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Hatta");
            }
            else
            {
                var Color = BarHallColor.Color;
                string C = Color.ToString();
                SqlCommand cmd = new SqlCommand("insert into dbo.Label(ID,Name,Color) values (@ID,@Name,@Color)", con);
                cmd.Parameters.AddWithValue("@ID", HallCount());
                cmd.Parameters.AddWithValue("@Name", BarHallName.Text.ToString());
                cmd.Parameters.AddWithValue("@Color", C);
                try { con.Open(); cmd.ExecuteNonQuery(); }
                catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show("Hata :" + ex); }
                finally { con.Close(); BarHallColor.Text=null;BarHallName.Text = null; }
            }
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            WindowsFormsApp1.OutlookAppointmentForm form = new WindowsFormsApp1.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm,this);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }
    }
}
