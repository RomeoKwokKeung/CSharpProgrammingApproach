// Employee.cs          Author: Doyle          Updater: Romeo
// Employee class includes data characteristics of
// name, number of dependents, number of hours worked
// deductions for social security, federal tax, and agency fee
// Methods to calculate gross, net and deductions
using System;
namespace PayRollApp
{
    public class Employee
    {
        private const double RATE = 150.00d;
        private const double FEDERAL_TAX = 0.25d;
        private const double SOCIAL_SECURITY_RATE = 0.0785d;
        private const double DEPENDENT_ALLOWANCE = 0.0575d;
        private const double AGENCY_CHARGE = 0.13d;

        private string employeeName;
        private int noOfDependents;
        private double noOfHours;
        private double socialSecurity;
        private double federalTax;
        private double agencyFee;
        private double gross;
        private double net;


        //Default constructor	
        public Employee()
        {

        }

        //Constructor - when the object is created, calculate values
        //for private member data items.
        public Employee(string name, double hours, int dep)
        {
            employeeName = name;
            noOfHours = hours;
            noOfDependents = dep;
            DetermineGross();
            DetermineAgencyFee();
            DetermineFederalTaxRate();
            DetermineSocialSecurity();
            DetermineNet();
        }

        //Property used to access or change EmployeeName
        public string EmployeeName
        {
            set
            {
                employeeName = value;
            }
            get
            {
                return employeeName;
            }
        }

        //Property used to access number of dependents
        public int NoOfDependents
        {
            set
            {
                noOfDependents = value;
            }
            get
            {
                return noOfDependents;
            }
        }

        //Property used to access or change hours worked
        public double NoOfHours
        {
            set
            {
                noOfHours = value;
            }
            get
            {
                return noOfHours;
            }
        }

        //Property used to access Social Security tax amount
        public double SocialSecurity
        {
            get
            {
                return socialSecurity;
            }

        }

        //Property used to access Gross Pay
        public double Gross
        {
            get
            {
                return gross;
            }
        }

        //Property used to access Federal Income tax amount
        public double FederalTax
        {
            get
            {
                return federalTax;
            }
        }

        //Property used to access Federal Income tax amount
        public double AgencyFee
        {
            get
            {
                return agencyFee;
            }
        }
        //Property used to access Federal Income tax amount
        public double Net
        {
            get
            {
                return net;
            }
        }

        //Using the same constant value for a flat hourly rate, 
        //calculate gross pay prior to any deductions
        public void DetermineGross()
        {
            gross = noOfHours * RATE;
        }

        //Using the same constant value for the Commission Rate
        //for all employees, calculate commission due employee
        public void DetermineAgencyFee()
        {
            agencyFee = gross * AGENCY_CHARGE;
        }

        //Using the same constant value for the Federal Tax Rate
        //for all employees, calculate commission due employee
        public void DetermineFederalTaxRate()
        {
            federalTax = (gross - (gross * (DEPENDENT_ALLOWANCE
                                                  * noOfDependents))) * FEDERAL_TAX;
        }

        //Using the same constant value  for the Social Security Tax Rate
        //for all employees, calculate commission due employee
        public void DetermineSocialSecurity()
        {
            socialSecurity = gross * SOCIAL_SECURITY_RATE;
        }
        public void DetermineNet()
        {
            net = gross - socialSecurity - federalTax - agencyFee;
        }

    }
}