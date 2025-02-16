public class Circle
{
    public static void DrawCircle(int radius, char drawChar)
    {
        double thickness = 0.4; // Daire kenarını belirlemek için tolerans
        int diameter = 2 * radius;

        for (int y = -radius; y <= radius; y++)
        {
            for (int x = -radius; x <= radius; x++)
            {
                double distance = Math.Sqrt(x * x + y * y);
                if (distance >= radius - thickness && distance <= radius + thickness)
                {
                    Console.Write(drawChar);
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}