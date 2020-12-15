using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace IRF_Project.UserControls
{
    public partial class jatekosokUC : UserControl
    {
        ArsenalEntities1 context = new ArsenalEntities1();
        public jatekosokUC()
        {
            InitializeComponent();
            context.Jatékosok.Load();
            jatékosokBindingSource.DataSource = context.Jatékosok.Local;
        }

        private void jatékosokBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jatékosokBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.arsenalDataSet1);

        }

        private void felvitelButton_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
