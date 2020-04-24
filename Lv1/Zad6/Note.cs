using System;
using System.Collections.Generic;
using System.Text;

namespace Zad6
{
    class Note
    {
        public String text;
        private String author;
        private int NoteImportance;

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public int Importance
        {
            get { return this.NoteImportance; }
            set { this.NoteImportance = value; }
        }
        public string getText() { return this.text; }
        public string getAuthor() { return this.author; }
        public int getImportance() { return this.NoteImportance; }
        public void setText(string text) { this.text = text; }
        public void setImportance(int importance) { this.NoteImportance = importance; }
        
        public Note()
        {
            this.text = string.Empty;
            this.author = string.Empty;
            this.NoteImportance = 0;
        }
        public Note(string text, string author,int importance)
        {
            this.text = text;
            this.author = author;
            this.NoteImportance = importance;
        }
        public Note(string text, string author)
        {
            this.text = text;
            this.author = author;
        }
        public override string ToString()
        {
            return this.text + this.author+ this.NoteImportance;
        }
    }
}
