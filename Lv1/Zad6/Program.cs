using System;

namespace Zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note = new Note();
            Note note1 = new Note("Note", "Mihael", 1);
            Note note2 = new Note("Note2", "Miho");
            note2.setImportance(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(note.ToString());
            Console.WriteLine(note1.ToString());
            Console.WriteLine(note2.ToString());
            Console.WriteLine(note.Author);
            Console.WriteLine(note.Importance);
            Console.WriteLine(note.Text);
            Console.WriteLine(note1.Author);
            Console.WriteLine(note1.Importance);
            Console.WriteLine(note1.Text);
            Console.WriteLine(note2.Author);
            Console.WriteLine(note2.Importance);
            Console.WriteLine(note2.Text);
            Note time = new TimeNote();
            Console.WriteLine(time.ToString());
        }
    }
}
