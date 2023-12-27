namespace se307
{
    partial class ThesisSearchForm
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
            this.enterTermBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBtn2 = new System.Windows.Forms.Button();
            this.clearBtn2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.searchInBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterTermBox
            // 
            this.enterTermBox.Location = new System.Drawing.Point(317, 40);
            this.enterTermBox.Name = "enterTermBox";
            this.enterTermBox.Size = new System.Drawing.Size(296, 22);
            this.enterTermBox.TabIndex = 0;
            this.enterTermBox.TextChanged += new System.EventHandler(this.enterTermBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thesis Type";
            // 
            // searchBtn2
            // 
            this.searchBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBtn2.Location = new System.Drawing.Point(20, 268);
            this.searchBtn2.Name = "searchBtn2";
            this.searchBtn2.Size = new System.Drawing.Size(151, 67);
            this.searchBtn2.TabIndex = 15;
            this.searchBtn2.Text = "Search";
            this.searchBtn2.UseVisualStyleBackColor = true;
            this.searchBtn2.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // clearBtn2
            // 
            this.clearBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearBtn2.Location = new System.Drawing.Point(195, 268);
            this.clearBtn2.Name = "clearBtn2";
            this.clearBtn2.Size = new System.Drawing.Size(151, 67);
            this.clearBtn2.TabIndex = 16;
            this.clearBtn2.Text = "Clear";
            this.clearBtn2.UseVisualStyleBackColor = true;
            this.clearBtn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 362);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // typeBox2
            // 
            this.typeBox2.FormattingEnabled = true;
            this.typeBox2.Location = new System.Drawing.Point(198, 212);
            this.typeBox2.Name = "typeBox2";
            this.typeBox2.Size = new System.Drawing.Size(285, 24);
            this.typeBox2.TabIndex = 23;
            this.typeBox2.SelectedIndexChanged += new System.EventHandler(this.typeBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Search Term";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Year";
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(150, 159);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(110, 22);
            this.yearBox.TabIndex = 25;
            // 
            // searchInBox
            // 
            this.searchInBox.FormattingEnabled = true;
            this.searchInBox.Location = new System.Drawing.Point(166, 106);
            this.searchInBox.Name = "searchInBox";
            this.searchInBox.Size = new System.Drawing.Size(285, 24);
            this.searchInBox.TabIndex = 26;
            this.searchInBox.SelectedIndexChanged += new System.EventHandler(this.searchInBox_SelectedIndexChanged);
            // 
            // ThesisSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 734);
            this.Controls.Add(this.searchInBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearBtn2);
            this.Controls.Add(this.searchBtn2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterTermBox);
            this.Name = "ThesisSearchForm";
            this.Text = "ThesisSearchForm";
            this.Load += new System.EventHandler(this.ThesisSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterTermBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchBtn2;
        private System.Windows.Forms.Button clearBtn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox typeBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.ComboBox searchInBox;
    }
}