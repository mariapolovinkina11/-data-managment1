namespace BD_Ab
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
            this.button_find = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_red = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.ФИО = new System.Windows.Forms.Label();
            this.FIO_Text = new System.Windows.Forms.TextBox();
            this.find_phone = new System.Windows.Forms.TextBox();
            this.main_tab_control = new System.Windows.Forms.TabControl();
            this.name = new System.Windows.Forms.TabPage();
            this.abonent_t = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contact_t = new System.Windows.Forms.DataGridView();
            this.provaider = new System.Windows.Forms.TabPage();
            this.provider_t = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ab_tab = new System.Windows.Forms.DataGridView();
            this.main_tab_control.SuspendLayout();
            this.name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonent_t)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contact_t)).BeginInit();
            this.provaider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provider_t)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ab_tab)).BeginInit();
            this.SuspendLayout();
            // 
            // button_find
            // 
            this.button_find.Location = new System.Drawing.Point(147, 606);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(100, 44);
            this.button_find.TabIndex = 0;
            this.button_find.Text = "Найти";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(606, 599);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(175, 43);
            this.button_delete.TabIndex = 24;
            this.button_delete.Text = " Удалить абонента";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_red
            // 
            this.button_red.Location = new System.Drawing.Point(604, 529);
            this.button_red.Name = "button_red";
            this.button_red.Size = new System.Drawing.Size(175, 51);
            this.button_red.TabIndex = 23;
            this.button_red.Text = "Редактировать абонента";
            this.button_red.UseVisualStyleBackColor = true;
            this.button_red.Click += new System.EventHandler(this.button_red_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(604, 469);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(175, 38);
            this.button_add.TabIndex = 22;
            this.button_add.Text = "Добавить абонента";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(5, 563);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(121, 17);
            this.label.TabIndex = 21;
            this.label.Text = "Номер телефона";
            // 
            // ФИО
            // 
            this.ФИО.AutoSize = true;
            this.ФИО.Location = new System.Drawing.Point(66, 506);
            this.ФИО.Name = "ФИО";
            this.ФИО.Size = new System.Drawing.Size(42, 17);
            this.ФИО.TabIndex = 20;
            this.ФИО.Text = "ФИО";
            // 
            // FIO_Text
            // 
            this.FIO_Text.Location = new System.Drawing.Point(147, 506);
            this.FIO_Text.Name = "FIO_Text";
            this.FIO_Text.Size = new System.Drawing.Size(100, 22);
            this.FIO_Text.TabIndex = 19;
            // 
            // find_phone
            // 
            this.find_phone.Location = new System.Drawing.Point(147, 558);
            this.find_phone.Name = "find_phone";
            this.find_phone.Size = new System.Drawing.Size(100, 22);
            this.find_phone.TabIndex = 18;
            // 
            // main_tab_control
            // 
            this.main_tab_control.Controls.Add(this.name);
            this.main_tab_control.Controls.Add(this.tabPage1);
            this.main_tab_control.Controls.Add(this.provaider);
            this.main_tab_control.Controls.Add(this.tabPage2);
            this.main_tab_control.Location = new System.Drawing.Point(13, 13);
            this.main_tab_control.Margin = new System.Windows.Forms.Padding(4);
            this.main_tab_control.Name = "main_tab_control";
            this.main_tab_control.SelectedIndex = 0;
            this.main_tab_control.Size = new System.Drawing.Size(779, 449);
            this.main_tab_control.TabIndex = 25;
            // 
            // name
            // 
            this.name.Controls.Add(this.abonent_t);
            this.name.Location = new System.Drawing.Point(4, 25);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(4);
            this.name.Size = new System.Drawing.Size(771, 420);
            this.name.TabIndex = 0;
            this.name.Text = "Абонент";
            this.name.UseVisualStyleBackColor = true;
            // 
            // abonent_t
            // 
            this.abonent_t.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonent_t.Location = new System.Drawing.Point(3, -5);
            this.abonent_t.Margin = new System.Windows.Forms.Padding(4);
            this.abonent_t.Name = "abonent_t";
            this.abonent_t.RowHeadersWidth = 51;
            this.abonent_t.Size = new System.Drawing.Size(777, 425);
            this.abonent_t.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.contact_t);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(771, 420);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Контакт";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // contact_t
            // 
            this.contact_t.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contact_t.Location = new System.Drawing.Point(0, 2);
            this.contact_t.Margin = new System.Windows.Forms.Padding(4);
            this.contact_t.Name = "contact_t";
            this.contact_t.RowHeadersWidth = 51;
            this.contact_t.Size = new System.Drawing.Size(772, 422);
            this.contact_t.TabIndex = 0;
            // 
            // provaider
            // 
            this.provaider.Controls.Add(this.provider_t);
            this.provaider.Location = new System.Drawing.Point(4, 25);
            this.provaider.Margin = new System.Windows.Forms.Padding(4);
            this.provaider.Name = "provaider";
            this.provaider.Size = new System.Drawing.Size(771, 420);
            this.provaider.TabIndex = 2;
            this.provaider.Text = "Провайдер";
            this.provaider.UseVisualStyleBackColor = true;
            // 
            // provider_t
            // 
            this.provider_t.AccessibleDescription = "";
            this.provider_t.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provider_t.Location = new System.Drawing.Point(0, 2);
            this.provider_t.Margin = new System.Windows.Forms.Padding(4);
            this.provider_t.Name = "provider_t";
            this.provider_t.RowHeadersWidth = 51;
            this.provider_t.ShowCellToolTips = false;
            this.provider_t.Size = new System.Drawing.Size(780, 418);
            this.provider_t.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ab_tab);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(771, 420);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Телефонный справочник";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ab_tab
            // 
            this.ab_tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ab_tab.Location = new System.Drawing.Point(4, 4);
            this.ab_tab.Margin = new System.Windows.Forms.Padding(4);
            this.ab_tab.Name = "ab_tab";
            this.ab_tab.RowHeadersWidth = 51;
            this.ab_tab.Size = new System.Drawing.Size(772, 416);
            this.ab_tab.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.main_tab_control);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_red);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ФИО);
            this.Controls.Add(this.FIO_Text);
            this.Controls.Add(this.find_phone);
            this.Controls.Add(this.button_find);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_tab_control.ResumeLayout(false);
            this.name.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.abonent_t)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contact_t)).EndInit();
            this.provaider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.provider_t)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ab_tab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_red;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label ФИО;
        private System.Windows.Forms.TextBox FIO_Text;
        private System.Windows.Forms.TextBox find_phone;
        private System.Windows.Forms.TabControl main_tab_control;
        private System.Windows.Forms.TabPage name;
        public System.Windows.Forms.DataGridView abonent_t;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView contact_t;
        private System.Windows.Forms.TabPage provaider;
        private System.Windows.Forms.DataGridView provider_t;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ab_tab;
    }
}

