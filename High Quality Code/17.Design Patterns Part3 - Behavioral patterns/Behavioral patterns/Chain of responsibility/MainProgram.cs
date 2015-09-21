namespace ChainOfResponsibility
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
            Bicycle myBycicle = new Bicycle();
            Car myCar = new Car();
            Truck myTruck = new Truck();
            myBycicle.SetSuccessor(myCar);
            myCar.SetSuccessor(myTruck);
            Bagage myBagage = new Bagage(222);
            myBycicle.RequestToTransport(myBagage);
        }
    }
}
