namespace se307
{
    partial class UpdateThesisForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.universityDataGridView = new System.Windows.Forms.DataGridView();
            this.delBtnUni = new System.Windows.Forms.Button();
            this.changeBtnUni = new System.Windows.Forms.Button();
            this.addBtnUni = new System.Windows.Forms.Button();
            this.uniIdBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.instituteDataGridView = new System.Windows.Forms.DataGridView();
            this.delInstBtn = new System.Windows.Forms.Button();
            this.chgInstBtn = new System.Windows.Forms.Button();
            this.addInstBtn = new System.Windows.Forms.Button();
            this.instIdBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.authorDataGridView = new System.Windows.Forms.DataGridView();
            this.delAuthBtn = new System.Windows.Forms.Button();
            this.changeAuthBtn = new System.Windows.Forms.Button();
            this.addAuthBtn = new System.Windows.Forms.Button();
            this.authTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 719);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.universityDataGridView);
            this.tabPage1.Controls.Add(this.delBtnUni);
            this.tabPage1.Controls.Add(this.changeBtnUni);
            this.tabPage1.Controls.Add(this.addBtnUni);
            this.tabPage1.Controls.Add(this.uniIdBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 690);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Universities";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.Universities_Click);
            // 
            // universityDataGridView
            // 
            this.universityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.universityDataGridView.Location = new System.Drawing.Point(20, 158);
            this.universityDataGridView.Name = "universityDataGridView";
            this.universityDataGridView.RowHeadersWidth = 51;
            this.universityDataGridView.RowTemplate.Height = 24;
            this.universityDataGridView.Size = new System.Drawing.Size(590, 512);
            this.universityDataGridView.TabIndex = 27;
            this.universityDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.universityDataGridView_CellContentClick);
            // 
            // delBtnUni
            // 
            this.delBtnUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delBtnUni.Location = new System.Drawing.Point(459, 60);
            this.delBtnUni.Name = "delBtnUni";
            this.delBtnUni.Size = new System.Drawing.Size(151, 67);
            this.delBtnUni.TabIndex = 26;
            this.delBtnUni.Text = "Delete";
            this.delBtnUni.UseVisualStyleBackColor = true;
            this.delBtnUni.Click += new System.EventHandler(this.delBtnUni_Click);
            // 
            // changeBtnUni
            // 
            this.changeBtnUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changeBtnUni.Location = new System.Drawing.Point(239, 60);
            this.changeBtnUni.Name = "changeBtnUni";
            this.changeBtnUni.Size = new System.Drawing.Size(151, 67);
            this.changeBtnUni.TabIndex = 25;
            this.changeBtnUni.Text = "Change";
            this.changeBtnUni.UseVisualStyleBackColor = true;
            this.changeBtnUni.Click += new System.EventHandler(this.changeBtnUni_Click);
            // 
            // addBtnUni
            // 
            this.addBtnUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBtnUni.Location = new System.Drawing.Point(20, 60);
            this.addBtnUni.Name = "addBtnUni";
            this.addBtnUni.Size = new System.Drawing.Size(151, 67);
            this.addBtnUni.TabIndex = 24;
            this.addBtnUni.Text = "Add";
            this.addBtnUni.UseVisualStyleBackColor = true;
            this.addBtnUni.Click += new System.EventHandler(this.addBtnUni_Click);
            // 
            // uniIdBox
            // 
            this.uniIdBox.Location = new System.Drawing.Point(20, 16);
            this.uniIdBox.Name = "uniIdBox";
            this.uniIdBox.Size = new System.Drawing.Size(590, 22);
            this.uniIdBox.TabIndex = 23;
            this.uniIdBox.TextChanged += new System.EventHandler(this.uniIdBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.instituteDataGridView);
            this.tabPage2.Controls.Add(this.delInstBtn);
            this.tabPage2.Controls.Add(this.chgInstBtn);
            this.tabPage2.Controls.Add(this.addInstBtn);
            this.tabPage2.Controls.Add(this.instIdBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 690);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Institutes";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.Institutes_Click);
            // 
            // instituteDataGridView
            // 
            this.instituteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instituteDataGridView.Location = new System.Drawing.Point(18, 172);
            this.instituteDataGridView.Name = "instituteDataGridView";
            this.instituteDataGridView.RowHeadersWidth = 51;
            this.instituteDataGridView.RowTemplate.Height = 24;
            this.instituteDataGridView.Size = new System.Drawing.Size(590, 512);
            this.instituteDataGridView.TabIndex = 28;
            // 
            // delInstBtn
            // 
            this.delInstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delInstBtn.Location = new System.Drawing.Point(457, 64);
            this.delInstBtn.Name = "delInstBtn";
            this.delInstBtn.Size = new System.Drawing.Size(151, 67);
            this.delInstBtn.TabIndex = 22;
            this.delInstBtn.Text = "Delete";
            this.delInstBtn.UseVisualStyleBackColor = true;
            // 
            // chgInstBtn
            // 
            this.chgInstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chgInstBtn.Location = new System.Drawing.Point(237, 64);
            this.chgInstBtn.Name = "chgInstBtn";
            this.chgInstBtn.Size = new System.Drawing.Size(151, 67);
            this.chgInstBtn.TabIndex = 21;
            this.chgInstBtn.Text = "Change";
            this.chgInstBtn.UseVisualStyleBackColor = true;
            // 
            // addInstBtn
            // 
            this.addInstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addInstBtn.Location = new System.Drawing.Point(18, 64);
            this.addInstBtn.Name = "addInstBtn";
            this.addInstBtn.Size = new System.Drawing.Size(151, 67);
            this.addInstBtn.TabIndex = 20;
            this.addInstBtn.Text = "Add";
            this.addInstBtn.UseVisualStyleBackColor = true;
            // 
            // instIdBox
            // 
            this.instIdBox.Location = new System.Drawing.Point(18, 20);
            this.instIdBox.Name = "instIdBox";
            this.instIdBox.Size = new System.Drawing.Size(590, 22);
            this.instIdBox.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.authorDataGridView);
            this.tabPage3.Controls.Add(this.delAuthBtn);
            this.tabPage3.Controls.Add(this.changeAuthBtn);
            this.tabPage3.Controls.Add(this.addAuthBtn);
            this.tabPage3.Controls.Add(this.authTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(628, 690);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Authors";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // authorDataGridView
            // 
            this.authorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorDataGridView.Location = new System.Drawing.Point(16, 163);
            this.authorDataGridView.Name = "authorDataGridView";
            this.authorDataGridView.RowHeadersWidth = 51;
            this.authorDataGridView.RowTemplate.Height = 24;
            this.authorDataGridView.Size = new System.Drawing.Size(590, 512);
            this.authorDataGridView.TabIndex = 28;
            // 
            // delAuthBtn
            // 
            this.delAuthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delAuthBtn.Location = new System.Drawing.Point(455, 66);
            this.delAuthBtn.Name = "delAuthBtn";
            this.delAuthBtn.Size = new System.Drawing.Size(151, 67);
            this.delAuthBtn.TabIndex = 18;
            this.delAuthBtn.Text = "Delete";
            this.delAuthBtn.UseVisualStyleBackColor = true;
            // 
            // changeAuthBtn
            // 
            this.changeAuthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changeAuthBtn.Location = new System.Drawing.Point(235, 66);
            this.changeAuthBtn.Name = "changeAuthBtn";
            this.changeAuthBtn.Size = new System.Drawing.Size(151, 67);
            this.changeAuthBtn.TabIndex = 17;
            this.changeAuthBtn.Text = "Change";
            this.changeAuthBtn.UseVisualStyleBackColor = true;
            // 
            // addAuthBtn
            // 
            this.addAuthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addAuthBtn.Location = new System.Drawing.Point(16, 66);
            this.addAuthBtn.Name = "addAuthBtn";
            this.addAuthBtn.Size = new System.Drawing.Size(151, 67);
            this.addAuthBtn.TabIndex = 16;
            this.addAuthBtn.Text = "Add";
            this.addAuthBtn.UseVisualStyleBackColor = true;
            // 
            // authTextBox
            // 
            this.authTextBox.Location = new System.Drawing.Point(16, 22);
            this.authTextBox.Name = "authTextBox";
            this.authTextBox.Size = new System.Drawing.Size(590, 22);
            this.authTextBox.TabIndex = 9;
            // 
            // UpdateThesisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 734);
            this.Controls.Add(this.tabControl1);
            this.Name = "UpdateThesisForm";
            this.Text = "UpdateThesisForm";
            this.Load += new System.EventHandler(this.UpdateThesisForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox authTextBox;
        private System.Windows.Forms.Button delAuthBtn;
        private System.Windows.Forms.Button changeAuthBtn;
        private System.Windows.Forms.Button addAuthBtn;
        private System.Windows.Forms.Button delBtnUni;
        private System.Windows.Forms.Button changeBtnUni;
        private System.Windows.Forms.Button addBtnUni;
        private System.Windows.Forms.TextBox uniIdBox;
        private System.Windows.Forms.Button delInstBtn;
        private System.Windows.Forms.Button chgInstBtn;
        private System.Windows.Forms.Button addInstBtn;
        private System.Windows.Forms.TextBox instIdBox;
        private System.Windows.Forms.DataGridView universityDataGridView;
        private System.Windows.Forms.DataGridView instituteDataGridView;
        private System.Windows.Forms.DataGridView authorDataGridView;
    }
}