namespace Interface.classes
{
    public interface Icarrinho
    {

    //CRUD

    //CREATE - CADASTRAR
    void Cadastrar(Produto produto);

    //READ - LER
    void listar();

    //UPDATE - ALTERAR 
    void Alterar(int cod, Produto produto);

    //DELETE - DELETAR  
    void Deletar(Produto produto);






    }
}