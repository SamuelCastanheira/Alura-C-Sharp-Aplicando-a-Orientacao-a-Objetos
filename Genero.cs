class Genero
{
    public string Nome { get;}

     public Genero(string genero)
    {
        Nome = genero; 
    }

    public void toString() {
        Console.WriteLine(Nome);
    } 

}