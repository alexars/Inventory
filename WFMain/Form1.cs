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
            var persons = ui.Persons.GetPersonsWithDepartments();
            var models = ui.Models.GetAll();
            var types = ui.EqTypes.GetAll();
            var units = ui.Units.GetUnitsWithModelsMakers();


            //Assigne datasources
            dgvPersons.DataSource = persons.ToBindingList();
            dgvMakers.DataSource = makers.ToBindingList();
            dgvDepartments.DataSource = departments.ToBindingList();
            dgvModels.DataSource = models.ToBindingList();
            dgvEqTypes.DataSource = types.ToBindingList();
            dgvUnit.DataSource = units.ToBindingList();

            cmbbxDepartments.DataSource = departments.ToBindingList();
            cmbbxMakers.DataSource = makers.ToBindingList();
            cmbbxEqTypeName.DataSource = types.ToBindingList();

            //  Init Departments ComboBox
            cmbbxDepartments.DisplayMember = "Name";
            cmbbxDepartments.ValueMember = "ID";
            //Init Equipment Types 
            cmbbxEqTypeName.DisplayMember = "Name";
            cmbbxEqTypeName.ValueMember = "ID";

            //Init Makers Combobox
            cmbbxMakers.DisplayMember = "Name";
            cmbbxMakers.ValueMember = "ID";

            InitdvgTypes();
          //  InitdgvPersons();
            InitdgvDepartments();
            InitdgvModels();

        }
        #region Initialize DataGridViewes

        private void InitdgvModels()
        {
            //this.dgvModels.Columns[2].
            this.dgvModels.Columns[3].Visible = false;
        }

        //TODO: Check later
        private void InitdgvPersons()
        {
            /// Keep in safe
            this.dgvPersons.Columns[2].Visible = true;
            this.dgvPersons.Columns[2].Name = "Inventory.Core.Domain.Department.Name";
            this.dgvPersons.Columns[2].ValueType = typeof(Department);

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
        #endregion
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
            dgvPersons.Refresh();
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            ui.Models.Create(new Model { ID = Guid.NewGuid(), Name = txtbxNewModelName.Text.Trim(), Makers = ui.Makers.Get(new Guid((cmbbxMakers.SelectedValue).ToString())), Eqtypes = ui.EqTypes.Get(new Guid((cmbbxEqTypeName.SelectedValue.ToString()))) });
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

