namespace Types
{
    class Cat // CLASS !!!
    {
        string name = "Barsik";
        int paws = 4;

        public override string ToString()
        {
            return "Cat nick: " + name + ", it has " + paws + " paws";
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPaws(int paws)
        {
            this.paws = paws;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPaws()
        {
            return paws;
        }

        public Cat(string name, int paws)
        {
            SetName(name);
            SetPaws(paws);
        }
    }

    class Program
    {
        static void AnotherFunction(in Cat cat)
        {
            // cat = new Cat("Barsik", 4); // якщо треба заборонити запис нових в параметр-покажчик, то можна позначити параметр як іn
            // але нажаль оцей іn ніяк не забороняє змінювати ОБ'ЄКТ через цей покажчик (в сам покажчик нічого не можна записати)
            cat.SetPaws(5); // через покажчик (посилання) ЗМІНЮЄТЬСЯ ОРИГІНАЛ ОБ'ЄКТА без всяких рефів
            cat.SetName("Alex");
        }

        static void Main()
        {
            Cat c = new Cat("Barsik", 4);
            // так як тип Кіт - це знову клас, то буде дві сутності, нью зробить об'єкт, поверне його адресу, адреса пишеться В ПОСИЛАННЯ (покажчик)
            Console.WriteLine(c); // Barsik 4
            AnotherFunction(c); // ПЕРЕДАЄТЬСЯ ПОСИЛАННЯ на об'єкт класа (АДРЕСА) - в С++ це б назвали передача покажчика
            Console.WriteLine(c); // оригінал уже було змінено в методі, тому всі зміни збережуться
        }
    }
}