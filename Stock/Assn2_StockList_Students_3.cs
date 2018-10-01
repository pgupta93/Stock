using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param        : NA
    //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
    //return       : total value
    //return type  : decimal
    public decimal Value()
    {
      decimal value = 0.0m;
            StockNode current = this.head;
            

            for (current = this.head; current != null; current = current.Next)
            {
                value+=(current.StockHolding.Holdings)*(current.StockHolding.CurrentPrice);
            }

            
      // write your implementation here

      return value;
    }

    //param  (StockList) listToCompare     : StockList which has to comared for similarity index
    //summary      : finds the similar number of nodes between two lists
    //return       : similarty index
    //return type  : int
    public int Similarity(StockList listToCompare)
    {
      int similarityIndex = 0;
      StockNode current = this.head;
      StockNode current2 = listToCompare.head;
      for(current=this.head;current!=null; current = current.Next)
            {
                for (current2 = listToCompare.head; current2 != null; current2 = current2.Next)
                {
                    if(current.StockHolding.Symbol==current2.StockHolding.Symbol)
                    {
                        similarityIndex += 1;
                    }
                }

            }



            // write your implementation here

            return similarityIndex;
    }

    //param        : NA
    //summary      : Print all the nodes present in the list
    //return       : NA
    //return type  : NA
    public void Print()
    {
            // write your implementation here
            StockNode current = this.head;
            for (current = this.head; current!= null; current = current.Next)
            {
                Console.WriteLine(current.StockHolding.ToString());
            }

        }
    }
}