namespace Finance_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.txtExpenseName = new System.Windows.Forms.TextBox();
            this.btnAddSavings = new System.Windows.Forms.Button();
            this.txtSavingsAmount = new System.Windows.Forms.TextBox();
            this.txtSavingsName = new System.Windows.Forms.TextBox();
            this.btnShowTotalExpense = new System.Windows.Forms.Button();
            this.btnShowTotalSavings = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.operationsDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.operationsDataSet = new Finance_Manager.OperationsDataSet();
            this.operationsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationsDataSet1 = new Finance_Manager.OperationsDataSet();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(118, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ввести доходы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.Location = new System.Drawing.Point(157, 73);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Категория расходов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сумма расходов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(797, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Сумма сбережений:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Категория сбережений:";
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddExpense.Location = new System.Drawing.Point(500, 141);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(122, 44);
            this.btnAddExpense.TabIndex = 12;
            this.btnAddExpense.Text = "Ввести расходы";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(543, 54);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseAmount.TabIndex = 13;
            // 
            // txtExpenseName
            // 
            this.txtExpenseName.Location = new System.Drawing.Point(543, 91);
            this.txtExpenseName.Name = "txtExpenseName";
            this.txtExpenseName.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseName.TabIndex = 14;
            // 
            // btnAddSavings
            // 
            this.btnAddSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSavings.Location = new System.Drawing.Point(851, 141);
            this.btnAddSavings.Name = "btnAddSavings";
            this.btnAddSavings.Size = new System.Drawing.Size(122, 44);
            this.btnAddSavings.TabIndex = 15;
            this.btnAddSavings.Text = "Ввести сбережения";
            this.btnAddSavings.UseVisualStyleBackColor = true;
            this.btnAddSavings.Click += new System.EventHandler(this.btnAddSavings_Click);
            // 
            // txtSavingsAmount
            // 
            this.txtSavingsAmount.Location = new System.Drawing.Point(909, 54);
            this.txtSavingsAmount.Name = "txtSavingsAmount";
            this.txtSavingsAmount.Size = new System.Drawing.Size(100, 20);
            this.txtSavingsAmount.TabIndex = 16;
            // 
            // txtSavingsName
            // 
            this.txtSavingsName.Location = new System.Drawing.Point(909, 91);
            this.txtSavingsName.Name = "txtSavingsName";
            this.txtSavingsName.Size = new System.Drawing.Size(100, 20);
            this.txtSavingsName.TabIndex = 17;
            // 
            // btnShowTotalExpense
            // 
            this.btnShowTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowTotalExpense.Location = new System.Drawing.Point(330, 375);
            this.btnShowTotalExpense.Name = "btnShowTotalExpense";
            this.btnShowTotalExpense.Size = new System.Drawing.Size(133, 48);
            this.btnShowTotalExpense.TabIndex = 20;
            this.btnShowTotalExpense.Text = "Расходы по категориям";
            this.btnShowTotalExpense.UseVisualStyleBackColor = true;
            this.btnShowTotalExpense.Click += new System.EventHandler(this.btnShowTotalExpense_Click);
            // 
            // btnShowTotalSavings
            // 
            this.btnShowTotalSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowTotalSavings.Location = new System.Drawing.Point(643, 375);
            this.btnShowTotalSavings.Name = "btnShowTotalSavings";
            this.btnShowTotalSavings.Size = new System.Drawing.Size(133, 48);
            this.btnShowTotalSavings.TabIndex = 21;
            this.btnShowTotalSavings.Text = "Сбережения по категориям";
            this.btnShowTotalSavings.UseVisualStyleBackColor = true;
            this.btnShowTotalSavings.Click += new System.EventHandler(this.btnShowTotalSavings_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(830, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Добавить сбережения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(470, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Добавить расходы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(94, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Добавить доходы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Сумма доходов:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.DataSource = this.operationsDataSetBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(330, 258);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(446, 81);
            this.dataGridView.TabIndex = 26;
            // 
            // operationsDataSetBindingSource1
            // 
            this.operationsDataSetBindingSource1.DataSource = this.operationsDataSet;
            this.operationsDataSetBindingSource1.Position = 0;
            // 
            // operationsDataSet
            // 
            this.operationsDataSet.DataSetName = "OperationsDataSet";
            this.operationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operationsDataSetBindingSource
            // 
            this.operationsDataSetBindingSource.DataSource = this.operationsDataSet;
            this.operationsDataSetBindingSource.Position = 0;
            // 
            // operationsDataSet1
            // 
            this.operationsDataSet1.DataSetName = "OperationsDataSet";
            this.operationsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 480);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnShowTotalSavings);
            this.Controls.Add(this.btnShowTotalExpense);
            this.Controls.Add(this.txtSavingsName);
            this.Controls.Add(this.txtSavingsAmount);
            this.Controls.Add(this.btnAddSavings);
            this.Controls.Add(this.txtExpenseName);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIncomeAmount);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.TextBox txtExpenseName;
        private System.Windows.Forms.Button btnAddSavings;
        private System.Windows.Forms.TextBox txtSavingsAmount;
        private System.Windows.Forms.TextBox txtSavingsName;
        private System.Windows.Forms.Button btnShowTotalExpense;
        private System.Windows.Forms.Button btnShowTotalSavings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource operationsDataSetBindingSource;
        private OperationsDataSet operationsDataSet;
        private System.Windows.Forms.BindingSource operationsDataSetBindingSource1;
        private OperationsDataSet operationsDataSet1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Timer timer1;
    }
}

