namespace Entidades.Repositorios
{
    internal static class GestorSQL
    {
        private static string stringConnection;

        static GestorSQL()
        {
            stringConnection = "Server=.;Database=videoclubdb;Trusted_Connection=True;";
        }

        internal static string StringConnection
        {
            get
            {
                return stringConnection;
            }
        }
    }
}
