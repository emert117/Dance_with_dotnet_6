namespace ConsoleApp2
{
    public class Bank
        {
            Patient myPat = new Patient();
            void GetPatInfo()
            {
                //-------Do Something with the deathDate event------------//
            }
            void Main()
            {
                //--------Subscribe the function GetPatInfo ----------//
                myPat.deathDate += GetPatInfo;
            }
        }
    }