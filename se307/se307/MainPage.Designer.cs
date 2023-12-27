namespace se307
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.addBtn = new System.Windows.Forms.Button();
            this.thesisDisplay = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateThesisBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBtn.Location = new System.Drawing.Point(330, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(264, 67);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add New Thesis";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // thesisDisplay
            // 
            this.thesisDisplay.Location = new System.Drawing.Point(22, 339);
            this.thesisDisplay.Name = "thesisDisplay";
            this.thesisDisplay.Size = new System.Drawing.Size(572, 383);
            this.thesisDisplay.TabIndex = 4;
            this.thesisDisplay.Text = "";
            this.thesisDisplay.TextChanged += new System.EventHandler(this.thesisDisplay_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 255);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thesis Available In The System Currently:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBtn.Location = new System.Drawing.Point(330, 200);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(264, 67);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "Search Database";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // updateThesisBtn
            // 
            this.updateThesisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateThesisBtn.Location = new System.Drawing.Point(330, 101);
            this.updateThesisBtn.Name = "updateThesisBtn";
            this.updateThesisBtn.Size = new System.Drawing.Size(264, 67);
            this.updateThesisBtn.TabIndex = 9;
            this.updateThesisBtn.Text = "Update Menu";
            this.updateThesisBtn.UseVisualStyleBackColor = true;
            this.updateThesisBtn.Click += new System.EventHandler(this.updateThesisBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 734);
            this.Controls.Add(this.updateThesisBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.thesisDisplay);
            this.Controls.Add(this.addBtn);
            this.Name = "MainPage";
            this.Text = "ThesisApp";
            this.Load += new System.EventHandler(this.MainPage_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.RichTextBox thesisDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button updateThesisBtn;
    }
}