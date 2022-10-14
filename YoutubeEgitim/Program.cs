using System;

namespace YoutubeEgitim
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager());
            customerManager.GiveCredit();



            Console.ReadLine();
        }
    }
    class CreditManager
    {
        public void Calculate(int creditType)
        {
            if (creditType == 1) //esnaf
            {

            } 
            if (creditType == 2)  // Ogretmen
            {

            }
            Console.WriteLine("Hesaplandı.");
        }
        public void Save()
        {
            Console.WriteLine("Kredi Verildi.");
        }
    }

    interface ICreditManager
    {
        void Calculate();
        public void Save();
    }

    abstract class BaseCreditManager : ICreditManager
    {
        public abstract void Calculate();
        

        public virtual void Save()
        {
            Console.WriteLine("Asker Kredisi Hesaplandı.");
        }
    }

    class TeacherCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Öğretmen Kredisi Hesaplandı.");
        }

        public virtual void Save()
        {
            base.Save();
        }
    }

    class MilitaryCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Asker Kredisi Hesaplandı.");
        }

    }

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("müşteri nesnesi başlatıldı.");
        }
        public int Id { get; set; }
        public string City { get; set; }

        


    }
    
    class Person : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
    }

    class Company : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
    class CustomerManager
    {
        private Customer _customer;
        private ICreditManager _creditManager;
        public CustomerManager(Customer customer, ICreditManager creditManager)
        {
            _customer = customer;
            _creditManager = creditManager;
        }
        public void Save()
        {
            Console.WriteLine("Müşteri Kaydedildi : ");
        }

        public void Delete()
        {
            Console.WriteLine("Müşteri Silindi : " );
        }
        public void GiveCredit()
        {
            _creditManager.Calculate();
            Console.WriteLine("Kredi Verildi.");
        }
    }
}

