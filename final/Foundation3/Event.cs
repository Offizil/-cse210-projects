// Event.cs

public class Event
{

    private string _title;
    private string _description;
    private string _date;
    private DateTime _time;
    private Address _address;

public Event(string title, string desc, string date, DateTime time, Address address)
{
    _title = title;
    _description = desc; 
    _address = address;
    _time = time;
    _date = date;
  
}

public string GetStandardDetails()
{
    return $"{_title} \n{_description} \n{_date} \n{_time} \n{_address} ";
}

public string GetFullDetails()
{
    return $"{_title} \n{_description} \n{_date} \n{_time} \n{_address} ";
    // yet to add the remaining attributes like type of event and specifiic info
}












}