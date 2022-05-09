using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;

namespace DMS.UI.Dormitories
{
    public partial class DashbordForm : XtraForm
    {
        public DashbordForm()
        {
            InitializeComponent();
            schedulerControl1.ActiveViewType = SchedulerViewType.Month;
            schedulerControl1.Views.DayView.Enabled = false;
            
        }

        private void schedulerControl1_Click(object sender, EventArgs e)
        {

        }


    }
}
