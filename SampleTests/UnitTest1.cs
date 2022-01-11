using System;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace SampleTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var valueA = Environment.GetEnvironmentVariable("Test1");
        Assert.Equal("ABC", valueA);
    }
    
    [Fact]
    public void Test2()
    {
        var valueA = Environment.GetEnvironmentVariable("Test2");
        Assert.Equal("CBA", valueA);
    }
    
    [Fact]
    public void Test3()
    {
        var valueA = Environment.GetEnvironmentVariable("Test3");
        Assert.Equal("secret", valueA);
    }

    [Fact]
    public void Test4()
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .Build();
        
        Assert.Equal("ABC", config.GetValue<string>("Test1"));
        Assert.Equal("secret", config.GetValue<string>("Test4"));
    }
}