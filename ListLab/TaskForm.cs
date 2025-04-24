using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ListLab.SingleLinkedList;
using static ListLab.Node;
using System.Runtime.ExceptionServices;
using System.Reflection;
using static System.Reflection.Metadata.BlobBuilder;
using System.DirectoryServices;

namespace ListLab
{
    public partial class TaskForm : Form
    {
        List<Node> searchResaults = new List<Node>();
        SingleLinkedList lib = new SingleLinkedList();
        public TaskForm()
        {
            InitializeComponent();
        }

        private void AddFirstStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnButton_Click(sender, e);
            AddLabel.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            buttonAdd.Visible = true;
            ReturnButton.Visible = true;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0' || (int)e.KeyChar == 8)) e.KeyChar = (char)0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Мало информации о книге");
            }
            else if (!int.TryParse(textBox1.Text, out int x))
            {
                MessageBox.Show("Число выходит за рамки");
            }
            else
            {
                if (lib.CheckNumber(int.Parse(textBox1.Text)))
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else
                {
                    lib.Insert(int.Parse(textBox1.Text), textBox3.Text, textBox2.Text, int.Parse(textBox4.Text));
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            AddLabel.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            buttonAdd.Visible = false;
            ReturnButton.Visible = false;
            dataGridView.Visible = false;
            FindTextBox.Visible = false;
            dataGridView.DataSource = null;
            DeleteAfterButton.Visible = false;
            DeleteTextBox.Visible = false;
            DeleteBeforeButton.Visible = false;
            DeleteThisButton.Visible = false;
            ButtonAddLast.Visible = false;
            buttonAddIn.Visible = false;
            label1.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            DeleteBtn.Visible = false;
        }

        private void NamedFindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnButton_Click(sender, e);
            ReturnButton.Visible = true;
            FindTextBox.Visible = true;
            dataGridView.Visible = true;
            dataGridView.DataSource = null;

        }

        


        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnButton_Click(sender, e);
            List<Node> books = lib.GetBooks();
            books.Sort(delegate (Node n1, Node n2) { return n1.Author.CompareTo(n2.Author); });
            dataGridView.DataSource = books.Select(x => new
            {
                Номер = x.InventoryNumber,
                Название = x.Title,
                Автор = x.Author,
                Год = x.Year
            }).ToList();
            dataGridView.Visible = true;
            ReturnButton.Visible = true;
        }


        private void UpdateGrid()
        {
            dataGridView.DataSource = null;
            if (searchResaults.Any())
            {
                dataGridView.DataSource = searchResaults.Select(x => new
                {
                    Номер = x.InventoryNumber,
                    Название = x.Title,
                    Автор = x.Author,
                    Год = x.Year
                }).ToList();
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = ((TextBox)sender).Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                searchResaults.Clear();
                UpdateGrid();
                return;
            }
            searchResaults = lib.GetBooks().Where(x => x.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            UpdateGrid();
        }

        private void DeleteLibToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnButton_Click(sender, e);
            lib.Clear();
        }

        private void AfterYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnButton_Click(sender, e);
            DeleteTextBox.Visible = true;
            DeleteAfterButton.Visible = true;
            ReturnButton.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteTextBox.Text == "") MessageBox.Show("Напишите что-нибудь");
            else
            {
                lib.DeleteAfter(int.Parse(DeleteTextBox.Text));
                DeleteTextBox.Text = "";
                MessageBox.Show("Успешно удалено");
            }

        }

        private void BeforeYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnButton_Click(sender, e);
            DeleteTextBox.Visible = true;
            DeleteBeforeButton.Visible = true;
            ReturnButton.Visible = true;
        }
        private void ThisYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnButton_Click(sender, e);
            DeleteTextBox.Visible = true;
            DeleteThisButton.Visible = true;
            ReturnButton.Visible = true;
        }

        private void DeleteBeforeButton_Click(object sender, EventArgs e)
        {
            if (DeleteTextBox.Text == "") MessageBox.Show("Напишите что-нибудь");
            else
            {
                lib.DeleteBefore(int.Parse(DeleteTextBox.Text));
                DeleteTextBox.Text = "";
                MessageBox.Show("Успешно удалено");
            }

        }

        private void DeleteThisButton_Click(object sender, EventArgs e)
        {
            if (DeleteTextBox.Text == "")
            {
                MessageBox.Show("Напишите что-нибудь");
            }
            else
            {
                lib.DeleteThisYear(int.Parse(DeleteTextBox.Text));
                DeleteTextBox.Text = "";
                MessageBox.Show("Успешно удалено");
            }

        }

        private void LastDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnButton_Click(sender, e);
            lib.DeleteLast();
            MessageBox.Show("Успешно удалено");
        }

        private void AddLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnButton_Click(sender, e);
            AddLabel.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            ButtonAddLast.Visible = true;
            ReturnButton.Visible = true;
        }

        private void AddInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnButton_Click(sender, e);
            AddLabel.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            buttonAddIn.Visible = true;
            ReturnButton.Visible = true;
            label1.Visible = true;
            textBox5.Visible = true;
        }

        private void ButtonAddLast_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Мало информации о книге");
            }
            else if (!int.TryParse(textBox1.Text, out int x))
            {
                MessageBox.Show("Число выходит за рамки");
            }
            else
            {
                if (lib.CheckNumber(int.Parse(textBox1.Text)))
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else
                {
                    lib.InsertLast(int.Parse(textBox1.Text), textBox3.Text, textBox2.Text, int.Parse(textBox4.Text));
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }

            }
        }

        private void DeleteFirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnButton_Click(sender, e);
            lib.DeleteFirst();
            MessageBox.Show("Успешно удалено");
        }

        private void buttonAddIn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Мало информации о книге");
            }
            else if (!int.TryParse(textBox1.Text, out int x))
            {
                MessageBox.Show("Число выходит за рамки");
            }
            else
            {
                if (lib.CheckNumber(int.Parse(textBox1.Text)) && lib.CheckNumber(int.Parse(textBox4.Text)))
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
                else
                {
                    lib.InsertAfter(int.Parse(textBox5.Text), int.Parse(textBox1.Text), textBox3.Text, textBox2.Text, int.Parse(textBox4.Text));
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }

            }
        }

        private void DeleteForNumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnButton_Click(sender, e);
            textBox6.Visible = true;
            DeleteBtn.Visible = true;
            ReturnButton.Visible = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox6.Text) < 0 && int.Parse(textBox6.Text) > 2147483647)
            {
                MessageBox.Show("Число выходит за рамки");
            }          
            if (!int.TryParse(textBox6.Text, out int x))
            {
                MessageBox.Show("Число выходит за рамки");
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Напишите номер");
            }
            else
            {
                lib.DeleteIn(int.Parse(textBox6.Text));
                MessageBox.Show("Успешно удалено");
                textBox6.Clear();
            }
        }
    }
}
