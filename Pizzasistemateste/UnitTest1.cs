using pizzaInterface.entidades;
using Pizzasistema.enumeradores;

namespace Pizzasistemateste
{
    public class PizzaTest
    {
        [Fact]
        public void CalcularPreco_DeveRetornarSomaDosIngredientes()
        {

            Pizza pizza = new Pizza(
                TipoQueijo.Mussarela,
                TipoMolho.Tomate,
                TipoCarne.Calabresa,
                TipoFarinha.Tradicional
            );


            double precoCalculado = pizza.CalcularPreco();


            // Preço esperado: Mussarela(15) + Tomate(10) + Calabresa(20) + Tradicional(10) = 55
            Assert.Equal(55, precoCalculado);
        }
    }
}
