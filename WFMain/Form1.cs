using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Inventory.Core.Domain;
using Inventory.Core.Implement;
using System.Data.Entity;

namespace WFMain
{
    public partial class Form1 : Form
    {
        UnitOfWork ui = new UnitOfWork();
        ObservableCollection<object> persons = null;
        public Form1()
        {
            InitializeComponent();

            var makers = ui.Makers.GetAll();
            var departments = ui.Departments.GetAll();
            //  var persons = ui.Persons.GetAll();

            persons = ui.Persons.GetPersonsWithDepartments();
            var models = ui.Models.GetAll();
            var types = ui.EqTypes.GetAll();
            var units = ui.Units.GetUnitsWithModelsMakers();
            var modelsForUnits = ui.Models.GetModelsWithMakers();


            //Assigne datasources
            dgvPersons.DataSource = persons.ToBindingList();
            dgvMakers.DataSource = makers.ToBindingList();
            dgvDepartments.DataSource = departments.ToBindingList();
            dgvModels.DataSource = models.ToBindingList();
            dgvEqTypes.DataSource = types.ToBindingList();
            dgvUnit.DataSource = units.ToBindingList();




            #region Combobox initialization block
            cmbbxDepartments.DataSource = departments.ToBindingList();
            cmbbxMakers.DataSource = makers.ToBindingList();
            cmbbxEqTypeName.DataSource = types.ToBindingList();

            //  Init Departments ComboBox
            cmbbxDepartments.DisplayMember = "Name";
            cmbbxDepartments.ValueMember = "DepartmentID";
            //Init Equipment Types 
            cmbbxEqTypeName.DisplayMember = "Name";
            cmbbxEqTypeName.ValueMember = "EqTypeID";

            //unit
            //cmbbxUnitMaker.DataSource = modelsForUnits.ToList();
            //cmbbxUnitMaker.DisplayMember = "Maker";
            //cmbbxUnitMaker.ValueMember = "UnitID";

            //cmbbxUnitModel.DataSource = modelsForUnits.ToList();
            //cmbbxUnitModel.DisplayMember = "Model";
            //cmbbxUnitModel.ValueMember = "ModelID";
            //Init Makers Combobox
            cmbbxMakers.DisplayMember = "Name";
            cmbbxMakers.ValueMember = "MakerID";
            #endregion


            InitdvgTypes();
            InitdgvPersons();
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
            dgvPersons.DataSource = ui.Persons.GetPersonsWithDepartments();
            dgvPersons.Refresh();
         

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

            ui.Makers.Create(new Maker() { MakerID = Guid.NewGuid(), Name = tbMakerName.Text.Trim() });
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

            ui.Departments.Create(new Department() { DepartmentID = Guid.NewGuid(), Name = txtbxNewDepartment.Text.Trim() });
            txtbxNewDepartment.Clear();
            ui.SaveAll();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            ui.Persons.Create(new Person { PersonID = Guid.NewGuid(), Name = txtbxNewPerson.Text.Trim(), Department = ui.Departments.Get(new Guid((cmbbxDepartments.SelectedValue).ToString())) });
            txtbxNewPerson.Clear();
            ui.SaveAll();
            this.InitdgvPersons();
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            ui.Models.Create(new Model { ModelID = Guid.NewGuid(), Name = txtbxNewModelName.Text.Trim(), Makers = ui.Makers.Get(new Guid((cmbbxMakers.SelectedValue).ToString())), Eqtypes = ui.EqTypes.Get(new Guid((cmbbxEqTypeName.SelectedValue.ToString()))) });
            txtbxNewMakerName.Clear();
            ui.SaveAll();
            //dgvpersons.datasource = ui.persons.getpersonswithdepartments();
            //dgvpersons.refresh();
        }



        private void btnAddNewType_Click(object sender, EventArgs e)
        {
            ui.EqTypes.Create(new EqType { EqTypeID = Guid.NewGuid(), Name = txtbxTypeName.Text.Trim() });
            txtbxTypeName.Clear();
            ui.SaveAll();
            //this.persons = ui.Persons.GetPersonsWithDepartments();
            //this.dgvPersons.DataSource=persons.ToBindingList();
            //this.dgvPersons.Refresh();
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

