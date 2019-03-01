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
        //HANDLE MEMBERS:
        private String word = " ";//INIT TO SPACE

        //HANDLE METHODS:
        public void Display()
        {
            Console.WriteLine(word);
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
    //MAIN CLASS PREPOPULATED:
    class Program
    {
        static void Main(string[] args)
        {
            //CREATED INSTANCE: 
            SimpleClass handle = new SimpleClass();

            //DECLARATION OF VARIABLE:
            int getNum = 0;

            //WRITE TO CONSOLE:
            Console.WriteLine("Hello World!");

            //USE OF CONVERT METHOD FOR CASTING:
            Console.WriteLine("Enter an interger: ");
            getNum = Convert.ToInt32(Console.ReadLine());//READLINE RETURNS A STRING
            Console.WriteLine("You entered: " + getNum);//CONCATENATION LIKE JAVA

            //CALLING METHOD IN HANDLE CLASS:
            Console.WriteLine("currently your string says:" + handle.getWord());
            Console.Write("enter a string: ");
            handle.setWord(Console.ReadLine());
            Console.Write("currently your string says: ");//WRITE -> NO CARRIAGE RETURN
            handle.Display();




        }
    }
}



