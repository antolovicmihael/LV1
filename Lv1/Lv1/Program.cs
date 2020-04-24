using System;

namespace Zad2i3
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
        }
    }
}
