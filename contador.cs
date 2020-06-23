
public class ContadorDeRecursos
{
    System.Timers.Timer timer = new System.Timers.Timer();

    private int contador =  null;
    private int quantidade = null;
    public int Contador { get => contador; set => contador = value;}



    public ContadorDeRecursos(int tempo, int qtd)
    {
        quantidade = qtd;
        tempo = tempo * 100;
        timer.Elapsed += new ElapsedEventHandler(OnTimeEvent);
        timer.Interval = tempo;
    }
    
    public static void Start()
    {
        timer.Eneable =  true;
    }

    public static void Stop()
    {
        timer.Eneable =  false;
    }

    public static void OnTimeEvent(object source, ElapsedEventArgs e)
    {
        contador = contador + quantidade;
    }
}