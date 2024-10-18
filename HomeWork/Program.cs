using HomeWork.Exceptions;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region first Exception :
            //first type :

            //throw new CapacityLimitException();                      

            //second type

            //try
            //{
            //    throw new CapacityLimitException("Error");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region second Exception :
            //first type :

            //throw new NotFoundException();

            //second type :

            //try
            //{
            //    throw new NotFoundException("Xeta bas verdi...");
            //}
            //catch (Exception exception)
            //{

            //    Console.WriteLine(exception.Message);
            //}
            #endregion

            #region third Exception :
            //first type :

            //throw new ProductCountIsZeroException();

            //second type :

            //try
            //{
            //    throw new ProductCountIsZeroException("Bu bir xeta mesajidir..");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region MainPart :
            Library libr = new Library(2);

            Book book1=new Book("lorem" ,50 , "kitab" , 10, 0);
            Book book2 = new Book("ipsum", 10, "defter", 20, 3);

            libr.AddBook(book1);
            libr.AddBook(book2);


            //ShowInfo metodunun islemesi:

            //foreach (var book in libr.Books)
            //{
            //    book.ShowInfo();
            //}


            //Limitin asilmasina numune :

            //Library libr = new Library(2);

            //Book book1=new Book("lorem" ,50 , "kitab" , 10, 0);
            //Book book2 = new Book("ipsum", 10, "defter", 20, 3);
            //Book book3 = new Book("ipsum", 10, "defter", 20, 3);

            //libr.AddBook(book1);
            //libr.AddBook(book2);
            //libr.AddBook(book3);

            ////ShowInfo metodunun islemesi:

            //foreach (var book in libr.Books)
            //{
            //    book.ShowInfo();
            //}


            //Sell metodunun islemesi :

            //try
            //{
            //    book1.Sell();
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            //RemoveById metodu :

            //libr.RemoveById(1);
            //foreach (var book in libr.Books)
            //{
            //    book.ShowInfo();
            //}




            #endregion
        }
    }
}
