using System;

namespace Vehicle
{

    class vehicle
    {
        private string reg_num;
        private string reg_date;
        private string color;

        
        public string Reg_num
        {
            get { return reg_num; }
            set { reg_num = value; }
        }
        public string Reg_date
        {
            get { return reg_date; }
            set { reg_date = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public vehicle() { }
        public vehicle(string regnum, string regdate, string Color)
        {
            this.reg_num = regnum;
            this.reg_date = regdate;
            this.color = Color;

        }
        public void VehicleInfo()
        {
            Console.WriteLine(Reg_num + " " +  Reg_date + " " + Color);
        }

    }
    



    class Program
    {
        static void Main(string[] args)
        {
            vehicle vh = new vehicle("12-9089", "16-06-2021", "red");
            vh.VehicleInfo();

            vehicle vh2 = new vehicle("13-9909", "16-06-2021", "blue");
            vh2.VehicleInfo();
        }
    }
}
