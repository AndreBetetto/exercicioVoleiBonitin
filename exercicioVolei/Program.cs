// See https://aka.ms/new-console-template for more information

namespace exercicioVolei
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> nometitular = new List<string>();
            List<string> nomereserva = new List<string>();
            List<int> htitular = new List<int>();
            List<int> hreserva = new List<int>();
            int[] vhgeral = new int[12];
           
            Console.WriteLine("Bem vindo ao sistema de cadastro de jogadores de vôlei!\nNote que os nomes são escolhidos automaticamente, mas é possível" +
                              "escolher um novo nome. Os 6 primeiros jogadores que aparecem na tela, são titulares. " +
                              "Os próximos 6 jogadores são selecionados como reservas.");
            Random r = new Random();

            int tit = 1;
            int rand;
            int altura;
            string nomejog;
            int reservajog;
            jogador[] j = new jogador[12]; 
            
            for (int i = 0; i < 6; i++)
            {
                j[i] = new jogador();
                nomejog = jogador.nomearjog();
                altura = jogador.alturajog();
                
                j[i].nome = nomejog;
                j[i].altura = altura;
                j[i].titular = true;
                int resp =1;
                while (resp != 4)
                {
                    Console.WriteLine("\n--------------\nJogador(a) "+j[i].nome);
                    Console.WriteLine("Altura: " + j[i].altura + " cm");
                    Console.WriteLine("Titular? "+ j[i].titular);
                    Console.WriteLine("1- Mudar nome\n2- Mudar altura\n3- Mudar tipo do jogador\n4- Proximo");
                    resp = Convert.ToInt32(Console.ReadLine());
                    if (resp == 1)
                    {
                        string nomenovo;
                        Console.WriteLine("Digite o novo nome: ");
                        nomenovo = Console.ReadLine();
                        j[i].nome = nomenovo;
                    }
                    if ( resp == 2)
                    {
                        int alturanovo;
                        Console.WriteLine("Digite a nova altura: ");
                        alturanovo = Convert.ToInt32(Console.ReadLine());
                        j[i].altura = alturanovo;
                    }
                    if (resp == 3)
                    {
                        int novotit;
                        Console.WriteLine("O jogador 'e titular: (1-sim, 2-nao) ");
                        novotit = Convert.ToInt32(Console.ReadLine());
                        if (novotit == 1)
                        {
                            j[i].titular = true;
                        }
                        else
                        {
                            j[i].titular = false;
                        }
                    }
                    if (resp == 4)
                    {
                        break;
                    }
                }
                
                
                //j[i].nome = 
                //rand = r.Next(150, 220);
                //vhgeral[i] = rand;
                //j[i].altura = vhgeral[i];
                //Console.WriteLine("Esse jogador é titular? \n 1-sim \n 2-não ");
                //tit = Convert.ToInt32(Console.ReadLine());
                //if (tit == 1)
                //{
                //    j[i].titular = true;
                //    htitular.Add();
                //    nometitular.Add(nomejog);
                // }
                //else {j[i].titular = false; hreserva.Add(rand); nomereserva.Add(nomejog);}
                //Console.WriteLine(j.nome)

            }

            for (int i = 6; i < 12; i++)
            {
                j[i] = new jogador();
                nomejog = jogador.nomearjog();
                altura = jogador.alturajog();

                j[i].nome = nomejog;
                j[i].altura = altura;
                j[i].titular = false;
                int resp = 1;
                while (resp != 4)
                {
                    Console.WriteLine("\n--------------\nJogador(a) " + j[i].nome);
                    Console.WriteLine("Altura: " + j[i].altura + " cm");
                    Console.WriteLine("Titular? " + j[i].titular);
                    Console.WriteLine("1- Mudar nome\n2- Mudar altura\n3- Mudar tipo do jogador\n4- Proximo");
                    resp = Convert.ToInt32(Console.ReadLine());
                    if (resp == 1)
                    {
                        string nomenovo;
                        Console.WriteLine("Digite o novo nome: ");
                        nomenovo = Console.ReadLine();
                        j[i].nome = nomenovo;
                    }

                    if (resp == 2)
                    {
                        int alturanovo;
                        Console.WriteLine("Digite a nova altura: ");
                        alturanovo = Convert.ToInt32(Console.ReadLine());
                        j[i].altura = alturanovo;
                    }

                    if (resp == 3)
                    {
                        int novotit;
                        Console.WriteLine("O jogador 'e titular: (1-sim, 2-nao) ");
                        novotit = Convert.ToInt32(Console.ReadLine());
                        if (novotit == 1)
                        {
                            j[i].titular = true;
                        }
                        else
                        {
                            j[i].titular = false;
                        }
                    }

                    if (resp == 4)
                    {
                        break;
                    }
                }
            }

            int tempgeral, temptit, tempres;
            int somahgeral = 0;
            int somahtit = 0;
            int somahres = 0;
            double mediahgeral, mediahtit, mediahres;
            int cont = 0;
            //Media geral
            int conttit = 0, contres = 0;
            for (int i = 0; i < 12; i++)
            {

                //Apresentacao dos jogadores
                cont++;
                Console.WriteLine("\nJogador " + i);
                Console.WriteLine("Nome: " + j[i].nome);
                Console.WriteLine("Altura: " + j[i].altura);
                Console.WriteLine("Titular? " + j[i].titular + "\n------------------------");
                //Fim apresentacao

                //Faz média altura geral
                tempgeral = j[i].altura;
                somahgeral = tempgeral + somahgeral;
                //
                //separacao titular e reserva
                if (j[i].titular == true)
                {
                    temptit = j[i].altura;
                    somahtit = temptit + somahtit;
                    conttit++;
                }
                if (j[i].titular == false)
                {
                    tempres = j[i].altura;
                    somahres = somahres + tempres;
                    contres++;
                }
            }
            //media geral
            mediahgeral = somahgeral / 12;
            Console.WriteLine("\nMedia geral = " + mediahgeral);
                
            //media titular
            mediahtit = somahtit / conttit;
            Console.WriteLine("\nMédia altura dos titulares = " + mediahtit);
            
            //media reserva
            mediahres = somahres / contres;
            Console.WriteLine("\nM'edia altura dos reservas = " + mediahres);


            //Console.WriteLine(nome[1]);

        }
    }
    
}