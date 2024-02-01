using System.Numerics;
using System.Reflection;


// Cambia el valor de n según tus necesidades
//int numeroRepetido = ObtenerNumeroRepetido(n);

//int ObtenerNumeroRepetido(int n)
//{
//    int resultado = n * 10
//    return resultado;
//}
//Console.WriteLine(numeroRepetido);















//BigInteger a = 827785024886475841 % 2023;
//Console.WriteLine(a.ToString());





//BigInteger n = 20;
//BigInteger aux = 0;
//for (BigInteger i = 1; i <= n; i++)
//{
//     aux = aux + n % 2023;
//}
//Console.WriteLine(aux);















const int M = 2023;
BigInteger compute(BigInteger n)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    {

        s = s + n.ToString();

    }
    Console.WriteLine(s);
    return convertir_a_numero(s) % M;
}
BigInteger convertir_a_numero(string s)
{
    BigInteger a = BigInteger.Remainder(BigInteger.Parse(s), 2023);
    return a;
}
//934, 738, 1481, 827785024886475841
List<BigInteger> valores = new List<BigInteger> { 1, 2, 5, 10, 20 };
foreach (BigInteger n in valores)
{
    Console.WriteLine(n + ":" + compute(n));
}
Console.ReadKey();