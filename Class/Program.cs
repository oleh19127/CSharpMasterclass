var rectangle1 = new Rectangle(5, 10);
var calculator = new ShapesMeasurementsCalculator();
Console.WriteLine($"Width is {rectangle1.Width}");
Console.WriteLine($"Height is {rectangle1.Height}");
Console.WriteLine($"Area is {calculator.CalculateRectangleArea(rectangle1)}");
Console.WriteLine($"Circumference is {calculator.CalculateRectangleCircumference(rectangle1)}");

var rectangle2 = new Rectangle(2, 3);


Console.WriteLine($"Width is {rectangle2.Width}");
Console.WriteLine($"Height is {rectangle2.Height}");
Console.WriteLine($"Area is {calculator.CalculateRectangleArea(rectangle2)}");
Console.WriteLine($"Circumference is {calculator.CalculateRectangleCircumference(rectangle2)}");

var medicalAppointment = new MedicalAppointment("Oleh Husak", new DateTime(2023, 2, 10));

// overwrite month and day
medicalAppointment.Reschedule(new DateTime(2026, 18, 02));

// add a given number of month and days
medicalAppointment.OverwriteMonthAndDay(1, 2);

class Rectangle
{
    // public - naming start from uppercase, for example Width, Height
    // private - naming start from _, for example _width, _height
    public int Width;
    public int Height;

    // constructor
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;

    }


}

class ShapesMeasurementsCalculator
{
    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.Height;

    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;

}

class HotelBooking
{
    public string GuestName;
    public DateTime StartDate;
    public DateTime EndDate;
    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        EndDate = StartDate.AddDays(lengthOfStayInDays);
    }
}

public class Triangle
{
    private int _base;
    private int _height;

    public Triangle(int @base, int height)
    {
        _base = @base;
        _height = height;
    }

    public int CalculateArea()
    {
        return _base * _height / 2;
    }

    public string AsString()
    {
        return $"Base is {_base}, height is {_height}";
    }
}

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine($"Appointment will take place on {medicalAppointment.GetDate()}");
    }
}

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public DateTime GetDate() => _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    // public MedicalAppointment(string patientName) : this(patientName, 7)
    // {

    // }
    public MedicalAppointment(string patientName)
    {
        _patientName = patientName;
    }
    public MedicalAppointment(string patientName = "Unknown", int daysFromNow = 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }
    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }
    public void MoveByMonthsAndDays(int monthToAdd, int daysToAdd)
    {
        _date = new DateTime(_date.Year, _date.Month + monthToAdd, _date.Day + daysToAdd);
    }
}


class Dog
{
    private string _name;
    private string _breed;
    private int _weight;

    public Dog(string name, string breed, int weight)
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }

    public Dog(string name, int weight)
    {
        _name = name;
        _breed = "mixed-breed";
        _weight = weight;
    }

    public string Describe()
    {
        string dogWeightAsText;
        switch (_weight)
        {
            case < 5:
                dogWeightAsText = "tiny";
                break;
            case >= 5 and < 30:
                dogWeightAsText = "medium";
                break;
            default:
                dogWeightAsText = "large";
                break;
        }
        return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {dogWeightAsText} dog.";
    }
}
