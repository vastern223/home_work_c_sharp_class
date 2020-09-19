using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_c_sharp_classes
{

    partial class Freezer
    {
        private string brand;
        private string color;
        private float volume;
        private readonly int minimum_temperature;
        private float height;
        private float width;
        public int Current_temperature { get; set; }

        public static int id_Freezer { get; }
        public static int working_hours { get;}

        static Freezer()
        {
            id_Freezer = 3678759;
            working_hours = 10;
           
        }
        public Freezer()
        {
            brand = "no_name";
            color = "no_color";
            volume = 0;
            minimum_temperature = 0;
            height = 0;
            width = 0;
            Current_temperature = 0;

        }
        public Freezer(string brand, string color, float volume, int minimum_temperature, float height, float width, int Current_temperature)
        {
            this.brand = brand;
            this.color = color;
            this.volume = volume;
            this.minimum_temperature = minimum_temperature;
            this.height = height;
            this.width = width;
            if (minimum_temperature >= Current_temperature)
                this.Current_temperature = Current_temperature;
            else
                this.Current_temperature = 0;
           
        }
        public Freezer(string brand, string color) : this()
        {
            this.brand = brand;
            this.color = color;
        }

        public partial void Change_temperature(int temperature);
        public partial void Open_Freezer();
        public partial void Close_Freezer();
        public partial string Get_brand();
        public partial string Get_color();
        public partial void Set_brand(string brand);
        public partial void Set_color(string color);
        public partial void Сhange_volum_in_another(ref float volume);//незнав що придумать 
        
    }



    class Program
    {
        static void Main(string[] args)
        {
            Freezer[] plane = new Freezer[5];

            for (int i = 0; i < 5; i++)
            {
                plane[i] = new Freezer();
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(plane[i].ToString());


            }
        }
    }
}
