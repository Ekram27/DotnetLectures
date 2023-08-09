// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using AnnonymousFunctionAndLambdaExpressionStudy;

Example objExample = new Example();
objExample.ObjMyDelegate.Invoke("Ekram");

objExample.ObjMyActionDelegate.Invoke("Action Delegate Called");
objExample.ObjMyActionLambda.Invoke("Action lambda called");