
namespace Interface_Exercise
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 160);

            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }

            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powBut = new PowerButton(TV);

            powBut.Execute();
            powBut.Undo();

            Console.ReadLine();
        }
    }
}
