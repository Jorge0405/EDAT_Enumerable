internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("Enumerables");
        Console.WriteLine("===========================================");

        #region Lista
        var lista = new List<string>
        {
            "Juan",
            "Carlos",
            "Jose",
            "Dania",
            "Pedro",
            "Daniel",
            "Josefa",
            "Jorge",
            "Luis",
            "Kevin"
        };

        lista.Add("Sonic");
        //foreach (var nombre in lista)
        //{
        //    Console.WriteLine(nombre);
        //}
        lista.OrderBy(lista);


        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }

        #endregion

        Console.ReadKey();
    }
}