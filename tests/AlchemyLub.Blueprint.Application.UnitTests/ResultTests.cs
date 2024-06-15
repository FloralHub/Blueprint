namespace AlchemyLub.Blueprint.Application.UnitTests;

public class ResultTests
{
    [Fact]
    public void Result_Success_IsSuccessTrue()
    {
        Result result = Result.Success();

        Assert.True(result.IsSuccess);
    }

    [Fact]
    public void Result_Failure_IsSuccessFalse()
    {
        Result result = Result.Failure(new("Test error"));

        Assert.False(result.IsSuccess);
    }

    [Fact]
    public void Result_Failure_ErrorNotNull()
    {
        Result result = Result.Failure(new("Test error"));

        Assert.NotNull(result.Error);
    }

    [Fact]
    public void Result_Success_ErrorNull()
    {
        Result result = Result.Success();

        Assert.Null(result.Error);
    }

    [Fact]
    public void Result_AsTask_CompletesSuccessfully()
    {
        Result result = Result.Success();

        Task<Result> task = result.AsTask();

        Assert.True(task.IsCompletedSuccessfully);
    }

    [Fact]
    public void ResultT_Success_IsSuccessTrue()
    {
        Result<int> result = Result<int>.Success(42);

        Assert.True(result.IsSuccess);
    }

    [Fact]
    public void ResultT_Failure_IsSuccessFalse()
    {
        Result<int> result = Result<int>.Failure(new("Test error"));

        Assert.False(result.IsSuccess);
    }

    [Fact]
    public void ResultT_Failure_ErrorNotNull()
    {
        Result<int> result = Result<int>.Failure(new("Test error"));

        Assert.NotNull(result.Error);
    }

    [Fact]
    public void ResultT_Success_ErrorNull()
    {
        Result<int> result = Result<int>.Success(42);

        Assert.Null(result.Error);
    }

    [Fact]
    public void ResultT_Success_ValueNotNull()
    {
        Result<int> result = Result<int>.Success(42);

        Assert.NotNull(result.Value);
    }

    [Fact]
    public void ResultT_Failure_ValueNull()
    {
        Result<int> result = Result<int>.Failure(new("Test error"));

        Assert.Null(result.Value);
    }

    [Fact]
    public void ResultT_AsTask_CompletesSuccessfully()
    {
        Result<int> result = Result<int>.Success(42);

        Task<Result<int>> task = result.AsTask();

        Assert.True(task.IsCompletedSuccessfully);
    }
}