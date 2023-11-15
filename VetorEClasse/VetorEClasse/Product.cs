using System.Globalization;

namespace VetorEClasse {
    internal class Product {
        public string Descricao {  get; set; }
        public double Preco {  get; set; }
        public int Quantidade {  get; set; }

        public Product(string name, double price) { 
            Descricao = name;
            Preco = price;
        }
        public Product(string name, double price, int qnt): this(name, price) {
            EntradaNoEstoque(qnt);
        }

        public double ValorTotalProduct() {
            return Quantidade * Preco;
        }

        public void EntradaNoEstoque(int entrada) {
            Quantidade += entrada;
        }

        public void SaidaNoEstoque(int saida) {
            Quantidade -= saida;
        }
        public override string ToString() {
            return Descricao
                    +"| PRECO: R$ "+Preco.ToString("F2", CultureInfo.InvariantCulture)
                    +"| QNT: "+Quantidade
                    +"| TOTAL: R$ "+ValorTotalProduct().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
