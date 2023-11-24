// https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-8-0
// https://www.authorcode.com/creating-a-class-library-with-c-and-net-core-in-visual-studio-code/
namespace session_02.Entities;

public class Person
{
    // Field: Private
    private int _id;
    private string _name;
    private string _family;
    private string _ssn;
    private bool _gender;
    private DateTime _birthday;

    //Property: public
    ///<summary>
    /// Personal Code
    ///</summary>
    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name 
    {
        get { return _name; }
        set { _name = value.Length > 1 ? value : "_DEFAULT_NAME";}
    }

    public string Family 
    {
        get { return _family; }
        set { _family = value.Length > 1 ? value : "_DEFAULT_FAMILY";}
    }
 
    public string SSN
    {
        get { return _ssn; }
        set 
        {
            if (value.Length == 10)
             _ssn = value;
            else
                _ssn = "0000000000" ;
        }
    }

    public DateTime BirthDay
    {
        get { return _birthday; }
        set { _birthday = value; }
    }

    //Propfull + tab + tab 
    private int _telephoneNumber;
    //XML Comment:
    /// <summary>
    /// Get the Telephone Number of the user:
    /// </summary>
    public int TelephoneNumber
    {
        get { return _telephoneNumber; }
        set { _telephoneNumber = value; }
    }



    public bool IsMarried {get; set;}
    public string MaritalStatus
    {
        get
        {
             return IsMarried ? "متاهل" : "مجرد";
        }
    }

    

    //--------------Constructor-------------------
    // It must have the same name with our class's name
    public Person()
    {
        this.ID = 1000;
        this.IsMarried = false;
        this.Name = "";
        this.Family = "";
        this.SSN = "99";
        this.TelephoneNumber = 99;
    }

}
