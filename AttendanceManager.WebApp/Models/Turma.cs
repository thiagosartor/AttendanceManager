namespace AttendanceManager.WebApp.Models
{
    public class Turma
    {
        public Turma()
        {
        }

        public Turma(int ano)
        {
            Ano = ano;
        }

        public int Id { get; set; }
        public int Ano { get; set; }
    }
}