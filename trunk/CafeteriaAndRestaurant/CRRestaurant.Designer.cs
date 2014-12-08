﻿namespace CafeteriaAndRestaurant
{
    partial class CRRestaurant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRealPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeleted = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colOriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductNamed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUnit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gvProductsToBills = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductsToBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ProductId";
            this.colID.HeaderText = "ProductId";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colRealPrice
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colRealPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.colRealPrice.HeaderText = "Price";
            this.colRealPrice.Name = "colRealPrice";
            // 
            // colAmounts
            // 
            this.colAmounts.DataPropertyName = "Amounts";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colAmounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAmounts.HeaderText = "Amount";
            this.colAmounts.Name = "colAmounts";
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Sum";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colDeleted
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDeleted.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDeleted.HeaderText = "Delete";
            this.colDeleted.Name = "colDeleted";
            this.colDeleted.Width = 71;
            // 
            // colOriginalPrice
            // 
            this.colOriginalPrice.DataPropertyName = "OriginalPrice";
            this.colOriginalPrice.HeaderText = "Price";
            this.colOriginalPrice.Name = "colOriginalPrice";
            this.colOriginalPrice.ReadOnly = true;
            // 
            // colProductNamed
            // 
            this.colProductNamed.DataPropertyName = "ProductName";
            this.colProductNamed.HeaderText = "Product Name";
            this.colProductNamed.Name = "colProductNamed";
            this.colProductNamed.ReadOnly = true;
            this.colProductNamed.Width = 189;
            // 
            // colProductId
            // 
            this.colProductId.DataPropertyName = "ProductId";
            this.colProductId.HeaderText = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Visible = false;
            // 
            // gvProducts
            // 
            this.gvProducts.AllowUserToAddRows = false;
            this.gvProducts.AllowUserToResizeColumns = false;
            this.gvProducts.AllowUserToResizeRows = false;
            this.gvProducts.BackgroundColor = System.Drawing.Color.Tan;
            this.gvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductId,
            this.colProductNamed,
            this.colOriginalPrice});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvProducts.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvProducts.Location = new System.Drawing.Point(6, 68);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.gvProducts.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProducts.Size = new System.Drawing.Size(292, 368);
            this.gvProducts.TabIndex = 2;
            this.gvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProducts_CellClick);
            this.gvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProducts_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvProducts);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboCategories);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 466);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(14, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Categories:";
            // 
            // cboCategories
            // 
            this.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategories.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategories.ForeColor = System.Drawing.Color.Gray;
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(107, 26);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(159, 27);
            this.cboCategories.TabIndex = 0;
            this.cboCategories.SelectedIndexChanged += new System.EventHandler(this.cboCategories_SelectedIndexChanged);
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(66, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Unit :";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lbDescription.Location = new System.Drawing.Point(118, 107);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(125, 19);
            this.lbDescription.TabIndex = 20;
            this.lbDescription.Text = ".............................";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.DimGray;
            this.lbName.Location = new System.Drawing.Point(118, 19);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(125, 19);
            this.lbName.TabIndex = 17;
            this.lbName.Text = ".............................";
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit.ForeColor = System.Drawing.Color.DimGray;
            this.lbUnit.Location = new System.Drawing.Point(118, 78);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(125, 19);
            this.lbUnit.TabIndex = 19;
            this.lbUnit.Text = ".............................";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(54, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Description :";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lbPrice.Location = new System.Drawing.Point(118, 48);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(125, 19);
            this.lbPrice.TabIndex = 18;
            this.lbPrice.Text = ".............................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(64, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(506, 434);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(13, 19);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = ".";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbDescription);
            this.groupBox3.Controls.Add(this.lbName);
            this.groupBox3.Controls.Add(this.lbUnit);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbPrice);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbTotal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.gvProductsToBills);
            this.groupBox3.Location = new System.Drawing.Point(318, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 461);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(550, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "usd";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(455, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total :";
            // 
            // gvProductsToBills
            // 
            this.gvProductsToBills.AllowUserToAddRows = false;
            this.gvProductsToBills.AllowUserToResizeColumns = false;
            this.gvProductsToBills.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkGray;
            this.gvProductsToBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gvProductsToBills.BackgroundColor = System.Drawing.Color.Tan;
            this.gvProductsToBills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvProductsToBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gvProductsToBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductsToBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colProductName,
            this.colRealPrice,
            this.colAmounts,
            this.colTotal,
            this.colDeleted});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvProductsToBills.DefaultCellStyle = dataGridViewCellStyle11;
            this.gvProductsToBills.Location = new System.Drawing.Point(6, 138);
            this.gvProductsToBills.Name = "gvProductsToBills";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvProductsToBills.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gvProductsToBills.RowHeadersVisible = false;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.gvProductsToBills.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gvProductsToBills.Size = new System.Drawing.Size(576, 293);
            this.gvProductsToBills.TabIndex = 0;
            this.gvProductsToBills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProductsToBills_CellClick);
            this.gvProductsToBills.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProductsToBills_CellValueChanged);
            this.gvProductsToBills.CurrentCellDirtyStateChanged += new System.EventHandler(this.gvProductsToBills_CurrentCellDirtyStateChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CafeteriaAndRestaurant.Properties.Resources.preview1;
            this.pictureBox2.Location = new System.Drawing.Point(755, 481);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 30);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CafeteriaAndRestaurant.Properties.Resources.save3;
            this.pictureBox1.Location = new System.Drawing.Point(831, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 30);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CRRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(913, 514);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "CRRestaurant";
            this.Load += new System.EventHandler(this.CRRestaurant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductsToBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRealPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewLinkColumn colDeleted;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductNamed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridView gvProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gvProductsToBills;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;



    }
}