using System;
public class Personagem{
    private String _nome;
    private int _vida;
    private int _mana;
    private float _xp;
    private int _inteligencia;
    private int _forca;
    private int _level;
    private static int _total;

    public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
    {
        _nome = nome;
        _vida = vida;
        _mana = mana;
        _xp = xp;
        _inteligencia = inteligencia;
        _forca = forca;
        _level = level;
        _total++;
    }

    public String GetNome()
    {
        return _nome;
    }

    public void SetNome(String nome)
    {
        _nome = nome;
    }

    public int GetVida()
    {
        return _vida;
    }

    public void SetVida(int vida)
    {
        _vida = vida;
    }

    public int GetMana()
    {
        return _mana;
    }

    public void SetMana(int mana)
    {
        _mana = mana;
    }

    public float GetXp()
    {
        return _xp;
    }

    public void SeTXp(float xp)
    {
        _xp = xp;
    }

    public int GetInteligencia()
    {
       return _inteligencia;
    }

    public void setInteligencia(int inteligencia)
    {
        _inteligencia = inteligencia;
    }

    public int GetForca()
    {
        return _forca;
    }

    public void SetForca(int forca)
    {
        _forca = forca;
    }

    public int GetLevel()
    {
        return _level;
    }

    public void SetLevel(int level)
    {
        _level = level;
    }

    public void GetTotal(){
        System.Console.WriteLine("---------------------------------------------");
        System.Console.WriteLine("Total de personagens: " + _total);
        System.Console.WriteLine("---------------------------------------------"); 
    }

    public virtual void LevelUp(){
    }

    public override string ToString()
    {
        return "Nome:" + _nome + " Vida:" + _vida + " Mana:" + _mana + " XP:" + _xp + 
                " Inteligencia:" + _inteligencia + " Forca:" + _forca + " Level:" + _level;

    }
}