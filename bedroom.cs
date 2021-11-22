using System;

namespace bedroom
{
    class room
    {
        public string square;
        public string rectangle;
        public double width;
        public double length;
        public double Area;

        public string Roomshape
        {
            get { return Roomshape; }
            set
            {

                if (value == square || value == rectangle)


                {
                    Roomshape = value;
                    
                }

            ;
            }
        }

    

        public void printroomInfo()
        {
            System.Console.WriteLine("Please enter roomshape :");
            Roomshape = Console.ReadLine();

            System.Console.WriteLine("Enter Width :");
            width = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Length :");
            length = double.Parse(Console.ReadLine());
            Area = 4 * (width * length);
            System.Console.WriteLine("Area of bedroom: " + Area +" m^2");



        }
    }
}