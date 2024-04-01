using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    public Program()
    {
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Digite seu primeiro número");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu segundo número");
        int num2 = int.Parse(Console.ReadLine());
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}