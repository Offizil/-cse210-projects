// Activity.cs
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        
    }


    public Activity()
    {
        _name = "Anonymous";
        _description = "";
        _duration = 0;
    }



    public void DisplayStartMessage()
    {

    }

     public void DisplayEndingMessage()
     {

     }

     public void ShowSpinner( int seconds)
    {

    }

     public void ShowCountDown(int seconds)
     {

     }







}