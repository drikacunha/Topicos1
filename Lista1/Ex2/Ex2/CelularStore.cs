namespace Ex2;

public abstract class CelularStore
{
    protected Fabrica celular;

    public void createNewCelular()
    {
        this.celular = new Fabrica();
    }

    public abstract void buildMarca(string marca);
    public abstract void buildCelular();
    public abstract void buildBateria(string bateria);
    public abstract void buildCamera(string camera);
    public abstract void buildVisor(string visor);

    public Fabrica Getcelular()
    {

        return celular;
    }
    
}

