namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArray array = new IntArray(3, 4);


            array[0, 0] = 10;
            array[1, 2] = 20;


            Console.WriteLine($"Елемент  [0,0]: {array[0, 0]}");
            Console.WriteLine($"Елемент [1,2]:  {array[1, 2]}");

            var size = array.Size;
            Console.WriteLine($"Розмір масиву: {size.rows}x{size.cols}");


            try
            {
                Console.WriteLine(array[5, 5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    
    }
}
