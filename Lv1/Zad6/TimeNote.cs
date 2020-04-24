using System;
using System.Collections.Generic;
using System.Text;

namespace Zad6
{
    class TimeNote : Note
    {
        DateTime NoteTime;
        public TimeNote() : base()
        {
            this.NoteTime = DateTime.Now;

        }
        public TimeNote(string text, string author, int importance) : base(text, author, importance)
        {
            this.NoteTime = DateTime.Now;
        }
        public override string ToString()
        {
            return base.ToString() + NoteTime.ToString();
        }
    }
}
