namespace ListLab
{
    partial class TaskForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            menuStrip1 = new MenuStrip();
            RedactToolStripMenuItem = new ToolStripMenuItem();
            AddBookToolStripMenuItem = new ToolStripMenuItem();
            AddFirstToolStripMenuItem = new ToolStripMenuItem();
            AddLastToolStripMenuItem = new ToolStripMenuItem();
            AddInToolStripMenuItem = new ToolStripMenuItem();
            DeleteBookToolStripMenuItem = new ToolStripMenuItem();
            ForYearToolStripMenuItem = new ToolStripMenuItem();
            AfterYearToolStripMenuItem = new ToolStripMenuItem();
            BeforeYearToolStripMenuItem = new ToolStripMenuItem();
            ThisYearToolStripMenuItem = new ToolStripMenuItem();
            LastDeleteToolStripMenuItem = new ToolStripMenuItem();
            DeleteFirstToolStripMenuItem = new ToolStripMenuItem();
            DeleteForNumToolStripMenuItem = new ToolStripMenuItem();
            DeleteLibToolStripMenuItem = new ToolStripMenuItem();
            FindToolStripMenuItem = new ToolStripMenuItem();
            NamedFindToolStripMenuItem = new ToolStripMenuItem();
            DeleteForToolStripMenuItem = new ToolStripMenuItem();
            AfterDeleteToolStripMenuItem = new ToolStripMenuItem();
            BeforeDeleteToolStripMenuItem = new ToolStripMenuItem();
            PrintToolStripMenuItem = new ToolStripMenuItem();
            AddLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            buttonAdd = new Button();
            FindTextBox = new TextBox();
            ReturnButton = new Button();
            dataGridView = new DataGridView();
            singleLinkedListBindingSource = new BindingSource(components);
            DeleteTextBox = new TextBox();
            DeleteAfterButton = new Button();
            DeleteBeforeButton = new Button();
            DeleteThisButton = new Button();
            ButtonAddLast = new Button();
            buttonAddIn = new Button();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            DeleteBtn = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)singleLinkedListBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { RedactToolStripMenuItem, FindToolStripMenuItem, PrintToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(641, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // RedactToolStripMenuItem
            // 
            RedactToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddBookToolStripMenuItem, DeleteBookToolStripMenuItem, DeleteLibToolStripMenuItem });
            RedactToolStripMenuItem.Name = "RedactToolStripMenuItem";
            RedactToolStripMenuItem.Size = new Size(108, 20);
            RedactToolStripMenuItem.Text = "Редактирование";
            // 
            // AddBookToolStripMenuItem
            // 
            AddBookToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddFirstToolStripMenuItem, AddLastToolStripMenuItem, AddInToolStripMenuItem });
            AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem";
            AddBookToolStripMenuItem.Size = new Size(209, 22);
            AddBookToolStripMenuItem.Text = "Добавить книгу";
            // 
            // AddFirstToolStripMenuItem
            // 
            AddFirstToolStripMenuItem.Name = "AddFirstToolStripMenuItem";
            AddFirstToolStripMenuItem.Size = new Size(205, 22);
            AddFirstToolStripMenuItem.Text = "В начало";
            AddFirstToolStripMenuItem.Click += AddFirstStripMenuItem_Click;
            // 
            // AddLastToolStripMenuItem
            // 
            AddLastToolStripMenuItem.Name = "AddLastToolStripMenuItem";
            AddLastToolStripMenuItem.Size = new Size(205, 22);
            AddLastToolStripMenuItem.Text = "В конец";
            AddLastToolStripMenuItem.Click += AddLastToolStripMenuItem_Click;
            // 
            // AddInToolStripMenuItem
            // 
            AddInToolStripMenuItem.Name = "AddInToolStripMenuItem";
            AddInToolStripMenuItem.Size = new Size(205, 22);
            AddInToolStripMenuItem.Text = "По инв. номеру (после)";
            AddInToolStripMenuItem.Click += AddInToolStripMenuItem_Click;
            // 
            // DeleteBookToolStripMenuItem
            // 
            DeleteBookToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ForYearToolStripMenuItem, LastDeleteToolStripMenuItem, DeleteFirstToolStripMenuItem, DeleteForNumToolStripMenuItem });
            DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem";
            DeleteBookToolStripMenuItem.Size = new Size(209, 22);
            DeleteBookToolStripMenuItem.Text = "Удалить книгу";
            // 
            // ForYearToolStripMenuItem
            // 
            ForYearToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AfterYearToolStripMenuItem, BeforeYearToolStripMenuItem, ThisYearToolStripMenuItem });
            ForYearToolStripMenuItem.Name = "ForYearToolStripMenuItem";
            ForYearToolStripMenuItem.Size = new Size(180, 22);
            ForYearToolStripMenuItem.Text = "По году";
            ForYearToolStripMenuItem.Visible = false;
            // 
            // AfterYearToolStripMenuItem
            // 
            AfterYearToolStripMenuItem.Name = "AfterYearToolStripMenuItem";
            AfterYearToolStripMenuItem.Size = new Size(169, 22);
            AfterYearToolStripMenuItem.Text = "После этого года";
            AfterYearToolStripMenuItem.Click += AfterYearToolStripMenuItem_Click;
            // 
            // BeforeYearToolStripMenuItem
            // 
            BeforeYearToolStripMenuItem.Name = "BeforeYearToolStripMenuItem";
            BeforeYearToolStripMenuItem.Size = new Size(169, 22);
            BeforeYearToolStripMenuItem.Text = "До этого года";
            BeforeYearToolStripMenuItem.Click += BeforeYearToolStripMenuItem_Click;
            // 
            // ThisYearToolStripMenuItem
            // 
            ThisYearToolStripMenuItem.Name = "ThisYearToolStripMenuItem";
            ThisYearToolStripMenuItem.Size = new Size(169, 22);
            ThisYearToolStripMenuItem.Text = "В этом году";
            ThisYearToolStripMenuItem.Click += ThisYearToolStripMenuItem_Click;
            // 
            // LastDeleteToolStripMenuItem
            // 
            LastDeleteToolStripMenuItem.Name = "LastDeleteToolStripMenuItem";
            LastDeleteToolStripMenuItem.Size = new Size(180, 22);
            LastDeleteToolStripMenuItem.Text = "В конце списка";
            LastDeleteToolStripMenuItem.Click += LastDeleteToolStripMenuItem_Click;
            // 
            // DeleteFirstToolStripMenuItem
            // 
            DeleteFirstToolStripMenuItem.Name = "DeleteFirstToolStripMenuItem";
            DeleteFirstToolStripMenuItem.Size = new Size(180, 22);
            DeleteFirstToolStripMenuItem.Text = "В начале списка";
            DeleteFirstToolStripMenuItem.Click += DeleteFirstToolStripMenuItem_Click;
            // 
            // DeleteForNumToolStripMenuItem
            // 
            DeleteForNumToolStripMenuItem.Name = "DeleteForNumToolStripMenuItem";
            DeleteForNumToolStripMenuItem.Size = new Size(180, 22);
            DeleteForNumToolStripMenuItem.Text = "По инв. номеру";
            DeleteForNumToolStripMenuItem.Click += DeleteForNumToolStripMenuItem_Click;
            // 
            // DeleteLibToolStripMenuItem
            // 
            DeleteLibToolStripMenuItem.Name = "DeleteLibToolStripMenuItem";
            DeleteLibToolStripMenuItem.Size = new Size(209, 22);
            DeleteLibToolStripMenuItem.Text = "Уничтожить библиотеку";
            DeleteLibToolStripMenuItem.Click += DeleteLibToolStripMenuItem_Click;
            // 
            // FindToolStripMenuItem
            // 
            FindToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NamedFindToolStripMenuItem, DeleteForToolStripMenuItem });
            FindToolStripMenuItem.Name = "FindToolStripMenuItem";
            FindToolStripMenuItem.Size = new Size(108, 20);
            FindToolStripMenuItem.Text = "Редактирование";
            // 
            // NamedFindToolStripMenuItem
            // 
            NamedFindToolStripMenuItem.Name = "NamedFindToolStripMenuItem";
            NamedFindToolStripMenuItem.Size = new Size(183, 22);
            NamedFindToolStripMenuItem.Text = "Поиск по названию";
            NamedFindToolStripMenuItem.Click += NamedFindToolStripMenuItem_Click;
            // 
            // DeleteForToolStripMenuItem
            // 
            DeleteForToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AfterDeleteToolStripMenuItem, BeforeDeleteToolStripMenuItem });
            DeleteForToolStripMenuItem.Name = "DeleteForToolStripMenuItem";
            DeleteForToolStripMenuItem.Size = new Size(183, 22);
            DeleteForToolStripMenuItem.Text = "Списание книги";
            // 
            // AfterDeleteToolStripMenuItem
            // 
            AfterDeleteToolStripMenuItem.Name = "AfterDeleteToolStripMenuItem";
            AfterDeleteToolStripMenuItem.Size = new Size(202, 22);
            AfterDeleteToolStripMenuItem.Text = "После введенного года";
            AfterDeleteToolStripMenuItem.Click += AfterYearToolStripMenuItem_Click;
            // 
            // BeforeDeleteToolStripMenuItem
            // 
            BeforeDeleteToolStripMenuItem.Name = "BeforeDeleteToolStripMenuItem";
            BeforeDeleteToolStripMenuItem.Size = new Size(202, 22);
            BeforeDeleteToolStripMenuItem.Text = "До введенного года";
            BeforeDeleteToolStripMenuItem.Click += BeforeYearToolStripMenuItem_Click;
            // 
            // PrintToolStripMenuItem
            // 
            PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            PrintToolStripMenuItem.Size = new Size(54, 20);
            PrintToolStripMenuItem.Text = "Вывод";
            PrintToolStripMenuItem.Click += PrintToolStripMenuItem_Click;
            // 
            // AddLabel
            // 
            AddLabel.AutoSize = true;
            AddLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddLabel.Location = new Point(12, 38);
            AddLabel.Name = "AddLabel";
            AddLabel.Size = new Size(269, 175);
            AddLabel.TabIndex = 1;
            AddLabel.Text = "Введите инвентарный номер:\r\n\r\nВведите название книги:\r\n\r\nВведите автора книги:\r\n\r\nВведите год выпуска книги:";
            AddLabel.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(308, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 29);
            textBox1.TabIndex = 2;
            textBox1.Visible = false;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(308, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 29);
            textBox2.TabIndex = 3;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(308, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 29);
            textBox3.TabIndex = 4;
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(308, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(184, 29);
            textBox4.TabIndex = 5;
            textBox4.Visible = false;
            textBox4.KeyPress += textBox1_KeyPress;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(498, 38);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(131, 181);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Visible = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FindTextBox
            // 
            FindTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FindTextBox.Location = new Point(12, 34);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.PlaceholderText = "Введите название книги:";
            FindTextBox.Size = new Size(617, 33);
            FindTextBox.TabIndex = 8;
            FindTextBox.Visible = false;
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            // 
            // ReturnButton
            // 
            ReturnButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ReturnButton.Location = new Point(498, 252);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(131, 33);
            ReturnButton.TabIndex = 11;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Visible = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Location = new Point(12, 73);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(617, 177);
            dataGridView.TabIndex = 12;
            dataGridView.Visible = false;
            // 
            // singleLinkedListBindingSource
            // 
            singleLinkedListBindingSource.DataSource = typeof(SingleLinkedList);
            // 
            // DeleteTextBox
            // 
            DeleteTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteTextBox.Location = new Point(12, 34);
            DeleteTextBox.Name = "DeleteTextBox";
            DeleteTextBox.PlaceholderText = "Введите год:";
            DeleteTextBox.Size = new Size(480, 33);
            DeleteTextBox.TabIndex = 13;
            DeleteTextBox.Visible = false;
            DeleteTextBox.KeyPress += textBox1_KeyPress;
            // 
            // DeleteAfterButton
            // 
            DeleteAfterButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteAfterButton.Location = new Point(498, 34);
            DeleteAfterButton.Name = "DeleteAfterButton";
            DeleteAfterButton.Size = new Size(131, 33);
            DeleteAfterButton.TabIndex = 14;
            DeleteAfterButton.Text = "Удалить";
            DeleteAfterButton.UseVisualStyleBackColor = true;
            DeleteAfterButton.Visible = false;
            DeleteAfterButton.Click += DeleteButton_Click;
            // 
            // DeleteBeforeButton
            // 
            DeleteBeforeButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteBeforeButton.Location = new Point(498, 34);
            DeleteBeforeButton.Name = "DeleteBeforeButton";
            DeleteBeforeButton.Size = new Size(131, 33);
            DeleteBeforeButton.TabIndex = 15;
            DeleteBeforeButton.Text = "Удалить";
            DeleteBeforeButton.UseVisualStyleBackColor = true;
            DeleteBeforeButton.Visible = false;
            DeleteBeforeButton.Click += DeleteBeforeButton_Click;
            // 
            // DeleteThisButton
            // 
            DeleteThisButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteThisButton.Location = new Point(500, 34);
            DeleteThisButton.Name = "DeleteThisButton";
            DeleteThisButton.Size = new Size(131, 33);
            DeleteThisButton.TabIndex = 16;
            DeleteThisButton.Text = "Удалить";
            DeleteThisButton.UseVisualStyleBackColor = true;
            DeleteThisButton.Visible = false;
            DeleteThisButton.Click += DeleteThisButton_Click;
            // 
            // ButtonAddLast
            // 
            ButtonAddLast.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonAddLast.Location = new Point(497, 38);
            ButtonAddLast.Name = "ButtonAddLast";
            ButtonAddLast.Size = new Size(131, 181);
            ButtonAddLast.TabIndex = 17;
            ButtonAddLast.Text = "Добавить";
            ButtonAddLast.UseVisualStyleBackColor = true;
            ButtonAddLast.Visible = false;
            ButtonAddLast.Click += ButtonAddLast_Click;
            // 
            // buttonAddIn
            // 
            buttonAddIn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddIn.Location = new Point(500, 38);
            buttonAddIn.Name = "buttonAddIn";
            buttonAddIn.Size = new Size(131, 181);
            buttonAddIn.TabIndex = 18;
            buttonAddIn.Text = "Добавить";
            buttonAddIn.UseVisualStyleBackColor = true;
            buttonAddIn.Visible = false;
            buttonAddIn.Click += buttonAddIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 225);
            label1.Name = "label1";
            label1.Size = new Size(251, 50);
            label1.TabIndex = 19;
            label1.Text = "Введите номер \r\nпосле которого добавлять: ";
            label1.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(308, 236);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(184, 29);
            textBox5.TabIndex = 20;
            textBox5.Visible = false;
            textBox5.KeyPress += textBox1_KeyPress;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox6.Location = new Point(11, 34);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Введите номер: ";
            textBox6.Size = new Size(480, 33);
            textBox6.TabIndex = 21;
            textBox6.Visible = false;
            textBox6.KeyPress += textBox1_KeyPress;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteBtn.Location = new Point(497, 36);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(131, 33);
            DeleteBtn.TabIndex = 22;
            DeleteBtn.Text = "Удалить";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Visible = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 293);
            Controls.Add(DeleteBtn);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label1);
            Controls.Add(DeleteThisButton);
            Controls.Add(DeleteBeforeButton);
            Controls.Add(DeleteAfterButton);
            Controls.Add(ReturnButton);
            Controls.Add(buttonAdd);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Controls.Add(DeleteTextBox);
            Controls.Add(AddLabel);
            Controls.Add(FindTextBox);
            Controls.Add(dataGridView);
            Controls.Add(buttonAddIn);
            Controls.Add(ButtonAddLast);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "TaskForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Задание";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)singleLinkedListBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem RedactToolStripMenuItem;
        private ToolStripMenuItem AddBookToolStripMenuItem;
        private ToolStripMenuItem DeleteBookToolStripMenuItem;
        private ToolStripMenuItem FindToolStripMenuItem;
        private ToolStripMenuItem PrintToolStripMenuItem;
        private ToolStripMenuItem ForYearToolStripMenuItem;
        private ToolStripMenuItem AfterYearToolStripMenuItem;
        private ToolStripMenuItem BeforeYearToolStripMenuItem;
        private ToolStripMenuItem ThisYearToolStripMenuItem;
        private ToolStripMenuItem DeleteLibToolStripMenuItem;
        private ToolStripMenuItem NamedFindToolStripMenuItem;
        private Label AddLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button buttonAdd;
        private TextBox FindTextBox;
        private Button ReturnButton;
        private DataGridView dataGridView;
        private BindingSource singleLinkedListBindingSource;
        private TextBox DeleteTextBox;
        private Button DeleteAfterButton;
        private Button DeleteBeforeButton;
        private Button DeleteThisButton;
        private ToolStripMenuItem LastDeleteToolStripMenuItem;
        private ToolStripMenuItem DeleteFirstToolStripMenuItem;
        private ToolStripMenuItem AddFirstToolStripMenuItem;
        private ToolStripMenuItem AddLastToolStripMenuItem;
        private ToolStripMenuItem AddInToolStripMenuItem;
        private Button ButtonAddLast;
        private Button buttonAddIn;
        private ToolStripMenuItem DeleteForNumToolStripMenuItem;
        private ToolStripMenuItem DeleteForToolStripMenuItem;
        private ToolStripMenuItem AfterDeleteToolStripMenuItem;
        private ToolStripMenuItem BeforeDeleteToolStripMenuItem;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button DeleteBtn;
    }
}