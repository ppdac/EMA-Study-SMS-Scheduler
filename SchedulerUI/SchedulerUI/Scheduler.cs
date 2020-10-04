using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerUI
{
    public partial class Scheduler : Form
    {
        public Scheduler()
        {
            InitializeComponent();
        }

        private void participantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.participantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._SchedulerUI_Data_SMSDbContextDataSet);

        }

        private void Scheduler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_SchedulerUI_Data_SMSDbContextDataSet.Schedules' table. You can move, or remove it, as needed.
            this.schedulesTableAdapter.Fill(this._SchedulerUI_Data_SMSDbContextDataSet.Schedules);
            // TODO: This line of code loads data into the '_SchedulerUI_Data_SMSDbContextDataSet.Experiments' table. You can move, or remove it, as needed.
            this.experimentsTableAdapter.Fill(this._SchedulerUI_Data_SMSDbContextDataSet.Experiments);
            // TODO: This line of code loads data into the '_SchedulerUI_Data_SMSDbContextDataSet.Experiments' table. You can move, or remove it, as needed.
            this.experimentsTableAdapter.Fill(this._SchedulerUI_Data_SMSDbContextDataSet.Experiments);
            // TODO: This line of code loads data into the '_SchedulerUI_Data_SMSDbContextDataSet.Participants' table. You can move, or remove it, as needed.
            this.participantsTableAdapter.Fill(this._SchedulerUI_Data_SMSDbContextDataSet.Participants);

        }
    }
}
