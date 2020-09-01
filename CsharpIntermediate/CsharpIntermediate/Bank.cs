using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpIntermediate
{
    class Bank
    {

        public string[] custName = new string[3];
        public string[] custID = new string[3];
        public string[] accType = new string[3];
        public string[] myDOB = new string[3];
        public double[] myBalance = new double[3];
        public string id;// hold the id generated from idGenerator class and add string
        public int idnum = 0;// index number for account ID;
        // we will use below variables in Create_Account method
        
        public bool val = true;
        public double depositamount;
        public bool depositval = true;

        IdGenreator id1 = new IdGenreator();
        DateofBirth dob = new DateofBirth();
        Savings sa = new Savings();
        Current ca = new Current();
        
        private void GetAccount(string Id)
        {
            //id = Id;
            custID[idnum] = Id;
            idnum++;
        }

        public void CreateAccount()
        {
            int d, y, m;
            string name;
            string accTypes;
            string input;
            double balance;
            Console.WriteLine("1. Savings");
            Console.WriteLine("2. Current");
            input = Console.ReadLine();
            if(input == "1")
            {
                accTypes = "Savings";

                accType[idnum] = accTypes;

                Console.WriteLine("Enter your Name");
                name = Console.ReadLine();
                custName[idnum] = name;
                /* if users enters corrects DOB, it will take value until users enters
                 * correct date format*/
                while (val == true)
                {
                    Console.WriteLine("Enter Date of Birth");
                    d = Convert.ToInt32(Console.ReadLine());
                    m = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                    dob.AssignValue(d, m, y);
                    if (dob.displayDate() == true)
                    {
                        myDOB[idnum] = Convert.ToString($" {d} {m} {y}");
                        val = false;
                    }

                    else
                    {
                        val = true;
                    }
                }
               val = true;
                    Console.WriteLine("Enter the balance");
                    balance = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Account Created Successfully");
                myBalance[idnum] = balance;
                    id = id1.GenerateID();// collect id from id generator;
                    id = "EMI" + id;
                    Console.WriteLine($" Your Account Number is  {id}");
                GetAccount(id);

                }

            else
            {
                accTypes = "Current";
                accType[idnum] = accTypes;
                Console.WriteLine("Enter the Name");
                name = Console.ReadLine();
                custName[idnum] = name;
                custName[idnum] = name;
                /* if users enters corrects DOB, it will take value until users enters
                 * correct date format*/
                while (val == true)
                {
                    Console.WriteLine("Enter Date of Birth");
                    d = Convert.ToInt32(Console.ReadLine());
                    m = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                    dob.AssignValue(d, m, y);
                    if (dob.displayDate() == true)
                    {
                        myDOB[idnum] = Convert.ToString($" {d} {m} {y}");
                        val = false;
                    }

                    else
                    {
                        val = true;
                    }
                }

                while(depositval==true)
                {
                    Console.WriteLine("Enter the balance");
                    balance = Convert.ToDouble(Console.ReadLine());
                    if(balance < ca.minBalance)
                    {
                        Console.WriteLine("Current Account MinBalance should be 1lac");
                        depositval = true;
                    }

                    else
                    {
                        myBalance[idnum] = balance;
                        depositval = false;

                    }
                }

                Console.WriteLine("Current Account Created Successfully");
                id = id1.GenerateID();
                id = "Current" + id;
                Console.WriteLine($"Your Account id is {id}");
                GetAccount(id);



            }
           


            }

        public void ShowAccountDetails()
        {
            int indexnum;
            string accountID = Console.ReadLine();
            if(custID.Contains(accountID))
                {
                indexnum = Array.IndexOf(custID, accountID);
                Console.WriteLine($"Name is {custName[indexnum]}");
                Console.WriteLine($" ID : {custID[indexnum]}");
                Console.WriteLine($"Acc Type {accType[indexnum]}");
                Console.WriteLine($" Balance is {myBalance[indexnum]}");
                Console.WriteLine($"DOB is {myDOB[indexnum]}");

            }

            else
            {
                Console.WriteLine("Entered Incorrect Account Info");
            }
        }

        public void deposit()
        {
            int indexNum;
            string inID = Console.ReadLine();
            if(custID.Contains(inID))
            {
                indexNum = Array.IndexOf(custID, inID);
                Console.WriteLine($"Your Balance is {myBalance[indexNum]}");
                Console.WriteLine("Enter the amount you want to deposit");
                depositamount = Convert.ToDouble(Console.ReadLine());
                if(accType[indexNum]=="Savings")
                {
                    sa.balance = myBalance[indexNum];
                    sa.Deposit(depositamount);
                    myBalance[indexNum] = sa.balance;
                }


                else if(accType[indexNum]=="Current")
                {
                    ca.balance = myBalance[indexNum];
                    ca.Deposit(depositamount);
                    myBalance[indexNum] = ca.balance;
                }
                else
                {
                    Console.WriteLine("Enter Correct Account id");
                }

            }
        }
        }
    }

