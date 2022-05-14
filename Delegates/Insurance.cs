namespace ConsoleApp2
{
    public class Insurance
        {
            Patient myPat = new Patient();
            void GetDeathDetails()
            {
                //-------Do Something with the deathDate event------------//
            }
            void Main()
            {
                //--------Subscribe the function GetDeathDetails----------//
                myPat.deathDate += GetDeathDetails;
            }
        }
    }