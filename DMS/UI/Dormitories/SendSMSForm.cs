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
using DMS.IServices;

namespace DMS.UI.Dormitories
{
    public partial class SendSMSForm : XtraForm
    {
        private readonly ISmsService _smsService;
        private Sms _sms;

        public Sms Sms
        {
            get => _sms;
            set => _sms = value;
        }

        public SendSMSForm(ISmsService smsService)
        {
            _smsService = smsService;
            InitializeComponent();
        }

        private void SendSMSForm_Load(object sender, EventArgs e)
        {
            txtReciver1.Text = _sms.ReciverName1;
            txtReciver2.Text = _sms.ReciverName2;
            txtmobile1.Text = _sms.Mobile1.ToString();
            txtMobile2.Text = _sms.Mobile2.ToString();
        }
    }
}
