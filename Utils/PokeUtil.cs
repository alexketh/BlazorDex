namespace BlazorDex.Util
{
    public static class PokeUtil
    {
        private const string Pokeball = "poke-ball.png";
        private const string GreatBall = "great-ball.png";
        private const string UltraBall = "ultra-ball.png";
        private const string MasterBall = "master-ball.png";

        public static string GetRandomBall()
        {
            var pokeballArray = new[] { Pokeball, GreatBall, UltraBall, MasterBall };
            var rand = new Random();
            return pokeballArray[rand.Next(pokeballArray.Length)];
        }

        public static double GetPokemonHeightInMeters(int height)
        {
            return Convert.ToDouble(height) / 10;
        }

        public static double GetPokemonWeightInKilograms(int weight)
        {
            return Convert.ToDouble(weight) / 10;
        }
    }
}