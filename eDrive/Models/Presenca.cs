﻿namespace eDrive.Models
{
    public class Presenca
    {
        //ID unico para cada presença
        public int PresencaID { get; set; }

        //Estado da aula, por exemplo, estar presente numa aula teórica
        //ou, no caso, de uma aula prática, indicar se faltou ou se a aula foi concluída.
        public ListaEstados Estado { get; set; }



        // Foreign key for Student
        public int AlunoID { get; set; }
        public Aluno Aluno { get; set; }

        // Foreign key for Lesson
        public int AulaID { get; set; }
        public Aula Aula { get; set; }



        //Lista de estados para uma aula
        public enum ListaEstados
        {
            Presente,
            Faltou,
            Concluíu
        }
    }
}
