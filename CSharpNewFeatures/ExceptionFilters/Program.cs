using System;

namespace ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("Jalpesh");
            }

            //catch (Exception ex)
            //{
            //    if(ex.Message =="Jalpesh")
            //        Console.WriteLine("Exception with Message Jalpesh is executed");
            //    else
            //        Console.WriteLine("Exception with Message DotNetJalps executed");
            //}
            catch (Exception ex) if (ex.Message == "Jalpesh")
            {
                Console.WriteLine("Exception with Message Jalpesh is executed");
            }
            catch (Exception ex) if (ex.Message == "DotNetJalps")
            {
                Console.WriteLine("Exception with Message DotNetJalps executed");
            }
        }
    }
}
