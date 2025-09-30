namespace PROG6212.Models;

public class Claim
{
    public string Id { get; set; }
    public string LectureName { get; set; }
    public string LectureSurname { get; set; }
    public string SubjectName { get; set; }
    public string LecturerEmail { get; set; }
    public int SubjectCode { get; set; }
    public string CampusLocation { get; set; }
    public int HoursWorked { get; set; }
    public string Message { get; set; }
}