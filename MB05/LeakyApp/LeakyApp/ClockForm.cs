using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeakyApp {
    public partial class ClockForm : Form {

        Timer timer;

        public ClockForm() {
            InitializeComponent();
            timer = new Timer {
                Interval = 1000
            };

            timer.Start();
            timer.Tick += this.UpdateTime;
        }

        private void UpdateTime(object sender, EventArgs e) {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }






        
        protected override void OnClosed(EventArgs e) {
            base.OnClosed(e);

            //Uncommnet below lines to stop memory leak

            //timer.Tick -= UpdateTime;
            //timer.Stop();
        }
    }
}
