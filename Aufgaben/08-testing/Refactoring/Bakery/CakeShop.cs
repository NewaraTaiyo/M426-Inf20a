namespace Testing.Bakery
{
    public class CakeShop
    {
        private readonly ICakeLogger _log;

        public CakeShop(ICakeLogger log)
        {
            _log = log;
        }


        public void Create(Cake cake, bool vegan)
        {
            switch (cake)
            {
                case Cake.Chocolate when !vegan:
                    this.LogAddIngredient("300g", "flour");
                    this.LogAddIngredient("4", "eggs");
                    this.LogAddIngredient("100g", "chocolate");
                    break;
                case Cake.Chocolate when vegan:
                    this.LogAddIngredient("200g", "flour");
                    this.LogAddIngredient("2", "mashed bananas");
                    this.LogAddIngredient("200g", "dark chocolate");
                    break;
                case Cake.Vanilla when !vegan:
                    this.LogAddIngredient("10ml", "vanilla extract");
                    this.LogAddIngredient("100ml", "milk");
                    this.LogAddIngredient("400g", "flour");
                    break;
                default:
                    this._log.Error(DateTime.Now, "This cake is not available.");
                    break;
            }
        }


        private void LogAddIngredient(string amount, string ingredient)
        {
            _log.Info(DateTime.Now, $"Add {amount} {ingredient}");
            Thread.Sleep(50);
        }
    }
}