// See https://aka.ms/new-console-template for more information
//using the Model layer;
using CosmoPatiro.Model;


//creating a list of type Modelcar class;
List<ModelCar> cars = new List<ModelCar>();
//creating an object of type  ModelCar class
ModelCar modelCar = new ModelCar(500,"Volvo");
//adding the object of type ModelCarClass
cars.Add(modelCar);
//creating an object of type  ModelCar class
modelCar = new ModelCar(400,"Ford");
//adding the object of type ModelCarClass
cars.Add(modelCar);
//creating an object of type  ModelCar class
modelCar = new ModelCar(200,"Dacia");
//adding the object of type ModelCarClass
cars.Add(modelCar);
//creating an object of type  ModelCar class
modelCar = new ModelCar(100,"BMW");
//adding the object of type ModelCarClass
cars.Add(modelCar);
//displaying the list of objects ModelCar
Console.WriteLine("This is a list with the name of the model and the Global Time Factor");
foreach (ModelCar i in cars)
{
    Console.WriteLine("Model="+i.Model+" and Local Time Factor="+i.LocalTimeFactor);
}
Console.WriteLine("Lets calculate the total cost for one of the models");
Console.WriteLine("In order to calculate the total cost you need to provide the model name, the time and the money");

Console.WriteLine("Please enter the time:");
//taking input from the user for the time atribute
string time = Console.ReadLine();
//converting the time atribute from string to double
double time1= Convert.ToDouble(time);
Console.WriteLine("Please enter the money");
//taking input from the user for the time atribute
string money = Console.ReadLine();
//converting the time atribute from string to double
double money1 = Convert.ToDouble(money);
Console.WriteLine("Please enter the model");
//taking input from the user for the time atribute
string model = Console.ReadLine();
//Displaying the input from the user
Console.WriteLine("Time:"+time+" Model:"+model+" Money:"+money);
//initiating the time factor variable 
double localTimeFactor1=0;

foreach (ModelCar i in cars)
{
    //checking if the entered input for model is equal with one of the models from the list
    if (model.Equals(i.Model))
    {
        //if the model is in the list , it checks if the model has a local factor
        if (i.LocalTimeFactor==0)
        {
            Console.WriteLine("The Local Time Factor is missing for this model so therefore the calculator will use the Global Time Factor");
            //if the local is 0 the calculator will use the global time factor
            localTimeFactor1=i.GlobalTimeFactor;
        }
        else
        {
            //if there is a present local time factor we will use the local time factor
            localTimeFactor1=i.LocalTimeFactor;
        }
        
            
    }
}
//Math.Round will round the totalCost
//the localtime factor is for 1 our and the time is in minutes 1 hour=60 minutes
double totalCost = Math.Round(time1*localTimeFactor1/60+money1);
//END OF THE TASK 1

//START OF TASK 2
double totalCost1 = time1*localTimeFactor1/60+money1;
//Displaying the result
Console.WriteLine("This is the total cost for default options:"+totalCost);
bool n = true;
//while n is true the program will continue to add custom costs. When the user will answer with No the program will stop
while (n)
{
    Console.WriteLine("You want to add custom cost? Yes/No");
    //getting input with No or Yes
    string answer = Console.ReadLine();
    if (answer.Equals("Yes"))
    {
        Console.WriteLine("How you want to be called the custom cost?");
        Console.WriteLine(" Risk or inconvinience?R/I or C for custom ammount");
        string answer1 = Console.ReadLine();
        //using the switch statement with to handle the 3 cases for Risk(R) Inconviniences(I) and Custom(C)
        switch (answer1)
        {
            case "R":
                Console.WriteLine("Please choose one of the values:\n" +
                    "Low=+10%\n"+
                    "Medium=30%\n"+
                    "High=+100%\n"+
                    "None=0%\n"
                    );
                string answer2 = Console.ReadLine();
                if (answer2.Equals("Low"))
                {
                    totalCost1=1.1*totalCost1;
                }
                else if (answer2.Equals("High"))
                {
                    totalCost1=2*totalCost1;

                }
                else if (answer2.Equals("Medium"))
                {
                    totalCost1 = 1.3*totalCost1;
                }
                else if (answer2.Equals("None"))
                {
                    //DO NOTHING :))))))

                }
                break;
            case "I":
                Console.WriteLine("Please choose one of the values:" +
                    "Low=+10%\n"+
                    "Medium=30%\n"+
                    "high=+100%\n"+
                    "None=0%\n"
                    );
                string answer3 = Console.ReadLine();
                if (answer3.Equals("Low"))
                {
                    totalCost1=1.1*totalCost1;
                }
                else if (answer3.Equals("High"))
                {
                    totalCost1=2*totalCost1;

                }
                else if (answer3.Equals("Medium"))
                {
                    totalCost1 = 1.3*totalCost1;
                }
                else if (answer3.Equals("None"))
                {
                    //DO NOTHING :))))))

                }
                break;
            case "C":
                Console.WriteLine("Please add the a specific %:");
                string answer4 = Console.ReadLine();
                int number = Convert.ToInt32(answer4);
                //If the user input is 0 there will be an error for the formula 100/0(Does not exists)
                if (number!=0)
                {
                    totalCost1=totalCost1*(100/number)+totalCost1;
                }
                break;
        }
        Console.WriteLine(Math.Round(totalCost1));
    }
    else
    {
        Console.WriteLine("Have a nice day!");
        //n is false and the loop ends
        n=false;
    }
}


