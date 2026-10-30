
class User
{
    private string name;
    private string surname;
    private int age;
    private string email;
    private string password;
    private string phoneNumber;
    private string address;
    private string personalNumber;
    private decimal balance;
    private DateTime birthDate;

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2)
                name = value;
            else
                throw new ArgumentException("Name must contain at least 2 characters.");
        }
    }

    public string Surname
    {
        get { return surname; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2)
                surname = value;
            else
                throw new ArgumentException("Surname must contain at least 2 characters.");
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 18 && value <= 100)
                age = value;
            else
                throw new ArgumentException("Age must be between 18 and 100.");
        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) &&
                value.Contains("@") && value.Contains("."))
                email = value;
            else
                throw new ArgumentException("Invalid email address.");
        }
    }

    public string Password
    {
        get { return password; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length >= 8)
                password = value;
            else
                throw new ArgumentException("Password must contain at least 8 characters.");
        }
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length == 9)
                phoneNumber = value;
            else
                throw new ArgumentException("Phone number must contain exactly 9 characters.");
        }
    }

    public string Address
    {
        get { return address; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                address = value;
            else
                throw new ArgumentException("Address cannot be empty.");
        }
    }

    public string PersonalNumber
    {
        get { return personalNumber; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length == 11)
                personalNumber = value;
            else
                throw new ArgumentException("Personal number must contain exactly 11 characters.");
        }
    }

    public decimal Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
                balance = value;
            else
                throw new ArgumentException("Balance cannot be negative.");
        }
    }

    public DateTime BirthDate
    {
        get { return birthDate; }
        set
        {
            if (value < DateTime.Now)
                birthDate = value;
            else
                throw new ArgumentException("Birth date cannot be in the future.");
        }
    }
}