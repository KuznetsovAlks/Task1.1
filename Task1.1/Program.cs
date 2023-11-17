namespace Task1._1
{
    internal class Program
    {
        static void Main ()
        {
            var outputData = new StudentList()
        {
            new Student("Вернадский Петр Филимонович", 14, "Vern2012@mail.ru", 3.2f, 4.3f, 3.7f),
            new Student("Сухлинов Антон Анатольевич", 15, "Suhoi234@mail.ru", 2.9f, 4.2f, 4.3f),
            new Student("Лаврова Олеся Ивановна", 14, "LoverBober567@mail.ru", 4.6f, 3.2f, 4.3f),
        };

            Console.WriteLine(outputData.ToString());
        }
    };
        }
internal record Student(string fullName, int age, string email, float progScore, float mathScore, float physScore)
{
    public override string ToString() =>
        string.Join("\t", fullName, age, email, progScore, mathScore, physScore);
}
internal class StudentList : List<Student>
{
    public override string ToString() =>
        string.Join("\n", this.Select(x => x.ToString()));
}