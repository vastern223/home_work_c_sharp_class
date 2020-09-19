using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_c_sharp_classes
{
    partial class Freezer
    {
        public partial void Change_temperature(int temperature)
        {
            if (minimum_temperature >= temperature)
                Current_temperature = temperature;
        }

        public partial void Open_Freezer()
        {
            Console.WriteLine("Freezer open");
            Current_temperature++;
        }
        public partial void Close_Freezer()
        {
            Console.WriteLine("Freezer close");
            Current_temperature--;
        }

        public partial string Get_brand()
        {
            return brand;
        }
        public partial string Get_color()
        {
            return color;
        }

        public partial void Set_brand(string brand)
        {
            this.brand = brand;
        }
        public partial void Set_color(string color)
        {
            this.color = color;
        }

        public partial void Сhange_volum_in_another(ref float volume)//незнав що придумать 
        {
            volume = this.volume;

        }
        public override string ToString()
        {
            return $"brand: {brand}\n" +
                   $"color: {color}\n" +
                   $"volume: {volume}\n" +
                   $"minimum_temperature: {minimum_temperature}\n" +
                   $"Current_temperature: {Current_temperature}\n" +
                   $"id_Freezer: {id_Freezer}\n" +
                   $"working_hours: { working_hours}\n";
        }

    }
}
