using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Note_Organizer.Form1;

namespace Note_Organizer
{
    public partial class Form1 : Form
    {

        public class Note
        {
            public int ID { get; set; }
            public string Text { get; set; }
        }

        private List<Note> notes = new List<Note>();
        private string filename = "notes.txt";
        private int id = 0;
        private bool darkMode = false;

        public Form1()
        {
            InitializeComponent();
            LoadNotes();
        }

        private void LoadNotes()
        {
            if(File.Exists(filename)) {
                using (StreamReader sr  = new StreamReader(filename))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        if(line.Length == 2)
                        {
                            int NoteId = int.Parse(line[0]);
                            string text = line[1];
                            notes.Add(new Note { ID = NoteId, Text = text });
                            listBox1.Items.Add(text);
                        }
                    }
                    if (notes.Count >= 0) id = notes.Count;
                    else id = 0;
                }
            }   
        }
        private void SaveNotes()
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (Note note in notes)
                {
                    sw.WriteLine($"{note.ID},{note.Text}");
                }
            }
        }
        private void AddButton(object sender, EventArgs e)//AddButton
        {
            string note = textBox1.Text;
            if(!string.IsNullOrEmpty(note) ) {
                Note obj = new Note { ID = id, Text = note };
                notes.Add(obj);
                listBox1.Items.Add(obj.Text);
                textBox1.Clear();
                id++;
                SaveNotes();
            }
        }

        private void DeleteButton(object sender, EventArgs e)//DeleteButton
        {
            int idForDelete = int.Parse(idBox.Text);
            if(idForDelete >= 0 && idForDelete <= notes.Count) {
                Note noteForDelete = notes.Find(note =>  note.ID == idForDelete);
                if(noteForDelete != null)
                {
                    notes.Remove(noteForDelete);
                    listBox1.Items.Remove(noteForDelete);
                    listBox1.Items.Clear();
                    foreach (Note nota in notes)
                    {
                        if (nota.ID > idForDelete)
                        {
                            nota.ID--;
                        }
                    }
                    if (notes.Count >= 0) id = notes.Count;
                    else id = 0;
                    foreach (Note note in notes)
                    {
                        listBox1.Items.Add(note.Text);
                    }
                }
            }
            SaveNotes();
            idBox.Clear();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int idForEdit = int.Parse(idBoxE.Text);
            if (idForEdit >= 0 && idForEdit <= notes.Count)
            {
                Note noteForEdit = notes.Find(note => note.ID == idForEdit);
                if (noteForEdit != null)
                {
                    noteForEdit.Text = txtE.Text;
                    notes.Remove(noteForEdit); 
                    notes.Add(noteForEdit);
                    listBox1.Items.Remove(noteForEdit);
                    listBox1.Items.Add(noteForEdit.Text);
                    listBox1.Items.Clear();
                    foreach (Note note in notes)
                    {
                        listBox1.Items.Add(note.Text);
                    }
                }
            }
            SaveNotes();
            idBoxE.Clear();
            txtE.Clear();
        }

        private void ChangeTheme_Click(object sender, EventArgs e)
        {
            if (!darkMode)
            {
                darkMode = true;
                this.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A");
                this.ForeColor = Color.Black;

                ChangeTheme.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B3B3B");
                ChangeTheme.ForeColor = Color.White;

                editButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B3B3B");
                editButton.ForeColor = Color.White;

                button2.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B3B3B");
                button2.ForeColor = Color.White;

                addButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B3B3B");
                addButton.ForeColor = Color.White;

                listBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B3B3B");
                listBox1.ForeColor = Color.White;

                textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B3B3B");
                textBox3.ForeColor = Color.White;

                textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B3B3B");
                textBox2.ForeColor = Color.White;

                textBox5.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B3B3B");
                textBox5.ForeColor = Color.White;

                textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B3B3B");
                textBox1.ForeColor = Color.White;

                idBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B3B3B");
                idBox.ForeColor = Color.White;

                idBoxE.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B3B3B");
                idBoxE.ForeColor = Color.White;

                txtE.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B3B3B");
                txtE.ForeColor = Color.White;
            }
            else
            {
                darkMode = false;
                this.BackColor = Color.White;
                this.ForeColor = Color.White;

                ChangeTheme.BackColor = Color.White;
                ChangeTheme.ForeColor = Color.Black;

                editButton.BackColor = Color.White;
                editButton.ForeColor = Color.Black;

                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;

                addButton.BackColor = Color.White;
                addButton.ForeColor = Color.Black;

                listBox1.BackColor = Color.White;
                listBox1.ForeColor = Color.Black;

                textBox3.BackColor = Color.White;
                textBox3.ForeColor = Color.Black;

                textBox2.BackColor = Color.White;
                textBox2.ForeColor = Color.Black;

                textBox5.BackColor = Color.White;
                textBox5.ForeColor = Color.Black;

                textBox1.BackColor = Color.White;
                textBox1.ForeColor = Color.Black;

                idBox.BackColor = Color.White;
                idBox.ForeColor = Color.Black;

                idBoxE.BackColor = Color.White;
                idBoxE.ForeColor = Color.Black;

                txtE.BackColor = Color.White;
                txtE.ForeColor = Color.Black;
            }
        }
    }
}
