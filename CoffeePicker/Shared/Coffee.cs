using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePicker.Shared
{
    public  class Coffee
    {
        //prop + 2*Tab
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string[] Ingredients { get; set; }

        //ctor + 2*Tab
        public Coffee() { } //parameterless constructor

        public Coffee(int Id, string Title, string Description, string[] Ingredients)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Ingredients = Ingredients;
        }

    }
}
