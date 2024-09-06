using System.Globalization;

class Program 
{
    public static void Main()
    {
        Console.Write("Baholarning sonini kriting: ");
        int number = int.Parse(Console.ReadLine()!);

        int[] array = new int[number];

        int kattaSon = 0;
        int kichikSon = 100;

        for(int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine()!);
        }

        for(int i = 0; i < array.Length; i++)
        {
            if(kattaSon < array[i])
            {
                kattaSon = array[i];
            }
            else if(kichikSon > array[i])
            {
                kichikSon = array[i];
            }

        }

        double ortachaBaho = 0;

        for(int i = 0;  i < array.Length; i++)
        {
            ortachaBaho += array[i];
        }

        ortachaBaho /= array.Length;


        Console.WriteLine();
        Console.WriteLine($"O'qivchilar soni: {number}");
        Console.Write("Baholar: ");
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        
        Console.WriteLine($"Eng past baho: {kichikSon}");
        Console.WriteLine($"Eng baland baho: {kattaSon}");
        Console.WriteLine($"O'rtacha baho: {ortachaBaho}");

        for(int i = 0; i < array.Length - 1; i++)
        {
            for(int b = i + 1; b < array.Length; b++)
            {
                if(array[i] < array[b])
                {
                    int son = array[i];
                    array[i] = array[b];
                    array[b] = son;
                }
            }
        }

        Console.Write("Reyting: ");

        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
                

    }
}
