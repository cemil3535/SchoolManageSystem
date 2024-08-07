// See https://aka.ms/new-console-template for more information

public class Person
{
    // Identification of features
    private string name;
    private string surname;
    private DateTime birthday;

    // Identification of public
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public string Surname
    {
        get
        {
            return surname;
        }
        set
        {
            surname = value;
        }
    }

    public DateTime Birthday
    {
        get
        {
            return birthday;
        }
        set
        {
            birthday = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create two student object
        Person student1 = new Person
        {
            Name = "Mehmet",
            Surname = "Oztan",
            Birthday = new DateTime(2002, 10, 11)
        };

        Person student2 = new Person
        {
            Name = "Ayse",
            Surname = "Tan",
            Birthday = new DateTime(2000, 08, 09)
        };
        // Create two teacher object
        Person teacher1 = new Person
        {
            Name = "Nehir",
            Surname = "Guzel",
            Birthday = new DateTime(1999, 10, 11)
        };

        Person teacher2 = new Person
        {
            Name = "Hasan",
            Surname = "Ay",
            Birthday = new DateTime(2005, 04, 01)
        };

        // Print the information to the console
        Console.WriteLine("Ogrenciler:");
        Console.WriteLine($"Adi ve Soyadi: {student1.Name} {student1.Surname}, Dogum Tarihi: {student1.Birthday.ToShortDateString()} ");
        Console.WriteLine($"Adi ve Soyadi: {student2.Name} {student2.Surname}, Dogum Tarihi: {student2.Birthday.ToShortDateString()} ");
        Console.WriteLine("\nOgretmenler:");
        Console.WriteLine($"Adi ve Soyadi: {teacher1.Name} {teacher1.Surname}, Dogum Tarihi: {teacher1.Birthday.ToShortDateString()} ");
        Console.WriteLine($"Adi ve Soyadi: {teacher2.Name} {teacher2.Surname}, Dogum Tarihi: {teacher2.Birthday.ToShortDateString()} ");




    }
}
