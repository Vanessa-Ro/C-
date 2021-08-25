using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Postagem p1 = new Postagem();
            Postagem p2 = new Postagem();
            Postagem p3 = new Postagem();

            Usuario u1 = new Usuario();

            p1.Titulo = "Viagem para Itália";
            p1.Data = "18/06/2025";
            p1.Conteudo = "Próximo lugar que desejo visitar!";
            p1.Visitas = 420;

            p2.Titulo = "Viagem para Holanda";
            p2.Data = "18/06/2026";
            p2.Conteudo = "Próximo lugar que desejo visitar, após viajar para Itália!";
            p2.Visitas = 360;

            p3.Titulo = "Viagem para Irlanda";
            p3.Data = "18/06/2027";
            p3.Conteudo = "Próximo lugar que desejo visitar, após viajar para Holanda!";
            p3.Visitas = 480;

            u1.Nome = "Vanessa";
            u1.Sobrenome = "Cardoso";
            u1.Senha = "Viagens888";
            u1.Postagens[0] = p1;
            u1.Postagens[1] = p2;
            u1.Postagens[2] = p3;

            Console.WriteLine("\nInformações do Usuário " + u1.Nome);
            Console.WriteLine("Nome: " + u1.Nome);
            Console.WriteLine("Sobrenome: " + u1.Sobrenome);
            Console.WriteLine("Senha: " + u1.Senha);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nPost " + (i + 1));
                Console.WriteLine("Título: " + u1.Postagens[i].Titulo);
                Console.WriteLine("Data: " + u1.Postagens[i].Data);
                Console.WriteLine("Conteudo: " + u1.Postagens[i].Conteudo);
                Console.WriteLine("Visitas: " + u1.Postagens[i].Visitas);
            }
        }
    }
}
