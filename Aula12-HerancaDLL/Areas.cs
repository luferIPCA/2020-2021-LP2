/*
 * Melhorar qualidade de código:
 * https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/code-style-rule-options?view=vs-2019
 */

namespace HerancaDLL
{
    /// <summary>
    /// representa a área de um sólido géométrico
    /// </summary>
    public abstract class Areas
    {
        protected string nomeObjeto;
        public abstract double GetArea();
        public string Nome
        {
            get => nomeObjeto;
        }
    }


}
