using System;
//Enum
class Aula10
{
    enum DiasSemana{Domingo,segunda,Terça,Quarta,Quinta,Sexta,Sábado}
    static void Main()

    {
        //DiasSemana ds = DiasSemana.Domingo;
        //DiasSemana ds = (DiasSemana)3;
        int ds = (int)DiasSemana.Sexta; //Vai retornar o indice
        Console.WriteLine(ds);
    }
}