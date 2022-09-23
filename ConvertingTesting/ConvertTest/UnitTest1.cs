using ConvertingTesting;
using NUnit.Framework;

namespace TestProject1;

public class Tests
{
    [Test]
    public void ConvertCmToIn()
    {
        //Arrange
        var convert = new Convert();

        //Act
        var convertedLength = convert.ConvertLengthTo(25.0, "i");
        const double expected = 9.84;

        //Assert
        Assert.AreEqual(expected.ToString("#.##"), convertedLength);
    }
    
    [Test]
    public void ConvertInToCm()
    {
        //Arrange
        var convert = new Convert();

        //Act
        var convertedLength = convert.ConvertLengthTo(25.0, "c");
        const double expected = 63.5;

        //Assert
        Assert.AreEqual(expected.ToString("#.##"), convertedLength);
    }

    [Test]
    public void ConvertKgToP()
    {
        //Arrange
        var convert = new Convert();

        //Act
        var convertedWeight = convert.ConvertWeightTo(25.0, "p");
        const double expected = 55.12;

        //Assert
        Assert.AreEqual(expected.ToString("#.##"), convertedWeight);
    }
    
    [Test]
    public void ConvertPtoKg()
    {
        //Arrange
        var convert = new Convert();

        //Act
        var convertedWeight = convert.ConvertWeightTo(25.0, "k");
        const double expected = 11.34;

        //Assert
        Assert.AreEqual(expected.ToString("#.##"), convertedWeight);
    }

    [Test]
    public void ConvertCtoK()
    {
        //Arrange
        var convert = new Convert();

        //Act
        var convertedTemp = convert.ConvertTemps(25.0, "c", "k");
        const double expected = 298.15;

        //Assert
        Assert.AreEqual(expected.ToString("#.##"), convertedTemp);
    }
    
    [Test]
    public void ConvertCtoF()
    {
        //Arrange
        var convert = new Convert();

        //Act
        var convertedTemp = convert.ConvertTemps(25.0, "c", "f");
        const double expected = 57;

        //Assert
        Assert.AreEqual(expected.ToString("#.##"), convertedTemp);
    }
    
    [Test]
    public void ConvertKtoC()
    {
        //Arrange
        var convert = new Convert();

        //Act
        var convertedTemp = convert.ConvertTemps(25.0, "k", "c");
        const double expected = -248.15;

        //Assert
        Assert.AreEqual(expected.ToString("#.##"), convertedTemp);
    }
    
    [Test]
    public void ConvertKtoF()
    {
        //Arrange
        var convert = new Convert();

        //Act
        var convertedTemp = convert.ConvertTemps(25.0, "k", "f");
        const double expected = -414.67;

        //Assert
        Assert.AreEqual(expected.ToString("#.##"), convertedTemp);
    }
    
    [Test]
    public void ConvertFtoC()
    {
        //Arrange
        var convert = new Convert();

        //Act
        var convertedTemp = convert.ConvertTemps(25.0, "f", "c");
        const double expected = -3.89;

        //Assert
        Assert.AreEqual(expected.ToString("#.##"), convertedTemp);
    }
    
    [Test]
    public void ConvertFtoK()
    {
        //Arrange
        var convert = new Convert();

        //Act
        var convertedTemp = convert.ConvertTemps(25.0, "f", "k");
        const double expected = 269.26;

        //Assert
        Assert.AreEqual(expected.ToString("#.##"), convertedTemp);
    }

    [Test] 
    public void ConvertGradesDKtoUS()
    {
        //Arrange
        var convert = new Convert();

        //Act
        var convertedGrade = convert.ConvertGradeTo("us", "10");
        const string expected = "A";

        //Assert
        Assert.AreEqual(expected, convertedGrade);
    }
    
    [Test] 
    public void ConvertGradesUStoDK()
    {
        //Arrange
        var convert = new Convert();

        //Act
        var convertedGrade = convert.ConvertGradeTo("dk", "A");
        const string expected = "10";

        //Assert
        Assert.AreEqual(expected, convertedGrade);
    }
    



}