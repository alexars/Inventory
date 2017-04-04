using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Core.Domain;
using Inventory.Core.Implement;
using System.Data.Entity;
namespace WFMain
{
    public partial class Form1 : Form
    {
        UnitOfWork ui = new UnitOfWork();
        Maker maker;
        public Form1()
        {
            InitializeComponent();

            var makers = ui.Makers.GetAll();
            dgvMakers.DataSource = makers.ToBindingList();
        }

        private void btnMakerName_Click(object sender, EventArgs e)
        {
            maker = new Maker() { ID = Guid.NewGuid(), Name = tbMakerName.Text.Trim() };
            ui.Makers.Create(maker);

            ui.SaveAll();
            
            tbMakerName.Clear();

        }

        private void btnChangeMakerName_Click(object sender, EventArgs e)
        {
            Maker maker= ui.Makers.Get(new Guid((dgvMakers.CurrentCell.Value).ToString()));
            maker.Name = txtbxNewMakerName.Text.Trim();
            txtbxNewMakerName.Clear();
            ui.Makers.Update(maker);
            ui.SaveAll();
        }
    }
}
