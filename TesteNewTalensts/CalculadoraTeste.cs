
using NewTalents.Models;

namespace TesteNewTalensts;

public class CalculadoraTestes
{
    private Calculadora _calculadora;

    public CalculadoraTestes()
    {
        _calculadora = new Calculadora();
    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(2,2,4)]
    [InlineData(4,2,6)]
    public void TesteSomar(int numero1, int numero2, int resultadoEsperado)
    {
        int resultado = _calculadora.Somar(numero1, numero2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(3,2,1)]
    [InlineData(2,2,0)]
    [InlineData(4,2,2)]
    public void TesteSubitrair(int numero1, int numero2, int resultadoEsperado)
    {
        int resultado = _calculadora.Subtrair(numero1, numero2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(3,2,6)]
    [InlineData(2,2,4)]
    [InlineData(4,2,8)]
    public void TesteMultiplicar(int numero1, int numero2, int resultadoEsperado)
    {
        int resultado = _calculadora.Multiplicar(numero1, numero2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(8,2,4)]
    [InlineData(2,2,1)]
    [InlineData(4,2,2)]
    public void TesteDividir(int numero1, int numero2, int resultadoEsperado)
    {
        int resultado = _calculadora.Dividir(numero1, numero2);

        Assert.Equal(resultadoEsperado, resultado);
    }


    [Theory]
    [InlineData(8,0)]
    public void TesteDividirPorZero(int numero1, int numero2)
    {
        Assert.Throws<DivideByZeroException>(
            () => _calculadora.Dividir(numero1, numero2)
        );
    }

    [Fact]
    public void TesteHistorico()
    {
        _calculadora.Somar(1,2);
        _calculadora.Subtrair(2,3);
        _calculadora.Multiplicar(3,4);
        _calculadora.Dividir(3,4);

        var lista = _calculadora.RetornoHistorico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}