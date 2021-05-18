/*
*  -------------------------------------------------
* <copyright file="Delegates.cs" company="IPCA"/>
* <summary>
*	LP2 
* </summary>
* <date></date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc>
* 
*   Uso de DELEGATES
*   -----------------
* 
*   - Encapsulamento de métodos que serão invocados
*   
*   - Declaração:
*       - delegate <return type> <delegate-name> <parameter list>
* 
*   1º Declarar delegate
*   
*   2º Criar instância de delegate
*   
*   3º Invocar delegate
*   
*   Exemplo:
*       public delegate void PrintString(string s);
*       ...
*       PrintString ps1 = new PrintString(WriteToScreen);
*       ...
*       ps1("Ola");
*    
*    Eventos | Asynchronous programming
* </desc>
* -------------------------------------------------
**/
using System;

namespace Delegates
{
    #region Declaração de Delegates

    //Declara delegate (NumberChanger) aplicado a método que recebe um inteiro e devolve um inteiro
    public delegate int NumberChanger(int n);
    //Declara delegate (NumberChanger) aplicado a método que recebe uma string e devolve int
    public delegate int MyDelegate(string s);
    //Declara delegate (Exec) aplicado a método que recebe dois int e devolve int
    public delegate int Exec(int a, int b);

    //delegates para métodos "int X ()" e "void X (string s)"
    public delegate int MyDelegate1();
    public delegate void MyDelegate2(string s);

    // declara método "void X (string s)"
    public delegate void PrintString(string s);

    //anonymous method
    public delegate void MyPrint(int value);

    #endregion

    class TestDelegate
    {
       static void Main(string[] args)
        {
            #region 1 - Delegar noutro método

            //cria instâncias dos delegates
            NumberChanger nc1 = new NumberChanger(Delegates.AddNum);
            //ou 
            //nc1 = Delegates.AddNum;
            NumberChanger nc2 = new NumberChanger(Delegates.MultNum);

            //chama os métodos usando os delegates
            nc1(25);
            Console.WriteLine("Numero: {0}", Delegates.Num);
            nc2(5);
            Console.WriteLine("Numero: {0}", Delegates.Num);
            Console.ReadKey();

            #endregion

            #region 2 - Delegar noutro método
            Pessoa p = new Pessoa("Ola", new DateTime(2000, 12, 24));
        
            //cria instâncias de delegates
            MyDelegate1 nc3 = new MyDelegate1(p.GetIdade);
            MyDelegate2 nc4 = new MyDelegate2(Console.WriteLine);
            //o mesmo que
            //nc4 = Console.WriteLine;

            //chama metodos usando delegates
            int idade = nc3();
            Console.WriteLine("Idade: {0}", idade);

            idade = p.GetIdade();
            nc4("Nascimento: " + p.Nasci.ToString());
            Console.ReadKey();
            #endregion

            #region 3 - Delegates como parâmetros

            PrintString ps1 = new PrintString(Print.WriteToScreen);
            PrintString ps2 = new PrintString(Print.WriteToFile);

            Print.SendString(ps1);
            Print.SendString(ps2);

            Console.ReadKey();

            #endregion

            #region 4 - Delegates como parâmetros
            //cria delegate com callback associado
            Exec d1 = new Exec(Delegates.AddNumNum);

            //invoca metodo com callback no parametro
            int aux= Delegates.ExecSomething(12, 13, d1);

            //invoca delegate
            Print.SendString(ps1, "Resultado: " + aux.ToString());

            Console.ReadKey();
            #endregion

            #region 5 - Mulcasting Delegates

            MethodClass obj = new MethodClass();
            MyDelegate2 nc5 = new MyDelegate2(Console.WriteLine);
            MyDelegate2 m1=obj.Method1;
            MyDelegate2 m2= obj.Method2;
            nc5 = Console.WriteLine;

            //ou
            MyDelegate2 allMethodsDelegate = m1 + m2;
            allMethodsDelegate += nc5;

            allMethodsDelegate("-Teste-");
            //ao invocar allMethodsDelegate serão executados Method1, Method2 e WriteLine
            Console.ReadKey();
            #endregion

            #region 6 - Outros Delegates

            MethodClass.Method3(new int[] { 3, 4, 5, 6 }, Console.WriteLine);
            Console.ReadKey();

            MethodClass.Method3(new int[] { 3, 4, 5, 6 }, MethodClass.ShowOdd);
            Console.ReadKey();
            #endregion

            #region 7 - Anonymous Methods

            MyPrint print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);
        
            #endregion

            #region 8 - Eventos

            FileLogger fl = new FileLogger(@"c:\temp\Process.log");
            MyClass myClass = new MyClass();

            // Subscribe the Functions Logger and fl.Logger
            myClass.Log += new MyClass.LogHandler(MyClass.Logger);  //Event Handlers
            myClass.Log += new MyClass.LogHandler(fl.Logger);

            // The Event will now be triggered in the Process() Method
            myClass.Process();

            fl.Close();
            #endregion

            #region 10 - Events Handler

            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);

            }
            #endregion

            #region 9 - Eventos
            // Create a new clock
            Clock theClock = new Clock();

            // Create the display and tell it to subscribe to the clock just created
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(theClock);

            // Create a Log object and tell it to subscribe to the clock
            LogClock lc = new LogClock();
            lc.Subscribe(theClock);

            // Get the clock started
            theClock.Run();
            #endregion

           
    }

        private static void MyClass_Log(string message)
        {
            throw new NotImplementedException();
        }

        static void c_ThresholdReached(Object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
            //Environment.Exit(0);
        }

    }
}
