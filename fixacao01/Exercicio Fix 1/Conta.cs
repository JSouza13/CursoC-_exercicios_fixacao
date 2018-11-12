using System.Globalization;

namespace fixacao01
{
    class Conta
    {
        public int numero { get; private set; }
        public string titular { get; set; }
        public double saldo { get; private set; }

        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            saldo = 0.00;
        }

        public void Depositar(double quantia)
        {
            saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + numero
                + ", Titular: "
                + titular
                + ", Saldo: $ "
                + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}




//INTERFACE

//Conta novaConta;

//Console.Write("Digite o número da conta: ");
//            int numero = int.Parse(Console.ReadLine());
//Console.Write("Digite o nome do titular da conta: ");
//            string nome = Console.ReadLine();
//Console.Write("Haverá depósito inicial(s / n) ? ");
//            char depositoInicio = char.Parse(Console.ReadLine());
//            if (depositoInicio == 's' || depositoInicio == 'S')
//            {
//                Console.Write("Digite o valor do depósito inicial: ");
//                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//novaConta = new Conta(numero, nome, valorInicial);
//            }
//            else
//            {
//                sobrecarga do meu construtor
//                novaConta = new Conta(numero, nome);
//            }

//            Console.WriteLine("\nConta criada:");
//            Console.WriteLine(novaConta);

//            Console.Write("\nDigite um valor para depósito: ");
//            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//novaConta.Depositar(deposito);
//            Console.WriteLine("Conta atualizado: ");
//            Console.WriteLine(novaConta);

//            Console.Write("\nDigite um valor para saque: ");
//            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//novaConta.Sacar(saque);
//            Console.WriteLine("Conta atualizado: ");
//            Console.WriteLine(novaConta);