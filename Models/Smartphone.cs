namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string _modelo;
        public string Modelo {
            get => _modelo;
            set => _modelo = value;
        }

        private string _imei;
        public string IMEI {
            get => _imei;
            set => _imei = value;
        }

        private int _memoria;
        public int Memoria {
            get => _memoria;
            set => _memoria = value;
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades 
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}