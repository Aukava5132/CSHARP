namespace Lab10;

public class Student
{
    public string FullName { get; set; }
    public string GroupNumber { get; set; }
    public int[] Grades { get; set; } = new int[5];

    public double AverageGrade()
    {
        double sum = 0;
        foreach (var grade in Grades)
            sum += grade;
        return sum / Grades.Length;
    }

    public override string ToString()
    {
        return $"ПІБ: {FullName}\nГрупа: {GroupNumber}\n" +
               $"Успішність: {string.Join(", ", Grades)}\nСередній бал: {AverageGrade():F2}";
    }
}