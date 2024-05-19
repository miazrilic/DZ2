using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_PREIMENOVANJE
{
    internal class zad4preim
    {
        class Note
        {

            public string Title { get; set; }
            public string Text { get; set; }
            public DateTime DateOfCreation { get; private set; }

            public Note(string title, string text)
            {
                Title = title;
                Text = text;
                DateOfCreation = DateTime.Now;
            }

        }
        class Notebook
        {

            public string Author { get; private set; }
            public List<Note> notebook;

            public Notebook(string author)
            {
                Author = author;
                notebook = new List<Note>();
            }

            public void AddNote(Note note)
            {
                notebook.Add(note);
            }

        }
    }
}
