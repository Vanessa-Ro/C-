using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta ct1 = new Conta();
            Conta ct2 = new Conta();
            Conta ct3 = new Conta();

            Cliente c1 = new Cliente();
            Cliente c2 = new Cliente();
            Cliente c3 = new Cliente();

            ct1.setAgencia("1212");
            ct1.setNumero(212);
            ct1.setSaldo(100.00f);

            c1.setNome("Vanessa");
            c1.setSobrenome("Cardoso");
            c1.setCpf("111.111.111-10");
            c1.setConta(ct1);

            Console.WriteLine("Informações do Cliente " + c1.getCpf());
            Console.WriteLine("Nome: " + c1.getNome());
            Console.WriteLine("Sobrenome: " + c1.getSobrenome());
            Console.WriteLine("CPF: " + c1.getCpf());

            Console.WriteLine("\nInformações do Conta " + ct1.getAgencia());
            Console.WriteLine("Agência: " + ct1.getAgencia());
            Console.WriteLine("Número: " + ct1.getNumero());
            Console.WriteLine("Saldo: " + ct1.getSaldo());

            ct2.setAgencia("2121");
            ct2.setNumero(122);
            ct2.setSaldo(150.00f);

            c2.setNome("Melyssa");
            c2.setSobrenome("Almeida");
            c2.setCpf("222.222.222-20");
            c2.setConta(ct2);

            Console.WriteLine("\nInformações do Cliente " + c2.getCpf());
            Console.WriteLine("Nome: " + c2.getNome());
            Console.WriteLine("Sobrenome: " + c2.getSobrenome());
            Console.WriteLine("CPF: " + c2.getCpf());

            Console.WriteLine("\nInformações do Conta " + ct2.getAgencia());
            Console.WriteLine("Agência: " + ct2.getAgencia());
            Console.WriteLine("Número: " + ct2.getNumero());
            Console.WriteLine("Saldo: " + ct2.getSaldo());

            ct3.setAgencia("4242");
            ct3.setNumero(144);
            ct3.setSaldo(175.00f);

            c3.setNome("Luana");
            c3.setSobrenome("Fernandes");
            c3.setCpf("333.333.333-30");
            c3.setConta(ct3);

            Console.WriteLine("\nInformações do Cliente " + c3.getCpf());
            Console.WriteLine("Nome: " + c3.getNome());
            Console.WriteLine("Sobrenome: " + c3.getSobrenome());
            Console.WriteLine("CPF: " + c3.getCpf());

            Console.WriteLine("\nInformações do Conta " + ct3.getAgencia());
            Console.WriteLine("Agência: " + ct3.getAgencia());
            Console.WriteLine("Número: " + ct3.getNumero());
            Console.WriteLine("Saldo: " + ct3.getSaldo());

        }
    }
}
