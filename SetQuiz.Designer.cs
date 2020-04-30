namespace CSharp_QuizApp
{
    partial class SetQuiz
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.userrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizAppDataSet1 = new CSharp_QuizApp.quizAppDataSet1();
            this.user_recordTableAdapter = new CSharp_QuizApp.quizAppDataSet1TableAdapters.user_recordTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.userrecordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quizAppDataSet2 = new CSharp_QuizApp.quizAppDataSet2();
            this.user_recordTableAdapter1 = new CSharp_QuizApp.quizAppDataSet2TableAdapters.user_recordTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.quizesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizAppDataSet3 = new CSharp_QuizApp.quizAppDataSet3();
            this.quizesTableAdapter = new CSharp_QuizApp.quizAppDataSet3TableAdapters.quizesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.quizesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quizAppDataSet4 = new CSharp_QuizApp.quizAppDataSet4();
            this.quizesTableAdapter1 = new CSharp_QuizApp.quizAppDataSet4TableAdapters.quizesTableAdapter();
            this.quizAppDataSet5 = new CSharp_QuizApp.quizAppDataSet5();
            this.setquizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.set_quizTableAdapter = new CSharp_QuizApp.quizAppDataSet5TableAdapters.set_quizTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userrecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userrecordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizAppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizAppDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizAppDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizAppDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setquizBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.userrecordBindingSource;
            this.comboBox1.DisplayMember = "user_id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "user_id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // userrecordBindingSource
            // 
            this.userrecordBindingSource.DataMember = "user_record";
            this.userrecordBindingSource.DataSource = this.quizAppDataSet1;
            // 
            // quizAppDataSet1
            // 
            this.quizAppDataSet1.DataSetName = "quizAppDataSet1";
            this.quizAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_recordTableAdapter
            // 
            this.user_recordTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select User Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Names";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.userrecordBindingSource1;
            this.comboBox2.DisplayMember = "user_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 257);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "user_name";
            // 
            // userrecordBindingSource1
            // 
            this.userrecordBindingSource1.DataMember = "user_record";
            this.userrecordBindingSource1.DataSource = this.quizAppDataSet2;
            // 
            // quizAppDataSet2
            // 
            this.quizAppDataSet2.DataSetName = "quizAppDataSet2";
            this.quizAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_recordTableAdapter1
            // 
            this.user_recordTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(296, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(313, 375);
            this.dataGridView3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Exam";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.quizesBindingSource;
            this.comboBox3.DisplayMember = "quiz_name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(104, 295);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 24);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.ValueMember = "quiz_name";
            // 
            // quizesBindingSource
            // 
            this.quizesBindingSource.DataMember = "quizes";
            this.quizesBindingSource.DataSource = this.quizAppDataSet3;
            // 
            // quizAppDataSet3
            // 
            this.quizAppDataSet3.DataSetName = "quizAppDataSet3";
            this.quizAppDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quizesTableAdapter
            // 
            this.quizesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(285, 208);
            this.dataGridView2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(2, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select ExamId";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.quizesBindingSource1;
            this.comboBox4.DisplayMember = "quiz_id";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(104, 328);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(186, 24);
            this.comboBox4.TabIndex = 10;
            this.comboBox4.ValueMember = "quiz_id";
            // 
            // quizesBindingSource1
            // 
            this.quizesBindingSource1.DataMember = "quizes";
            this.quizesBindingSource1.DataSource = this.quizAppDataSet4;
            // 
            // quizAppDataSet4
            // 
            this.quizAppDataSet4.DataSetName = "quizAppDataSet4";
            this.quizAppDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quizesTableAdapter1
            // 
            this.quizesTableAdapter1.ClearBeforeFill = true;
            // 
            // quizAppDataSet5
            // 
            this.quizAppDataSet5.DataSetName = "quizAppDataSet5";
            this.quizAppDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // setquizBindingSource
            // 
            this.setquizBindingSource.DataMember = "set_quiz";
            this.setquizBindingSource.DataSource = this.quizAppDataSet5;
            // 
            // set_quizTableAdapter
            // 
            this.set_quizTableAdapter.ClearBeforeFill = true;
            // 
            // SetQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(614, 772);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SetQuiz";
            this.Text = "SetQuiz";
            this.Load += new System.EventHandler(this.SetQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userrecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userrecordBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizAppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizAppDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizAppDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizAppDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setquizBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private quizAppDataSet1 quizAppDataSet1;
        private System.Windows.Forms.BindingSource userrecordBindingSource;
        private quizAppDataSet1TableAdapters.user_recordTableAdapter user_recordTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private quizAppDataSet2 quizAppDataSet2;
        private System.Windows.Forms.BindingSource userrecordBindingSource1;
        private quizAppDataSet2TableAdapters.user_recordTableAdapter user_recordTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private quizAppDataSet3 quizAppDataSet3;
        private System.Windows.Forms.BindingSource quizesBindingSource;
        private quizAppDataSet3TableAdapters.quizesTableAdapter quizesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private quizAppDataSet4 quizAppDataSet4;
        private System.Windows.Forms.BindingSource quizesBindingSource1;
        private quizAppDataSet4TableAdapters.quizesTableAdapter quizesTableAdapter1;
        private quizAppDataSet5 quizAppDataSet5;
        private System.Windows.Forms.BindingSource setquizBindingSource;
        private quizAppDataSet5TableAdapters.set_quizTableAdapter set_quizTableAdapter;
    }
}