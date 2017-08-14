namespace WFMain
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvModels = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.txtbxNewModelName = new System.Windows.Forms.TextBox();
            this.cmbbxMakers = new System.Windows.Forms.ComboBox();
            this.cmbbxEqTypeName = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMakers = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tbMakerName = new System.Windows.Forms.TextBox();
            this.btnMakerName = new System.Windows.Forms.Button();
            this.btnChangeMakerName = new System.Windows.Forms.Button();
            this.txtbxNewMakerName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewDepartment = new System.Windows.Forms.Button();
            this.txtbxNewDepartment = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.txtbxNewPerson = new System.Windows.Forms.TextBox();
            this.cmbbxDepartments = new System.Windows.Forms.ComboBox();
            this.unitOfWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.txtbxTypeName = new System.Windows.Forms.TextBox();
            this.btnAddNewType = new System.Windows.Forms.Button();
            this.dgvEqTypes = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUnit = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbbxUnitMaker = new System.Windows.Forms.ComboBox();
            this.cmbbxUnitModel = new System.Windows.Forms.ComboBox();
            this.unitOfWorkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMakers)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEqTypes)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel4);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(847, 479);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Models";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.Controls.Add(this.dgvModels, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.38889F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.61111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(839, 471);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // dgvModels
            // 
            this.dgvModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModels.Location = new System.Drawing.Point(4, 99);
            this.dgvModels.Margin = new System.Windows.Forms.Padding(4);
            this.dgvModels.Name = "dgvModels";
            this.dgvModels.Size = new System.Drawing.Size(831, 342);
            this.dgvModels.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.32076F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.67924F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 433F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel5.Controls.Add(this.btnAddModel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtbxNewModelName, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cmbbxMakers, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cmbbxEqTypeName, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(831, 87);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // btnAddModel
            // 
            this.btnAddModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddModel.Location = new System.Drawing.Point(4, 47);
            this.btnAddModel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(169, 36);
            this.btnAddModel.TabIndex = 0;
            this.btnAddModel.Text = "Add new Model";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // txtbxNewModelName
            // 
            this.txtbxNewModelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxNewModelName.Location = new System.Drawing.Point(4, 4);
            this.txtbxNewModelName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNewModelName.Name = "txtbxNewModelName";
            this.txtbxNewModelName.Size = new System.Drawing.Size(169, 22);
            this.txtbxNewModelName.TabIndex = 1;
            // 
            // cmbbxMakers
            // 
            this.cmbbxMakers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbbxMakers.FormattingEnabled = true;
            this.cmbbxMakers.Location = new System.Drawing.Point(181, 4);
            this.cmbbxMakers.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxMakers.Name = "cmbbxMakers";
            this.cmbbxMakers.Size = new System.Drawing.Size(160, 24);
            this.cmbbxMakers.TabIndex = 2;
            // 
            // cmbbxEqTypeName
            // 
            this.cmbbxEqTypeName.FormattingEnabled = true;
            this.cmbbxEqTypeName.Location = new System.Drawing.Point(181, 47);
            this.cmbbxEqTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxEqTypeName.Name = "cmbbxEqTypeName";
            this.cmbbxEqTypeName.Size = new System.Drawing.Size(160, 24);
            this.cmbbxEqTypeName.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(847, 479);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Makers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Controls.Add(this.dgvMakers, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.47244F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.52756F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(839, 471);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // dgvMakers
            // 
            this.dgvMakers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMakers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMakers.Location = new System.Drawing.Point(4, 100);
            this.dgvMakers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMakers.Name = "dgvMakers";
            this.dgvMakers.Size = new System.Drawing.Size(831, 367);
            this.dgvMakers.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tbMakerName, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnMakerName, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnChangeMakerName, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtbxNewMakerName, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(831, 88);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // tbMakerName
            // 
            this.tbMakerName.Location = new System.Drawing.Point(4, 4);
            this.tbMakerName.Margin = new System.Windows.Forms.Padding(4);
            this.tbMakerName.Name = "tbMakerName";
            this.tbMakerName.Size = new System.Drawing.Size(132, 22);
            this.tbMakerName.TabIndex = 3;
            // 
            // btnMakerName
            // 
            this.btnMakerName.Location = new System.Drawing.Point(4, 48);
            this.btnMakerName.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakerName.Name = "btnMakerName";
            this.btnMakerName.Size = new System.Drawing.Size(156, 28);
            this.btnMakerName.TabIndex = 4;
            this.btnMakerName.Text = "Add new maker";
            this.btnMakerName.Click += new System.EventHandler(this.btnMakerName_Click);
            // 
            // btnChangeMakerName
            // 
            this.btnChangeMakerName.Location = new System.Drawing.Point(419, 48);
            this.btnChangeMakerName.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeMakerName.Name = "btnChangeMakerName";
            this.btnChangeMakerName.Size = new System.Drawing.Size(160, 36);
            this.btnChangeMakerName.TabIndex = 5;
            this.btnChangeMakerName.Text = "Change Maker Name";
            this.btnChangeMakerName.UseVisualStyleBackColor = true;
            this.btnChangeMakerName.Click += new System.EventHandler(this.btnChangeMakerName_Click);
            // 
            // txtbxNewMakerName
            // 
            this.txtbxNewMakerName.Location = new System.Drawing.Point(419, 4);
            this.txtbxNewMakerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNewMakerName.Name = "txtbxNewMakerName";
            this.txtbxNewMakerName.Size = new System.Drawing.Size(132, 22);
            this.txtbxNewMakerName.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(847, 479);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Departments";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.dgvDepartments, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.54856F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.45145F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(839, 471);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartments.Location = new System.Drawing.Point(4, 58);
            this.dgvDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.Size = new System.Drawing.Size(831, 409);
            this.dgvDepartments.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.3494F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.6506F));
            this.tableLayoutPanel7.Controls.Add(this.btnNewDepartment, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtbxNewDepartment, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(553, 46);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // btnNewDepartment
            // 
            this.btnNewDepartment.Location = new System.Drawing.Point(4, 4);
            this.btnNewDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewDepartment.Name = "btnNewDepartment";
            this.btnNewDepartment.Size = new System.Drawing.Size(197, 38);
            this.btnNewDepartment.TabIndex = 2;
            this.btnNewDepartment.Text = "Add new Department";
            this.btnNewDepartment.UseVisualStyleBackColor = true;
            this.btnNewDepartment.Click += new System.EventHandler(this.btnNewDepartment_Click);
            // 
            // txtbxNewDepartment
            // 
            this.txtbxNewDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtbxNewDepartment.Location = new System.Drawing.Point(210, 4);
            this.txtbxNewDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNewDepartment.Name = "txtbxNewDepartment";
            this.txtbxNewDepartment.Size = new System.Drawing.Size(337, 22);
            this.txtbxNewDepartment.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(847, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Persons";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.dgvPersons, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07349F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.92651F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvPersons
            // 
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersons.Location = new System.Drawing.Point(4, 60);
            this.dgvPersons.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.Size = new System.Drawing.Size(831, 407);
            this.dgvPersons.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.62415F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.37585F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 346F));
            this.tableLayoutPanel8.Controls.Add(this.btnAddNewPerson, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtbxNewPerson, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.cmbbxDepartments, 2, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(828, 48);
            this.tableLayoutPanel8.TabIndex = 1;
            this.tableLayoutPanel8.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel8_Paint);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Location = new System.Drawing.Point(4, 4);
            this.btnAddNewPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(158, 39);
            this.btnAddNewPerson.TabIndex = 0;
            this.btnAddNewPerson.Text = "Add New Person";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // txtbxNewPerson
            // 
            this.txtbxNewPerson.Location = new System.Drawing.Point(170, 4);
            this.txtbxNewPerson.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNewPerson.Name = "txtbxNewPerson";
            this.txtbxNewPerson.Size = new System.Drawing.Size(307, 22);
            this.txtbxNewPerson.TabIndex = 1;
            // 
            // cmbbxDepartments
            // 
            this.cmbbxDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbbxDepartments.FormattingEnabled = true;
            this.cmbbxDepartments.Location = new System.Drawing.Point(485, 4);
            this.cmbbxDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxDepartments.Name = "cmbbxDepartments";
            this.cmbbxDepartments.Size = new System.Drawing.Size(339, 24);
            this.cmbbxDepartments.TabIndex = 2;
            // 
            // unitOfWorkBindingSource
            // 
            this.unitOfWorkBindingSource.DataSource = typeof(Inventory.Core.Implement.UnitOfWork);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 508);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel9);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(847, 479);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Eq type";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.dgvEqTypes, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.94751F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.05249F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(839, 471);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.15459F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.84541F));
            this.tableLayoutPanel10.Controls.Add(this.txtbxTypeName, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.btnAddNewType, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(831, 85);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // txtbxTypeName
            // 
            this.txtbxTypeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxTypeName.Location = new System.Drawing.Point(4, 4);
            this.txtbxTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxTypeName.Name = "txtbxTypeName";
            this.txtbxTypeName.Size = new System.Drawing.Size(192, 22);
            this.txtbxTypeName.TabIndex = 0;
            // 
            // btnAddNewType
            // 
            this.btnAddNewType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewType.Location = new System.Drawing.Point(4, 46);
            this.btnAddNewType.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewType.Name = "btnAddNewType";
            this.btnAddNewType.Size = new System.Drawing.Size(192, 35);
            this.btnAddNewType.TabIndex = 1;
            this.btnAddNewType.Text = "Add new equipment type";
            this.btnAddNewType.UseVisualStyleBackColor = true;
            this.btnAddNewType.Click += new System.EventHandler(this.btnAddNewType_Click);
            // 
            // dgvEqTypes
            // 
            this.dgvEqTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEqTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEqTypes.Location = new System.Drawing.Point(4, 97);
            this.dgvEqTypes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEqTypes.Name = "dgvEqTypes";
            this.dgvEqTypes.Size = new System.Drawing.Size(831, 370);
            this.dgvEqTypes.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel11);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(847, 479);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Unit";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.dgvUnit, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.33596F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.66404F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(839, 471);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // dgvUnit
            // 
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnit.Location = new System.Drawing.Point(4, 62);
            this.dgvUnit.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.Size = new System.Drawing.Size(831, 405);
            this.dgvUnit.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 3;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.22293F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.77707F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 417F));
            this.tableLayoutPanel12.Controls.Add(this.cmbbxUnitMaker, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.cmbbxUnitModel, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.7317F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.26829F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(831, 50);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // cmbbxUnitMaker
            // 
            this.cmbbxUnitMaker.FormattingEnabled = true;
            this.cmbbxUnitMaker.Location = new System.Drawing.Point(4, 4);
            this.cmbbxUnitMaker.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxUnitMaker.Name = "cmbbxUnitMaker";
            this.cmbbxUnitMaker.Size = new System.Drawing.Size(160, 24);
            this.cmbbxUnitMaker.TabIndex = 0;
            this.cmbbxUnitMaker.Text = "choose manufacture";
            // 
            // cmbbxUnitModel
            // 
            this.cmbbxUnitModel.FormattingEnabled = true;
            this.cmbbxUnitModel.Location = new System.Drawing.Point(191, 4);
            this.cmbbxUnitModel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxUnitModel.Name = "cmbbxUnitModel";
            this.cmbbxUnitModel.Size = new System.Drawing.Size(160, 24);
            this.cmbbxUnitModel.TabIndex = 0;
            this.cmbbxUnitModel.Text = "choose model";
            // 
            // unitOfWorkBindingSource1
            // 
            this.unitOfWorkBindingSource1.DataSource = typeof(Inventory.Core.Implement.UnitOfWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 526);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMakers)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEqTypes)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dgvModels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvMakers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox tbMakerName;
        private System.Windows.Forms.Button btnMakerName;
        private System.Windows.Forms.Button btnChangeMakerName;
        private System.Windows.Forms.TextBox txtbxNewMakerName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnNewDepartment;
        private System.Windows.Forms.TextBox txtbxNewDepartment;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.TextBox txtbxNewPerson;
        private System.Windows.Forms.ComboBox cmbbxDepartments;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.TextBox txtbxNewModelName;
        private System.Windows.Forms.ComboBox cmbbxMakers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox txtbxTypeName;
        private System.Windows.Forms.Button btnAddNewType;
        private System.Windows.Forms.DataGridView dgvEqTypes;
        private System.Windows.Forms.ComboBox cmbbxEqTypeName;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.DataGridView dgvUnit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.BindingSource unitOfWorkBindingSource;
        private System.Windows.Forms.ComboBox cmbbxUnitMaker;
        private System.Windows.Forms.ComboBox cmbbxUnitModel;
        private System.Windows.Forms.BindingSource unitOfWorkBindingSource1;
    }
}

