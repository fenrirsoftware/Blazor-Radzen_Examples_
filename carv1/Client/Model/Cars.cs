using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;

namespace carv1.Client.Model

{
    public class car
    {
        private static int idCounter = 0;

        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Görsel { get; set; }

        public car()
        {
           
        }

        public car(string marka, string model, string görsel)
        {
            Id = ++idCounter;
            Marka = marka;
            Model = model;
            Görsel = görsel;
        }
    }


}
