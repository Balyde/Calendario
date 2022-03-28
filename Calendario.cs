using System;

public class Calendario {

  public Byte Mes { get; set; }
  public byte Month { get; internal set; }

  public Int16 Ano { get; set; }
  public ushort Year { get; internal set; }

  //Confere se o mês digitado é válido
  public Boolean isMesValido()
  {
    if ((Mes >= 1) && (Mes <= 12))
    {
      return true;
    }
    else return false;
  }

  //Confere se o ano digitado é válido
  public Boolean isAnoValido()
  {
    if ((Ano >= 1) && (Ano <= 9999))
    {
      return true;
    }
    else return false;
  }

  //Responsável por criar o calendário
  public string gerarCalendario() {

    int x = -1;
    var data1 = new DateTime(Ano, Mes, 1);

    //Formatação do título
    string date = String.Format("{0:MMMM} {0:yyyy}", data1, data1);

    //Centralização do título
    string titulo = String.Format("\n\n" + date.PadLeft(14 + date.Length/2, ' ') + "\n");

    //Cabeçalho do calendário
    titulo += "---------------------------\n";
		titulo += " D   S   T   Q   Q   S   S \n";
		titulo += "---------------------------\n";

    //Laço de repetição para definir em qual dia da semana começa o mês digitado
    for ( x = -1 ; x < (int)data1.DayOfWeek - 1; x++)
    {
      titulo += "    ";
    }

    int i;

    //Laço de repetição para mostrar todos os dias do mês digitado e formatar o calendário
    for (i = 1; i <= DateTime.DaysInMonth(data1.Year, data1.Month); i++)
    {
      titulo += i.ToString().PadLeft(2, '0') + "  ";
      x++;

      //Condição para pular de linha quando o dia for sábado
      if (x % 7 == 6)
      {
        titulo += "\n";
      }
    }

    titulo += "\n---------------------------\n";
    
    return titulo;
      
  }
  
}