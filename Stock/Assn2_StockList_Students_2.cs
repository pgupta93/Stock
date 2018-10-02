using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public partial class StockList
    {
        //param   (StockList)listToMerge : second list to be merged 
        //summary      : merge two different list into a single result list
        //return       : merged list
        //return type  : StockList
        public StockList MergeList(StockList listToMerge)
        {
            StockList resultList = new StockList();

            // write your implementation here
            resultList = this;
            StockNode lastnode = resultList.head;
            StockNode current=this.head;
            StockNode check;
            for (check = listToMerge.head; check.Next != null; check = check.Next)
            {
                current = this.head;
                while (current.Next != null)
                {
                Stock currentStock = current.StockHolding;
                // found it! Return the node
                    if (currentStock.Symbol == check.StockHolding.Symbol)
                    {
                    currentStock.Holdings += check.StockHolding.Holdings;
                    break;
                    }
                    else
                    {
                    current = current.Next;
                    }
                    if (current.Next == null)
                    {
                        lastnode = this.head;
                        while (lastnode.Next != null)
                        {
                            lastnode = lastnode.Next;
                        }
                        lastnode.Next = check;
                    }
                }
            }
            
            return resultList;
        }
    
        //param        : NA
        //summary      : finds the stock with most number of holdings
        //return       : stock with most shares
        //return type  : Stock
        public Stock MostShares()
        {
            Stock mostShareStock = this.head.StockHolding;

            // write your implementation here
            StockNode current = null;

            for (current = this.head; current.Next != null; current = current.Next)
            {
                if (current.StockHolding.Holdings > mostShareStock.Holdings)
                {
                    mostShareStock = current.StockHolding;
                }
            }
            return mostShareStock;
        }

        //param        : NA
        //summary      : finds the number of nodes present in the list
        //return       : length of list
        //return type  : int
        public int Length()
        {
            int length = 0;

            // write your implementation here
            StockNode current;
            for (current = this.head; current.Next != null; current = current.Next)
            {
                length += 1;
            }

            return (length + 1);
        }
    }
}
