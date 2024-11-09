namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _modelo;
        private string _imei;
        private int _memoria;

        private int tamanhoImei = 9;
        public string Numero { get; set; }
        protected string Modelo
        {
            get => _modelo;

            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Modelo não pode ser nulo/vazio");
                }
                _modelo = value;
            }
        }

        protected string Imei
        {
            get => _imei;

            set
            {
                if (value == string.Empty || value.Length != tamanhoImei)
                {
                    throw new Exception("Imei não pode ser: nulo, menor ou maior que nove");
                }
                _imei = value;
            }
        }

        protected int Memoria
        {
            get => _memoria;

            set
            {
                if (value == 0 || value < 0)
                {
                    throw new Exception("Memória precisa ser maior que zero");
                }
                _memoria = value;
            }
        }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
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