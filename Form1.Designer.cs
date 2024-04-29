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
            this.btnShowBalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ввести доходы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.Location = new System.Drawing.Point(13, 68);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Категория расходов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сумма расходов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Сумма сбережений";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Категория сбережений";
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(196, 38);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(100, 23);
            this.btnAddExpense.TabIndex = 12;
            this.btnAddExpense.Text = "Ввести расходы";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(196, 71);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseAmount.TabIndex = 13;
            // 
            // txtExpenseName
            // 
            this.txtExpenseName.Location = new System.Drawing.Point(196, 98);
            this.txtExpenseName.Name = "txtExpenseName";
            this.txtExpenseName.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseName.TabIndex = 14;
            // 
            // btnAddSavings
            // 
            this.btnAddSavings.Location = new System.Drawing.Point(451, 38);
            this.btnAddSavings.Name = "btnAddSavings";
            this.btnAddSavings.Size = new System.Drawing.Size(122, 23);
            this.btnAddSavings.TabIndex = 15;
            this.btnAddSavings.Text = "Ввести сбережения";
            this.btnAddSavings.UseVisualStyleBackColor = true;
            this.btnAddSavings.Click += new System.EventHandler(this.btnAddSavings_Click);
            // 
            // txtSavingsAmount
            // 
            this.txtSavingsAmount.Location = new System.Drawing.Point(451, 67);
            this.txtSavingsAmount.Name = "txtSavingsAmount";
            this.txtSavingsAmount.Size = new System.Drawing.Size(100, 20);
            this.txtSavingsAmount.TabIndex = 16;
            // 
            // txtSavingsName
            // 
            this.txtSavingsName.Location = new System.Drawing.Point(451, 98);
            this.txtSavingsName.Name = "txtSavingsName";
            this.txtSavingsName.Size = new System.Drawing.Size(100, 20);
            this.txtSavingsName.TabIndex = 17;
            // 
            // btnShowBalance
            // 
            this.btnShowBalance.Location = new System.Drawing.Point(259, 244);
            this.btnShowBalance.Name = "btnShowBalance";
            this.btnShowBalance.Size = new System.Drawing.Size(232, 72);
            this.btnShowBalance.TabIndex = 18;
            this.btnShowBalance.Text = "Общий баланс";
            this.btnShowBalance.UseVisualStyleBackColor = true;
            this.btnShowBalance.Click += new System.EventHandler(this.btnShowBalance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowBalance);
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
        private System.Windows.Forms.Button btnShowBalance;
    }
}

