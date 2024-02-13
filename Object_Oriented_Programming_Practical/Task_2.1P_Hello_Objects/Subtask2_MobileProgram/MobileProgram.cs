using System;

namespace helloObjects
{
    class MobileProgram 
    {
        static void Main(string[] args)
        {
            Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6","07771222334" );
            Console.WriteLine("Account Type:" + jimMobile.getaccType() +"\nMobbile Number: " + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance: " + jimMobile.getBalance());
            
            jimMobile.setBalance(15.50);
            jimMobile.setDevice("IPhoe 6S+");
            jimMobile.setAccType("PAYG");
            jimMobile.setNumber("0771334466");

            Console.WriteLine("Account Type:" + jimMobile.getaccType() +"\nMobbile Number: " + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance: " + jimMobile.getBalance());

            jimMobile.addCredit(10.0);
            jimMobile.makeCall(5);
            jimMobile.sendText(2);

            Mobile georgeMobile = new Mobile("Monthly", "Samsung Galaxy S6","07771222334");
            georgeMobile.setBalance(15.50);
            georgeMobile.setDevice("Pixel 3");
            georgeMobile.setAccType("PAYG");
            georgeMobile.setNumber("0453224466");

             Console.WriteLine("Account Type:" + georgeMobile.getaccType() +"\nMobbile Number: " + georgeMobile.getNumber() + "\nDevice: " + georgeMobile.getDevice() + "\nBalance: " + georgeMobile.getBalance());

            georgeMobile.addCredit(33.0);
            georgeMobile.makeCall(3);
            georgeMobile.sendText(2);
            georgeMobile.sendText(4);

            Console.WriteLine("Account Type:" + georgeMobile.getaccType() +"\nMobbile Number: " + georgeMobile.getNumber() + "\nDevice: " + georgeMobile.getDevice() + "\nBalance: " + georgeMobile.getBalance());

            Console.ReadLine();
        }
    
        
        
    }

    
}