using System;
using ArrayIExercise = Array.Interfaces.IExercise;
using MatrixIExercise = Matrix.Interfaces.IExercise;
using StackIExercise = Stack.Interfaces.IExercise;

class Program
{
    static void Main()
    {
        Console.Title = "Menu de Estruturas de Dados";
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================================");
            Console.WriteLine("      MENU DE ESTRUTURAS DE DADOS   ");
            Console.WriteLine("====================================");
            Console.ResetColor();

            Console.WriteLine("1. Vetores");
            Console.WriteLine("2. Matrizes");
            Console.WriteLine("3. Pilhas");
            Console.WriteLine("4. Filas");
            Console.WriteLine("0. Sair");

            Console.Write("\nEscolha uma opção: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    MenuVetores();
                    break;
                case "2":
                    MenuMatrizes();
                    break;
                case "3":
                    MenuPilhas();
                    break;
                case "4":
                    MenuFilas();
                    break;
                case "0":
                    running = false;
                    Console.WriteLine("\nSaindo...");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    Console.ResetColor();
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                Console.ReadKey();
            }
        }
    }

    static void MenuVetores()
    {
        bool inMenu = true;
        while (inMenu)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========== MENU DE VETORES ==========");
            Console.ResetColor();
            for (int i = 1; i <= 9; i++)
                Console.WriteLine($"{i}. Exercício {i}");
            Console.WriteLine("\nA. Adicionar item");
            Console.WriteLine("R. Remover item");
            Console.WriteLine("V. Visualizar todos os itens");
            Console.WriteLine("B. Buscar item");
            Console.WriteLine("S. Sair para o menu principal");

            Console.Write("\nEscolha uma opção: ");
            string option = Console.ReadLine().ToUpper();
                
            if (option == "S") 
            {
                inMenu = false;
                break;
            }

            try
            {
                string className = $"Array.Exercises.Ex{option}, Array";
                Type? type = Type.GetType(className);

                if (type != null && Activator.CreateInstance(type) is ArrayIExercise exercise)
                {
                    exercise.Resolve();
                }
                else
                {
                    Console.WriteLine("\nExercício Inválido");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro ao executar: {ex.Message}");
            }

            if (inMenu)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void MenuMatrizes()
    {
        bool inMenu = true;
        while (inMenu)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========== MENU DE MATRIZES =========");
            Console.ResetColor();
            for (int i = 1; i <= 7; i++)
                Console.WriteLine($"{i}. Exercício {i}");
            Console.WriteLine("\nA. Adicionar item");
            Console.WriteLine("R. Remover item");
            Console.WriteLine("V. Visualizar todos os itens");
            Console.WriteLine("B. Buscar item");
            Console.WriteLine("S. Sair para o menu principal");

            Console.Write("\nEscolha uma opção: ");
            string option = Console.ReadLine().ToUpper();

            try
            {
                string className = $"Matrix.Exercises.Ex{option}, Matrix";
                Type? type = Type.GetType(className);

                if (type != null && Activator.CreateInstance(type) is MatrixIExercise exercise)
                {
                    exercise.Resolve();
                }
                else
                {
                    Console.WriteLine("\nExercício Inválido");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro ao executar: {ex.Message}");
            }

            if (inMenu)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void MenuPilhas()
    {
        bool inMenu = true;
        while (inMenu)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("========== MENU DE PILHAS ==========");
            Console.ResetColor();
            Console.WriteLine("1. Exercício 1");
            Console.WriteLine("\nA. Adicionar item (Push)");
            Console.WriteLine("R. Remover item (Pop)");
            Console.WriteLine("V. Visualizar todos os itens");
            Console.WriteLine("B. Buscar item");
            Console.WriteLine("S. Sair para o menu principal");

            Console.Write("\nEscolha uma opção: ");
            string option = Console.ReadLine().ToUpper();

            try
            {
                string className = $"Stack.Exercises.Ex{option}, Stack";
                Type? type = Type.GetType(className);

                if (type != null && Activator.CreateInstance(type) is StackIExercise exercise)
                {
                    exercise.Resolve();
                }
                else
                {
                    Console.WriteLine("\nExercício Inválido");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro ao executar: {ex.Message}");
            }

            if (inMenu)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void MenuFilas()
    {
        bool inMenu = true;
        while (inMenu)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("========== MENU DE FILAS ==========");
            Console.ResetColor();
            Console.WriteLine("A. Adicionar item (Enqueue)");
            Console.WriteLine("R. Remover item (Dequeue)");
            Console.WriteLine("V. Visualizar todos os itens");
            Console.WriteLine("B. Buscar item");
            Console.WriteLine("S. Sair para o menu principal");

            Console.Write("\nEscolha uma opção: ");
            string option = Console.ReadLine().ToUpper();

            switch (option)
            {
                case "A":
                case "R":
                case "V":
                case "B":
                case "S":
                    Console.WriteLine($"\nVocê escolheu: {option}");
                    if (option == "S") inMenu = false;
                    break;
                default:
                    Console.WriteLine("\nOpção inválida.");
                    break;
            }

            if (inMenu)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
