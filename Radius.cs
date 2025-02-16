public class Radius
{
    public static int RadiusValue()
    {
        int radius;
        do
        {
            Console.Write("Yarıçapı giriniz: ");
        }
        while (!int.TryParse(Console.ReadLine(), out radius) || radius <= 0);

        return radius;

        
    }
}