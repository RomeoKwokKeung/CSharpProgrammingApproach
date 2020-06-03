using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms; //needed to use MessageBox.Show

namespace FirstOOPdemo
{
    class Car
    {
        
        //fields 
        //usually declared private only known to this class
        private string make;
        private int year;

        //constructor
        //a special method that lets to initialize
        //your fields
        public Car()
        {
                   
        }
        
        //this is called overloading same constructor
        //name with different parameters
        public Car(string m, int y)
        {
            make = m;
            year = y;
        }


        //properties
        //this how the outside forms get access 
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        //methods
        public void Display()
        {
            MessageBox.Show("car make is " + make + " year " + year);
            
        }

        //static method does not require object instantiation
        public static void OtherDisplay()
        {
            MessageBox.Show("This display did not initially have to be instantiated");
        }

    }

    //This is called inheritance
    
    //class MiniVan : Car
    //{

    //  private int passengers;
        //fields above (make,year) need to be changed to protected 
        //when using inheritance
        
    //  public MiniVan()
    //  {

    //  }

    //  public int Passengers
    //  {
    //      get { return passengers; }
    //      set { passengers = value; }
    //  }

        //needed if two methods have same name when using inheritance
    //  public new void Display()
    //  {
    //      MessageBox.Show("car make is " + make + " year " + year + " can hold " + passengers + " passengers");

    //  }
    //}
   
}
