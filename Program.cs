class Program
{
    static void Main(string[] args)
    {
        try
        {
            var (fileOrigin, fileDestiny) = (@"arquivo_origem.txt", @"arquivo_destino.txt");
            var linesOrigin = System.IO.File.ReadAllLines(fileOrigin);
            var linesDestiny = new string[linesOrigin.Length];
            for (int i = 0; i < linesOrigin.Length; i++)
            {
                linesDestiny[i] = linesOrigin[i].StartsWith("B00") ?
                    linesDestiny[i] = @$"{linesOrigin[i].Substring(0, 11)}
                                          01022022
                                         {linesOrigin[i].Substring(19, 6)}
                                         01022022
                                         {linesOrigin[i].Substring(33, linesOrigin[i].Length - 33)}" :
                    linesDestiny[i] = linesOrigin[i];
            }
            System.IO.File.WriteAllLines(fileDestiny, linesDestiny);
        }
        catch (System.Exception)
        {
            throw;
        };
    }
}