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

        public Form1()
        {
            InitializeComponent();

            var makers = ui.Makers.GetAll();
            var departments = ui.Departments.GetAll();
            var persons = ui.Persons.GetAll();
            var models = ui.Models.GetAll();
            var types = ui.EqTypes.GetAll();

    

            dgvPersons.DataSource = persons;
            dgvMakers.DataSource = makers.ToBindingList();
            dgvDepartments.DataSource = departments.ToBindingList();
            dgvModels.DataSource = models.ToBindingList();
            dgvEqTypes.DataSource = types.ToBindingList();

            cmbbxDepartments.DataSource = departments.ToBindingList();
            cmbbxMakers.DataSource = makers.ToBindingList();

            //  Init Departments ComboBox
            cmbbxDepartments.DisplayMember = "Name";
            cmbbxDepartments.ValueMember = "ID";

            //Init Makers Combobox
            cmbbxMakers.DisplayMember = "Name";
            cmbbxMakers.ValueMember = "ID";
            InitdvgTypes();
            InitdgvPersons();
            InitdgvDepartments();

        }
        //TODO: Check later
        private void InitdgvPersons()
        {
            this.dgvPersons.Columns[2].Visible = true;
            this.dgvPersons.Columns[2].DataPropertyName = cmbbxDepartments.DisplayMember;
        }
        private void InitdvgTypes()
        {

           this.dgvEqTypes.Columns[0].Visible = false;
            this.dgvEqTypes.Columns[2].Visible = false;
        }
        private void InitdgvDepartments()
        {
            this.dgvDepartments.Columns[2].Visible = false;
            

        }
        private void btnMakerName_Click(object sender, EventArgs e)
        {

            ui.Makers.Create(new Maker() { ID = Guid.NewGuid(), Name = tbMakerName.Text.Trim() });
            ui.SaveAll();
            tbMakerName.Clear();

        }

        private void btnChangeMakerName_Click(object sender, EventArgs e)
        {

            Maker maker = ui.Makers.Get(new Guid((dgvMakers.CurrentCell.Value).ToString()));
            maker.Name = txtbxNewMakerName.Text.Trim();
            txtbxNewMakerName.Clear();
            ui.Makers.Update(maker);
            ui.SaveAll();
        }

        private void btnNewDepartment_Click(object sender, EventArgs e)
        {

            ui.Departments.Create(new Department() { ID = Guid.NewGuid(), Name = txtbxNewDepartment.Text.Trim() });
            txtbxNewDepartment.Clear();
            ui.SaveAll();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            ui.Persons.Create(new Person { ID = Guid.NewGuid(), Name = txtbxNewPerson.Text.Trim(), Departments = ui.Departments.Get(new Guid((cmbbxDepartments.SelectedValue).ToString())) });
            txtbxNewPerson.Clear();
            ui.SaveAll();
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            ui.Models.Create(new Model { ID = Guid.NewGuid(), Name = txtbxNewModelName.Text.Trim(), Makers = ui.Makers.Get(new Guid((cmbbxMakers.SelectedValue).ToString())) });
            txtbxNewMakerName.Clear();
            ui.SaveAll();
        }



        private void btnAddNewType_Click(object sender, EventArgs e)
        {
            ui.EqTypes.Create(new EqType { ID = Guid.NewGuid(), Name = txtbxTypeName.Text.Trim() });
            txtbxTypeName.Clear();
            ui.SaveAll();
        }
    }
}

