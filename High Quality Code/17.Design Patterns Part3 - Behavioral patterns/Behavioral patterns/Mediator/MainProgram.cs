namespace Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainProgram
    {
        public static void Main()
        {
            var postalService = new PostalService();

            Client pesho = new Client("Pesho"); 
            postalService.Register(pesho);

            Client gosho = new Client("Gosho");
            postalService.Register(gosho);
            pesho.Send("Gosho", "Hi Gosho!");
            gosho.Send("Pesho", "Hi Pesho");           
        }
    }
}
