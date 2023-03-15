using System;

class main
{
    static void Main()
    {
        int num = 0;
        while (num <= 3)
        {
            Console.WriteLine("\n1.Print cubes");
            Console.WriteLine("2.Print Table");
            Console.WriteLine("3.Vote eligibility");
            Console.WriteLine("4.Admission eligibility");
            Console.WriteLine("Give your choice");
            int chooseProgram = int.Parse(Console.ReadLine());



            switch (chooseProgram)
            {
                case 1:
                    printCubes();
                    break;
                case 2:
                    printTable();
                    break;
                case 3:
                    eligible();
                    break;
                case 4:
                    addmissionEligible();
                    break;
                default:
                    Console.WriteLine("Please choose an option");
                    break;





            }
        }

    
                
    }

    static void printCubes()
    {
        Console.WriteLine("Give the range for generating cubes");
        cubes c = new cubes(int.Parse(Console.ReadLine()));
        c.generateCube();
    }

    static void printTable()
    {
        Console.WriteLine("\nGive the range for generating table");
        int range=int.Parse(Console.ReadLine());
        Console.WriteLine("print table of(Give the number)");
        int tab=int.Parse(Console.ReadLine());
        multipleTable table = new multipleTable(tab, range);
        table.generateTable();

    }
    static void eligible()
    {
        Console.WriteLine("\nGive your age");

        checkEligibility check = new checkEligibility(int.Parse(Console.ReadLine()));
        check.isEligible();
    }

    static void addmissionEligible()
    {
        Console.Write("\nGive maths marks:");
        int maths = int.Parse(Console.ReadLine());

        Console.Write("\nGive physics marks:");
        int physics= int.Parse(Console.ReadLine());


        Console.Write("\nGive chemistry marks:");
        int chemistry = int.Parse(Console.ReadLine());
        addmissionEligibility check= new addmissionEligibility(maths, chemistry, physics);
        check.isEligibleForAdmission();
    }
}

public class cubes
{
    int num = 0;
    int range;
   public cubes(int r)
    {
        range = r;
    }
        
     public void generateCube()
    {
        while (num <= range)
        {
            Console.Write(num * num * num + " ");
            num++;
        }
    }
     
}
public class multipleTable{
    int tableof;
    int range;
    int multiples = 0;
    
   public multipleTable(int tableof,int range) { 
     this.tableof = tableof;
     this.range = range;
    }
    public void generateTable()
    {
        while (multiples <= range)
        {
            int multiplevalue = tableof * multiples;
            Console.WriteLine("{0} X {1} = {2}", tableof, multiples, multiplevalue);
            multiples++;           
        }
    }
  
}

public class checkEligibility {

    int age;
    public checkEligibility(int age)
    {
        this.age = age;
    }
    public void isEligible()
    {
        if (age < 18)
        {
            Console.WriteLine("Yor are not eligible for vote");
        }
        else { 
            Console.WriteLine("Yor are eligible for vote");

        }
    }

}

public class addmissionEligibility {

    int maths = 0;
    int physics = 0;
    int chemistry= 0;
    int totalmarks = 0;
    
    public addmissionEligibility(int maths,int chemistry, int physics)
    {
        this.maths = maths;
        this.chemistry = chemistry;
        this.physics = physics;
    }
    public void isEligibleForAdmission()
    {
        totalmarks=maths+chemistry+physics;
        if ((maths >= 65 && physics >= 55 && chemistry >= 50 && totalmarks>=180))
        {
            Console.WriteLine("You are eligible to take the course");

        }
        else
        {
            Console.WriteLine("You are not eligible to take the course");

        }
    }


}

