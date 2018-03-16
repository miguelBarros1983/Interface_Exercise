namespace Interface_Exercise
{
    interface IDrivable
    {
        int  Wheel { get; set; }
        double Speed { get; set; }

        void Move();

        void Stop();
    }
}
