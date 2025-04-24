using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListLab
{
    public class Node
    {

        private int inventoryNumber;
        private string author;
        private string title;
        private int year;
        private Node link;

        public int InventoryNumber 
        { 
            get { return inventoryNumber; }
            set {  inventoryNumber = value; }
        }
        public string Author
        {
            get { return author; }
            set {  author = value; }
        }
        public string Title 
        {
            get { return title; }
            set {  title = value; } 
        }
        public int Year
        {
            get { return year;}
            set { year = value; }
        }
        public Node Link
        {
            get { return link; }
            set { link = value; }
        }
        public Node(int number, string author, string title, int year)
        {
            InventoryNumber = number;
            Author = author;
            Title = title;
            Year = year;
            Link = null;
        }
        public Node(int number, string author, string title, int year, Node link)
        {
            InventoryNumber = number;
            Author = author;
            Title = title;
            Year = year;
            Link = link;
        }
    }
    public class SingleLinkedList
    {
        static public Node first;
        public SingleLinkedList()
        {
            first = null;

        }
        public void Insert(int number, string author, string title, int year)
        {
            Node n = new Node(number, author, title, year);
            n.Link = first;
            first = n;
        }
        public void InsertLast(int number, string author, string title, int year)
        {
            Node p = new Node(number, author, title, year); 
            if (first == null)
            {
                first = p;
            }
            else
            {
                Node q = first;
                while(q.Link != null)
                {
                    q = q.Link;
                }
                q.Link = p;
            }
        }
        public void InsertAfter(int number, int newNumber, string author, string title, int year)
        {
            Node current = first;

            while (current != null && current.InventoryNumber != number)
            {
                current = current.Link;
            }

            if (current != null)
            {
                Node newNode = new Node(newNumber, author, title, year);
                newNode.Link = current.Link;
                current.Link = newNode;
            }
            else
            {
                MessageBox.Show($"Книга с номером {number} не найден");
            }
        }

        public void DeleteIn(int num)
        {
            if (!(first == null))
            {
                Node current = first;
                
                while (current.Link != null && current.Link.InventoryNumber != num)
                {
                    current = current.Link;
                }
                if (current.Link != null && current.Link.InventoryNumber == num)
                {
                    current.Link = current.Link.Link;
                }
                else if (first.InventoryNumber == num)
                {
                    first = first.Link;
                }
                else
                {
                    MessageBox.Show("Книга с таким номером не найдена");
                }
            }
            else MessageBox.Show("Библиотека пуста");
        }

        public void DeleteFirst()
        {
            if (first != null)
            {
                first = first.Link;
            }
        }

        public void DeleteLast()
        {
            if (first == null || first.Link == null)
            {
                first = null;
            }
            else
            {
                Node current = first;
                while (current.Link.Link != null)
                {
                    current = current.Link;
                }
                current.Link = null;
            }
        }

        public void DeleteAfter(int year)
        {
            while (first != null && first.Year > year)
            {
                DeleteFirst();
            }
            if (first != null)
            {
                Node current = first;
                while (current.Link != null)
                {
                    if (current.Link.Year > year)
                    {
                        current.Link = current.Link.Link;
                    }
                    else current = current.Link;
                }
            }
            
        }
        public void DeleteBefore(int year)
        {
            while (first != null && first.Year < year)
            {
                DeleteFirst();
            }
            if (first != null)
            {
                Node current = first;
                while (current.Link != null)
                {
                    if (current.Link.Year < year)
                    {
                        current.Link = current.Link.Link;
                    }
                    else current = current.Link;
                }
            }
        }

        public List<Node> GetBooks()
        {
            List<Node> books = new List<Node>();
            Node current = first;
            while (current != null)
            {
                books.Add(current);
                current = current.Link;
            }
            return books;
        }

        public bool CheckNumber(int num)
        {
            bool result = false;
            Node current = first;
            while (current != null)
            {

                if (current.InventoryNumber == num)
                {
                    MessageBox.Show("Книга с таким номером уже существует!");
                    result = true;
                    current = null;
                }
                else current = current.Link;
            }
            return result;
        }

        public void DeleteThisYear(int year)
        {
            while (first != null && first.Year == year)
            {
                DeleteFirst();
            }
            if (first != null)
            {
                Node current = first;
                while (current.Link != null)
                {
                    if (current.Link.Year == year)
                    {
                        current.Link = current.Link.Link;
                    }
                    else current = current.Link;
                }
            }    
        }
        public void Clear()
        {
            first = null;
        }
    }
}
