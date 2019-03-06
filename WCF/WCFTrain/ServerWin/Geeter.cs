namespace ServerWin
{
    public class Geeter : IGeeter
    {
        public string Greet(string name)
        {
            return $"Fuck you {name}";
        }
    }
}