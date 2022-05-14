namespace ConsoleApp2
{
    public class Patient
        {
            public delegate void deathInfo(); //Declaring a Delegate//
            public event deathInfo deathDate; //Declaring the event//
            public void Death()
            {
                deathDate();
            }
        }
    }