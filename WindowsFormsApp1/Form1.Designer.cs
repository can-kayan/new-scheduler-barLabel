namespace WindowsFormsApp1
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
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.BarHallName = new DevExpress.XtraEditors.TextEdit();
            this.BarHallColor = new DevExpress.XtraEditors.ColorEdit();
            this.labelData = new WindowsFormsApp1.LabelData();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new WindowsFormsApp1.LabelDataTableAdapters.AppointmentsTableAdapter();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesTableAdapter = new WindowsFormsApp1.LabelDataTableAdapters.ResourcesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarHallName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarHallColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            this.schedulerControl1.DataStorage = this.schedulerStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(852, 321);
            this.schedulerControl1.Start = new System.DateTime(2023, 3, 20, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl1_EditAppointmentFormShowing);
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.Appointments.DataSource = this.appointmentsBindingSource;
            this.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID";
            this.schedulerStorage1.Appointments.Mappings.Start = "StartDate";
            this.schedulerStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerStorage1.Appointments.Mappings.TimeZoneId = "TimeZoneId";
            this.schedulerStorage1.Appointments.Mappings.Type = "Type";
            this.schedulerStorage1.Resources.DataSource = this.resourcesBindingSource;
            this.schedulerStorage1.Resources.Mappings.Caption = "ResourceName";
            this.schedulerStorage1.Resources.Mappings.Color = "Color";
            this.schedulerStorage1.Resources.Mappings.Id = "ResourceID";
            this.schedulerStorage1.Resources.Mappings.Image = "Image";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(274, 370);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(274, 418);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Color";
            // 
            // SaveButton
            // 
            this.SaveButton.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveButton.Appearance.Options.UseFont = true;
            this.SaveButton.Location = new System.Drawing.Point(366, 455);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(145, 38);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BarHallName
            // 
            this.BarHallName.Location = new System.Drawing.Point(384, 369);
            this.BarHallName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarHallName.Name = "BarHallName";
            this.BarHallName.Size = new System.Drawing.Size(213, 20);
            this.BarHallName.TabIndex = 4;
            // 
            // BarHallColor
            // 
            this.BarHallColor.EditValue = System.Drawing.Color.Empty;
            this.BarHallColor.Location = new System.Drawing.Point(384, 412);
            this.BarHallColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarHallColor.Name = "BarHallColor";
            this.BarHallColor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BarHallColor.Properties.Appearance.Options.UseFont = true;
            this.BarHallColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BarHallColor.Size = new System.Drawing.Size(213, 22);
            this.BarHallColor.TabIndex = 5;
            // 
            // labelData
            // 
            this.labelData.DataSetName = "LabelData";
            this.labelData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.labelData;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.labelData;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 574);
            this.Controls.Add(this.BarHallColor);
            this.Controls.Add(this.BarHallName);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.schedulerControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarHallName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarHallColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.TextEdit BarHallName;
        private DevExpress.XtraEditors.ColorEdit BarHallColor;
        private LabelData labelData;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private LabelDataTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private LabelDataTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
    }
}

