namespace Models;

public class Student
{
    public int Number { get; set; }
    public string? PictureUrl { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FatherName { get; set; }
    public DateTime? LastIn { get; set; }
    public string? Comment { get; set; }



    public Student(int number, string? pictureUrl, string? firstName, string? lastName, string? fatherName, DateTime? lastIn, string? comment)
    {
        Number = number;
        PictureUrl = pictureUrl;
        FirstName = firstName;
        LastName = lastName;
        FatherName = fatherName;
        LastIn = lastIn;
        Comment = comment;
    }


    public string? FullName() => $"{FirstName} {LastName} {FatherName}";
}


