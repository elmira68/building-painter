using System;
using bedroom;

namespace painter
{
    class paint:room
    {
        public string roghani;
        public string pelastic;
        public double payment;
        


        public string colortype
        {
            get { return colortype; }
            set
            {
                if (value == "roghani")
                {
                    
                    
                    Area = Area * 1000;
                
                }
                else if (value == "pelastic")
                {
                    
                    Area = Area * 500;
                }
                else
                {
                    System.Console.WriteLine("warning");
                }
                
                ;
                
            }
        }
       // public paint(string s,string r, double w,double l, double A):base(s,r,w,l,A)
        
            
        

        public void printroom()
        {
            printroomInfo();
            
            System.Console.WriteLine("Please EnTER ColorType :");
            colortype = Console.ReadLine();

           
            System.Console.WriteLine("Payment for painter: "+Area);


        }
        

    }

}

