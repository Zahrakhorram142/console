using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ShowMessage("please Enter Your Firstname:");
            string firstName = ReadValidInput();
            ShowMessage("Please Enter Your Lastname:");
            string lastName = ReadValidInput();
            ShowMessage("Please Enter Your Fathername:");
            string fatherName = ReadValidInput();
            ShowMessage("Please Enter Your Phonenumber:");
            string phone = ReadValidPhone();
            string phoneNumber = ReaplacePhone(phone);
            ShowMessage("Please Enter Your Year Of Bearth:");
            int age = ReadValidAge();
            ShowMessage("Please Choose Your Gender:(1_male   2_femail)");
            int gender = ReadInputGender(age);
            ShowMessage("Please Choose?(1:Dtail,2:Summary)");
            ReadInputSummeryOrDtail(firstName, lastName, fatherName, phoneNumber, age, gender);
        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        static string ReadValidInput()
        {

            string x;
            do
            {
                x = Console.ReadLine();
                bool isXValid = true;
                if (isXValid)
                {
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (!char.IsLetter(x[i]))
                        {
                            isXValid = false;
                            break;
                        }
                    }
                }

                if (!isXValid)
                {
                    ShowMessage("Invalid Input Please Try Again:");

                }
                if (isXValid)
                {

                    break;
                }


            }
            while (true);
            return x;
        }
        static string ReadValidPhone()
        {
            string phone;
            do
            {
                phone = Console.ReadLine();
                bool isPhoneValid = phone.Length == 10 || phone.Length == 11 || phone.Length == 13;
                if (isPhoneValid)
                {

                    for (int i = 0; i < phone.Length; i++)
                    {
                        if (!char.IsDigit(phone[i]))
                        {
                            if (phone[0] == '+' && phone.Length == 10)
                            {
                                if (!(phone[i] == '+' && i == 0))
                                {

                                    isPhoneValid = false;

                                    break;

                                }
                            }
                        }
                    }
                }
                if (!isPhoneValid)
                {
                    ShowMessage("Invalid Phone Please Try Again:");


                }
                if (isPhoneValid)

                {
                    break;

                }


            } while (true);
            return phone;

        }
        static string ReaplacePhone(string phone)
        {
            if (phone.Substring(0, 3) == "+98")
            {
                phone = phone.Replace("+98", "0");
                ShowMessage($"Your Phonenumber Is:{phone}");
            }
            if (phone[0] != '0' && phone[0] != '+')
            {
                phone = "0" + phone;
                ShowMessage($"Your Phonenumber Is:{phone}");
            }
            return phone;

        }
        static int ReadValidAge()
        {
            int age;

            do
            {
                age = int.Parse(Console.ReadLine());
                bool isagevalid = age > 1300 && age < 1402;
                {
                    if (isagevalid)
                    {
                        if (age < 1300 && age > 1402)
                        {
                            isagevalid = false;
                            break;
                        }
                    }
                }
                if (!isagevalid)
                {
                    ShowMessage("Invalid Age Please Try Again");
                }
                if (isagevalid)
                {
                    age = 1402 - age;
                    ShowMessage($"Your Age Is:{age}");
                    break;
                }


            } while (true);
            {
                return age;

            }
        }
        static int ReadInputGender(int age)
        {
            int male = 1; int female = 2;
            int gender = int.Parse(Console.ReadLine());
            bool mustGoToMilitaryService = age > 18 && age < 50 && gender == 1;
            if (mustGoToMilitaryService)
            {
                ShowMessage("Must Go To Military service");
            }

            return gender;
        }
        static void ReadInputSummeryOrDtail(string firstName, string lastName, string fatherName, string phone, int age, int gender)
        {
            int dtail = 1; int summery = 2;
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                ShowMessage($"Firstname:{firstName}, Lastname:{lastName},Fathername:{fatherName},Phonenumber:{phone},Age:{age},Gender:{gender}");
            }
            else
            {
                ShowMessage($"Firstname:{firstName}, Lastname:{lastName}");
            }


        }

    }
}


