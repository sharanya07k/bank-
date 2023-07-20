using System;
 public class AccountNonotFound : Exception
{

    public override string Message
    {
        get
        {
            return "Account no not found";
        }
    }
}
   public class empl
   {
      public  void   displayinfo ()
    {

    }
     public void GetBranchinfo()
    {

    }
     public virtual void Empdata()
    {

    }

   }


public class ATM : empl
{
    int empid;
    string empname;

    public void calculate()
    {
        int a = 10;
        int b = 20;
        int c=0 ;
        try
        {

            c = a / b;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Exception raised " + e);

        }
        catch (NullReferenceException e1)
        {
            Console.WriteLine("Exception raised " + e1);

        }
        catch (Exception e2)
        {
            Console.WriteLine("Exception raised " + e2);

        }
        finally
        {
            Console.WriteLine("My value is " + c);
        }

    }
    //public void calculate(int m,int n)
    //{
    //    int m = 10;
    //    int n = 20;
    //    int v;

    //    v = m * n;

    //}

    public override void Empdata()
    {
        Console.WriteLine("enter employee details");

        empid = Convert.ToInt32(Console.ReadLine());
        empname = Console.ReadLine();
        base.Empdata();

    }


}

class bank1
{
    public static void Main(string[] args)
    {


        String accountNo;
        Console.WriteLine("pls enter account No");
        accountNo = Console.ReadLine();
        try
        {
            if (accountNo == "10001")
            {
                throw new AccountNonotFound();
            }
            Console.WriteLine("Your account no is " + accountNo);
        }
        catch (AccountNonotFound g)
        {
            Console.WriteLine("Account no does not exist" + g);

        }

        ATM a = new ATM();
        a.calculate();
        empl e = new empl();
        e.Empdata();
        e.GetBranchinfo();
        e.displayinfo();
    }
}
    



