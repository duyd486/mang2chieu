internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap n: ");
        int n = int.Parse(Console.ReadLine());
        int [,] arr;
        arr = new int[n, n];
        for (int i = 0; i < n; i++) {
            Console.WriteLine("Nhap phan tu hang " + i + ": ");
            for (int j = 0; j < n; j++) {
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int sum = 0;
        for (int i = 0; i < n; i++) {
            for(int j = 0; j < n; j++) {
                if(i == j) {
                    sum += arr[i, j];
                }
            }
        }
        Console.WriteLine("tong duong cheo chinh la: " + sum);
    }
}