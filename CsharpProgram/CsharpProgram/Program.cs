/* LEARNING C# SYNTAX
* CRAEATING A CLASS
* CREATING AN INSTANCE OF A CLASS
* WRITING TO CONSOLE
* READING FROM CONSOLE
* OPENING/CLOSING FILE
* WRITING/READING FROM/TO FILE
* USEFUL LIBARIES*/
using System;

namespace CsharpProgram
{
    //WITHIN SAME NAMESPACE CREATE ANOTHER CLASS:
    class SimpleClass
    {
        //MEMBERS:
        private String word = " ";//INIT TO SPACE

        //METHODS:
        public void Display(String x)
        {
            Console.WriteLine(x);
        }
        public String getWord()
        {
            return this.word;
        }
        public void setWord(String x)
        {
            this.word = x;
        }
    }
    class SimpleClass2 : SimpleClass//INHERITANCE SYNTAX
    {
        //MEMBERS:
        //NOTE THIS CLASS ALSO HAS ACCESS TO DISPLAY()
        protected String word2 = "Hello from the derived class";

        //METHODS:
        //NOTE THIS CLASS ALSO HAS ACCESS TO DISPLAY() FROM BASE CLASS
        public String getWord2()
        {
            return this.word2;
        }
        public void setWord2(String x)
        {
            this.word2 = x;
        }

    }
    //MAIN CLASS PREPOPULATED:
    class Program
    {
        static void Main(string[] args)
        {        
            //LOCAL VARIABLES:
            int userNum = 0;

            //INSTANCES: 
            SimpleClass handle = new SimpleClass();
            SimpleClass2 handle1 = new SimpleClass2();   

            //WRITE TO CONSOLE(W/CARRIAGE RETURN):
            Console.WriteLine("Hello World!");

            //WRITE TO CONSOLE(W/O CARRIAGE RETURN):
            Console.Write("Enter an interger: ");

            //USE OF CONVERT METHOD FOR CASTING:
            userNum = Convert.ToInt32(Console.ReadLine());//READLINE RETURNS A STRING
            Console.WriteLine("You entered: " + userNum);//CONCATENATION LIKE JAVA

            Console.WriteLine("Currently your string says:" + handle.getWord());//WORD FROM SimpleClass
            Console.Write("Enter a phrase then press enter: ");
            handle.setWord(Console.ReadLine());//STORE USER VALUE IN WORD FORM  SimpleClass
            Console.Write("Your string now says: ");

            //USING THE DEFINED CLASS METHODS TO PRINT WORD & WORD2
            handle.Display(handle.getWord());
            handle1.Display(handle1.getWord2());

        }
    }
}



