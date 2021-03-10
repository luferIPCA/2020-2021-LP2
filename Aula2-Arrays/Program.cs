/*
 * Manipulação de Memória com arrays
 * https://www.c-sharpcorner.com/article/working-with-arrays-in-C-Sharp/
 * Explorar Debuging
 * lufer
 * */
using System;

namespace MyArrays
{

    public struct Aluno
    {
        public int numero;
        public string nome;
        public float notaLP2;
    }
    
    /// <summary>
    /// Essencial sobre arrays
    /// </summary>
    class Program
    {
        /// <summary>
        /// Manipular arrays
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            #region DECLARAR_INICIALIZAR

            //Arrays simples
            //declarar e inicializar
            int[] valores = { 1, -2, 3, -4 };
            valores[0] = valores[3] - 2;
            valores[2] *= 1;
            int[] valores2 = new int[10];
            int[] valores3;

            char[] v1 = { 'B', 'r' };
            v1[0] = 's';
            //v1[2] = 'e';         //Erro!!!
            //
            string[] quaseClubes = { "Porto", "Gil Vicente", "Braguinha" };
            string[] clubes = new string[10];
            clubes[0] = "Benfica";
            clubes[1] = "Porto";
            if (clubes[1] is string) { }
            Console.Write("Valor para inserir no Array de QuaseClubes:");
            clubes[2] = quaseClubes[1] + " e " + Console.ReadLine();

            //Mostrar ARRAY
            Console.WriteLine("Array QuaseClubes:");
            for (int j = 0; j < quaseClubes.Length; j++)
            {
                Console.WriteLine("Clube: {0}", clubes[j]);
            }
            //Nesta listagem do array existe um problema...qual? Corrigir!

            #endregion

            Console.ReadKey();
            Console.WriteLine();    //linha em branco

            #region MOSTRAR_ARRAYS

            //Mostrar array
            //h1: ciclos
            Console.WriteLine("Valores iniciais do Array:");
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("FOR -  Val: {0}", valores[i]);
            }

            //h2: foreach
            foreach (int v10 in valores)
            {
                Console.WriteLine("ForEach - Val: " + v10);
            }
            #endregion

            Console.ReadKey();
            Console.WriteLine();

            #region PROCURAR_ARRAYS

            #region I
            //----------------------------------------------------------
            //Procurar elemento em array

            Console.WriteLine("Verificar se o 27 existe no array Valores:");
            Console.WriteLine("Sem utilizar Break");
            int aux = 27;
            //H1 - Um pouco aldabrada
            foreach (int i in valores)
            {
                if (i == aux)
                    Console.WriteLine("Existe"); //???
            }
            Console.WriteLine("Não existe");

            //H2: como deve ser
            Console.WriteLine("Utilizando Break");
            bool existe = false;
            foreach (int i in valores)
            {
                if (i == aux)
                {
                    existe = true; break;
                }
            }
            Console.WriteLine((existe == true) ? "27 Existe" : "27 Não Existe");

            //----------------------------------------------------------
            Console.ReadKey();
            Console.WriteLine();    //linha em branco
            Console.WriteLine("Usando Funções");
            //Usar métodos nossos
            bool b = Arrays.Existe(aux, valores);
            Console.WriteLine((b == true) ? "27 Sim" : "27 Não");

            #endregion

            #endregion

            Console.ReadKey();
            Console.WriteLine();

            #region ALTERAR_ARRAYS
            //
            Console.WriteLine("Alterar Valores do Array com métodos:");
            Arrays.DobraArray(valores);

            Arrays.MostraArray(valores);
            #endregion

            Console.ReadKey();
            Console.WriteLine();

            #region ORDENAR_ARRAYS

            //H1: Ordenar diretamente no array

            Console.WriteLine("ORDENAR ARRAYS: ANTES");
            int[] notas = new int[] { 11, 10, 17, 12 };
            Arrays.MostraArray(notas);

            //Ordenar
            for (int i = 0; i < notas.Length - 1; i++)
            {
                for (int j = i + 1; j < notas.Length; j++)
                {
                    //Verifica se temos de trocar
                    if (notas[j] < notas[i])    //Tem de trocar | need to swap
                    {
                        int t = notas[i];   //perserve value
                        notas[i] = notas[j];  //change
                        notas[j] = t;       //revover preserved value
                    }
                }
            }

            Console.WriteLine("ORDENAR ARRAYS: DEPOIS");
            Arrays.MostraArray(notas);

            //H2: Ordenar array com método da class Array
            Array.Sort(valores);
            Console.WriteLine("Array Ordenado com Método Sort:");
            Arrays.MostraArray(valores);


            #endregion

            Console.ReadKey();
            Console.WriteLine();

            #region USARMETODOSARRAYS

            existe = Arrays.ExisteValorArray(27, valores);
            Console.WriteLine("27 Existe? " + existe);

            //encontrar valores maiores que determinado valor
            valores3 = Arrays.DescVal(valores, -12);
            if (valores3 != null && valores3.Length > 0)
                Arrays.MostraArray(valores3);
            #endregion

            Console.ReadKey();
            Console.WriteLine();

            #region ARRAYSMULTIDIMENSIONAIS

            //unidimensionais
            int[] outrosValores = new int[30];
            string[] nomes = new string[] { "ola", "ole", "oli" };
            int[] novo = new int[] { 1, 3, 5, 7, 9 };

            //bidimensionais
            int[,] matriz = new int[4, 4];
            int[,] mat = new int[3, 3] { { 1, 2, 3 }, { 3, 4, 4 }, { 3, 4, 5 } };
            int[,] mat2 = { { 2, 3 }, { 3, 4 } };
            string[,] desporto = new string[2, 2] { { "Benfica", "Porto" }, { "Braga", "Sporting" } };
            string[,] emails = { { "lufer", "mcunha" }, { "jcsilva", "jpsilva" } };

            //mostrar array bidimensional
            for (int i = 0; i < emails.GetLength(0); i++)
            {
                for (int j = 0; j < emails.GetLength(1); j++)
                {
                    Console.Write(emails[i, j] + "\t");
                }
                System.Console.WriteLine();
            }

            //jagged array
            //data_type[][] name_of_array = new data_type[rows][]
            int[][] bilheteiras = new int[3][];

            bilheteiras[0] = new int[50];   //50 lugares
            bilheteiras[1] = new int[40];   //40 lugares
            bilheteiras[2] = new int[30];   //30 lugares

            //
            int[][] jagged = new int[3][];
            jagged[0] = new int[3];
            jagged[1] = new int[] { 3, 4, -5, 13 };
            jagged[2] = new int[] { -3, -4, 5, 6, 7, 5, 6 };

            // Display the array elements:  
            for (int i = 0; i < jagged.Length; i++)
            {
                System.Console.Write("Element({0}): ", i + 1);
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    System.Console.Write(jagged[i][j] + "\t");
                }
                System.Console.WriteLine();
            }

            #endregion

            Console.ReadKey();
            Console.WriteLine();


            #region ARRAYS_REVISÔES

            #region ARRAYSIMPLES_REVISION
            int[] v = new int[20];

            v[2] = 0;
            v[0] = v[2] * 2;
            int som = 0;
            for (int i = 0; i < v.Length; i++)
            {
                som += v[i];
            }
            #endregion

            #region ARRAYS_BIDI_MATRIZES
            //Calcular a soma de todosmos elementos de uma matriz
            int[,] matriz1 = new int[3, 3] { { 2, 3, 4 }, { 3, 5, 7 }, { 0, 5, 6 } };
            int som2 = 0;
            for (int i = 0; i < matriz1.GetLength(0); i++) //GetLenth(0) devolve o número de linhass da matriz
            {
                for (int j = 0; j < matriz1.GetLength(1); j++) //GetLenth(1) devolve o número de colunas em cada linha {
                {
                    som2 += matriz1[i, j];
                }
            }

            #endregion

            #region JaggedArray
            //JaggedArray = array de arrays
            int[][] matriz3 = new int[3][];

            //número de colunas para a linha 1
            matriz3[0] = new int[3];
            //número de colunas para a linha 2
            matriz3[1] = new int[] { 3, 4, -5, 7 };
            //número de colunas para a linha 3
            matriz3[2] = new int[10];
            int soma3 = 0;
            for (int i = 0; i < matriz3.Length; i++)
            {
                for (int k = 0; k < matriz3[i].Length; k++)//matriz3[i].Length verifica quantas colunas tem cada linha
                {
                    soma3 += matriz3[i][k];
                }
            }
            #endregion

            #endregion


            #region ARRAY_STRUCTS

            #region I

            Student[] course = new Student[3]; //array of 10 students

            course[0] = new Student() { number = 123, name = "Ana" };
            //equivalent a:
            //course[0].name = "Ana";
            //course[0].number = 123;
            course[1] = new Student() { number = 127, name = "Manuel" };
            course[2] = new Student() { number = 327, name = "Joaquim" };

            //Mostrar todos os alunos
            //Show all students

            Console.WriteLine("STUDENTS");
            foreach (Student s in course)
            {
                Console.WriteLine("Number:{0} \t Name: {1}", s.number.ToString(), s.name);
            }

            Console.ReadKey();
            //[123, 127, 327]
            //Mostrar qual o aluno que tem o maior número
            //Show the student with the greatest number
            //Algoritmo:
            //1ª - Encontrar o maior número dos números!!!
            int maiorNumero = course[0].number;
            string nomeAlunoMaiorNumero = course[0].name;
            int kk = 1;
            while (kk < course.Length)
            {
                if (course[kk].number > maiorNumero)   //Troca | change
                {
                    maiorNumero = course[kk].number;
                    nomeAlunoMaiorNumero = course[kk].name;
                }
                kk++;
            }

            Console.WriteLine("Número Maior={0} - Nome do Aluno: {1}", maiorNumero, nomeAlunoMaiorNumero);

            //2ª - Qual o estudante? 
            //H1: percorrer o array e encontrar o maior número

            for (int i = 0; i < course.Length; i++)
            {
                if (course[i].number == maiorNumero)
                {
                    Console.WriteLine("Aluno com o maior Número={0}", course[i].name);
                    break;
                    //return;
                }
            }

            //H2: Ao encontrar o maior número, guardar o respetivo nome!!!

            #endregion

            #region II
            Pessoa p = new Pessoa() { idade = 12, nome = "ok" };
            Pessoa[] pessoas = new Pessoa[] { new Pessoa() { idade = 12, nome = "ola" } };

            foreach (Pessoa pAux in pessoas)
            {
                Console.WriteLine("Nome: {0} \t Idade: {1}", pAux.nome, pAux.idade);
            }
            #endregion
            #endregion


            #region AULA_ARRAYS

            //array simples
            char[] palavra = new char[] { 'B', 'e', 'n', 'f', 'i', 'c', 'a' };

            for (int i = 0; i < palavra.Length; i++)
            {
                Console.Write(palavra[i].ToString());
            }

            foreach (char c in palavra)
            {
                Console.Write(c.ToString());
            }

            //Array Bidimensional

            char[,] palavras = new char[3, 3] { { 'a', 'a', 'a' }, { 'a', 'a', 'a' }, { 'a', 'a', 'a' } };
            //int auxLinhas = palavras.GetLength(0);
            //for (int i=0; i< auxLinhas; i++)  
            for (int i = 0; i < palavras.GetLength(0); i++) //GetLengh(0) devolve o número de linhas!!!
            {
                for (int k = 0; k < palavras.GetLength(1); k++) //GetLengh(1) devolve o número de colunas!!!
                {
                    Console.Write(palavras[i, k].ToString());
                }
            }

            //Jagged Array
            //Array de Arrays

            int[][] numeros = new int[3][];

            numeros[0] = new int[] { 2, 3, 4, 5, 6 };
            numeros[1] = new int[] { 2, 3, 4, 5, 6, -2, 5 };
            numeros[2] = new int[] { 2};

            for(int i=0; i < numeros.Length; i++)
            {
                for(int k=0; k<numeros[i].Length; k++)
                {
                    Console.Write(numeros[i][k].ToString());
                }
            }


            #endregion


            #region AULA_STRUCTS

            //public int numero;
            //public string nome;
            //float notaLP2;

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("TURMA LP2");
            Aluno[] turma = new Aluno[4];

            turma[0] = new Aluno() { nome = "Ana", numero = 127, notaLP2 = 13.4F };
            turma[1] = new Aluno() { nome = "Rita", numero = 128, notaLP2 = 12.4F };
            turma[2] = new Aluno() { nome = "Isabela", numero = 129, notaLP2 = 13.4F };
            turma[3] = new Aluno() { nome = "Sara", numero = 130, notaLP2 = 11.0F };
            
            //Mostrar toda a turma
            foreach(Aluno a in turma)
            {
                Console.WriteLine("Nome: {0} \t Número: {1} \t Nota LP2: {2}", a.nome, a.numero, a.notaLP2);
            }

            //Encontrar o nome da pessoa com a melhor nota a LP2
            //Algoritmo
            // 1ª - Encontrar a melhor Nota
            float melhorNota = turma[0].notaLP2;
            string nomeMelhorNota = turma[0].nome;
            int k0 = 1;
            int posMelhorNota = 0;
            while (k0 < turma.Length)
            {
                if (melhorNota < turma[k0].notaLP2) //Trocar
                {
                    melhorNota = turma[k0].notaLP2;
                    nomeMelhorNota = turma[k0].nome;
                    posMelhorNota = k0;
                }
                k0++;
            }

            // 2ª - Encontrar o nome da Pessoa
            //H1:Guardar a posição do array onde está a melhor nota!!!

            Console.WriteLine("Melhor nota foi da {0} e = {1}", turma[posMelhorNota].nome,melhorNota.ToString());
            //H2
            // Guardar também o nome

            //H3
            // array auxiliar para guardar todas as posições das melhores notas!!!
            // Para ordenat por nome aqueles que tiveram melhor nota!!!

            //H4 - Mostrar apenas os alunos que tiveram a melhor nota
            int kkk = 0;
            while (kkk < turma.Length)
            {
                if (melhorNota ==turma[kkk].notaLP2) //Trocar
                {
                    Console.WriteLine("Nome: {0} \t Número: {1} \t Nota LP2: {2}", turma[kkk].nome, turma[kkk].numero, turma[kkk].notaLP2.ToString());
                }
                kkk++;
            }

            //NÂO FUNCIONA!!!!
            //Array.Sort(turma);

            #endregion


            #region AULA_PARAMETROS


            int[] maisValores = new int[] { 3, 4, 5, 6, -2 };

            //CUIDADO!!!
            Array.Sort(maisValores);            //Já definido .NET

            Array.Reverse(maisValores);
           
            Arrays.MostraArray(maisValores);    //Definido por nós

            bool auxBool = Arrays.Existe(-2, maisValores); //Definido por nós

            #endregion

 

            Console.ReadKey();
        }
    }
}
