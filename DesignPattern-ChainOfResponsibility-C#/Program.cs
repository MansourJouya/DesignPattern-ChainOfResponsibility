using System;
using System.Collections.Generic;

/// <summary>
/// Abstract class defining the base for handlers in the chain of responsibility pattern.
/// </summary>
public abstract class Handler
{
    protected Handler NextHandler;

    /// <summary>
    /// Sets the next handler in the chain.
    /// </summary>
    /// <param name="nextHandler">The next handler in the chain.</param>
    public void SetNextHandler(Handler nextHandler)
    {
        NextHandler = nextHandler;
    }

    /// <summary>
    /// Abstract method to be implemented by concrete handlers to process the request.
    /// </summary>
    /// <param name="request">The request to be processed.</param>
    public abstract void HandleRequest(string request);
}

/// <summary>
/// Concrete handler for handling specific requests related to step 1.
/// </summary>
public class Step1Handler : Handler
{
    public override void HandleRequest(string request)
    {
        if (request == "Step1")
        {
            Console.WriteLine("Step 1 Handler: Processing request.");
        }
        else if (NextHandler != null)
        {
            NextHandler.HandleRequest(request);
        }
    }
}

/// <summary>
/// Concrete handler for handling specific requests related to step 2.
/// </summary>
public class Step2Handler : Handler
{
    public override void HandleRequest(string request)
    {
        if (request == "Step2")
        {
            Console.WriteLine("Step 2 Handler: Processing request.");
        }
        else if (NextHandler != null)
        {
            NextHandler.HandleRequest(request);
        }
    }
}

/// <summary>
/// Concrete handler for handling specific requests related to step 3.
/// </summary>
public class Step3Handler : Handler
{
    public override void HandleRequest(string request)
    {
        if (request == "Step3")
        {
            Console.WriteLine("Step 3 Handler: Processing request.");
        }
        else if (NextHandler != null)
        {
            NextHandler.HandleRequest(request);
        }
    }
}

/// <summary>
/// Client code that demonstrates the chain of responsibility pattern.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Create handlers
        Handler step1 = new Step1Handler();
        Handler step2 = new Step2Handler();
        Handler step3 = new Step3Handler();

        // Set up the chain
        step1.SetNextHandler(step2);
        step2.SetNextHandler(step3);

        // Test the chain with different requests
        Console.WriteLine("Processing Step1 request:");
        step1.HandleRequest("Step1");

        Console.WriteLine("\nProcessing Step2 request:");
        step1.HandleRequest("Step2");

        Console.WriteLine("\nProcessing Step3 request:");
        step1.HandleRequest("Step3");

        Console.WriteLine("\nProcessing unknown request:");
        step1.HandleRequest("Unknown");
    }
}
