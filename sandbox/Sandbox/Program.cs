using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hellow world sandbox!");
        Console.WriteLine();

        List<string> animationString = new List<string>()
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\",
        };
        DateTime startTime = DateTime.Now;  //aca creo tiempo de inicio (ahora) y fin de tiempo 10s despues de ahora
        DateTime endTime = startTime.AddSeconds(20);

        //Como el spiner  va a dejar de girar cuando se acabe la lista  (8s), creo un rango i
        int i = 0; //esto despues lo reinicio con un if a cero

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count) //osea, si i es mayor o igual que sero, que se reinicie
            {
                i = 0;
            }
        }
    }

}