using System;

//Sub-class of Avtivity
public class BreathingActivity : Activity
{
    //No attributes to establish

    //Constructor method (base activity is name, description)
    public BreathingActivity()
        : base("Breathing Activity",
        "This activity will help you realx by walking you through breathing" +
        "in and out slowly. Clear your mind and focus on your breathing.")
    {
        //...
    }

    //Method to run actual activity
    public void Run()
    {
        //Display start message from Activity
        DisplayStart();
        //Get duration from user
        int duration = GetUserDuration();


        //ADD LOOP FOR ALTERNATING BETWEEN BREATHING


        //Display end message from Activity
        DisplayEnd();
    }
}