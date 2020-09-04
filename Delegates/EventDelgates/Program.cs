using System;

namespace EventDelgates
{
    public class CheckVotingAge
    {
        public delegate void VotingElligibilty();
        public event VotingElligibilty EventDelegate;
        public void CheckVotingElligibilty(int age)
        {
            if(age>=18)
            {
                Console.WriteLine("Congratss !! you can vote");
            }

            else
            {
                EventDelegate();
            }
        }
    }
    class Program
    {
        public static void Message()
        {
            Console.WriteLine("Sorry you cannot vote!!!");
        }
        static void Main(string[] args)
        {
            CheckVotingAge check = new CheckVotingAge();
            check.EventDelegate += Message;
            check.CheckVotingElligibilty(12);
            Console.ReadLine();
        }
    }
}
