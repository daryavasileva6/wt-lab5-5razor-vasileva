using wt_lab5_5razor_vasileva.Models;

namespace wt_lab5_5razor_vasileva.Data;

public static class StudentStore
{
    public static List<Student> Students { get; } = new()
    {
        new Student { Id = 1, FullName = "Иванов Иван Иванович",     Group = "ПИ-21", AverageGrade = 4.5, EnrollmentYear = 2021, Email = "ivanov@univ.ru" },
        new Student { Id = 2, FullName = "Петрова Анна Сергеевна",   Group = "ПИ-21", AverageGrade = 4.8, EnrollmentYear = 2021, Email = "petrova@univ.ru" },
        new Student { Id = 3, FullName = "Смирнов Дмитрий Олегович", Group = "ПИ-22", AverageGrade = 4.2, EnrollmentYear = 2022, Email = "smirnov@univ.ru" },
        new Student { Id = 4, FullName = "Кузнецова Мария Игоревна", Group = "ПИ-22", AverageGrade = 4.9, EnrollmentYear = 2022, Email = "kuznetsova@univ.ru" },
        new Student { Id = 5, FullName = "Попов Артём Владимирович", Group = "ПИ-23", AverageGrade = 3.8, EnrollmentYear = 2023, Email = "popov@univ.ru" }
    };
}