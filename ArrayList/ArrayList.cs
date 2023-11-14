using System;
namespace ArrayList
{
    public class ArrayList<T>
    {
        private T[] feld;

   private int Capacity
   {
     set ;
    get;
   }

        public int Count { private set; get; }

        public ArrayList()
        {
            Capacity=1 ;
            feld=new T[Capacity];
            Count =0; // { }
        }

        private void Resize(int size)
        {      Capacity=Capacity*2;  
            T[] neu = new T[Capacity];
            for(int i=0; i<Count ; i++)
            {
                neu[i]=feld[i];
            }

            feld=neu;
           
            
        }

        public void Insert(int pos, T key)
        {   
            if(pos<0 || pos>Count )
            {
                throw new IndexOutOfRangeException();
            }
            if(pos==Capacity)
            {
                Resize(Capacity*2);
            }
            if(pos==Count )
            {
                Count++;
            }
           feld[pos]=key;
         }

        //b indexer this nwaliw nethaslo aal index ali hajti bik directement
        public T Get(int pos)
        {
         if(pos <0 || pos>Count  )
         {
            throw new IndexOutOfRangeException();

         }
        return feld[pos];
        }

        public void Add(T key)
        {
                Insert(Count,key);
        }

        public static ArrayList<T> operator +(ArrayList<T> left,ArrayList<T> right )
        {
            ArrayList<T> neu=new ArrayList<T>();
            for(int i=0; i<left.Count; i++)
            {
                //neu[i].Add(left[i]); GHALTA !!!
            neu.Add(left[i]);
            }
        
              for(int i=0; i<right.Count; i++) 
              {
                neu.Add(right[i]);
              }

    return neu;
        }
        public T this[int pos]//indexer
        {   
            get{
                return feld[pos];

            }
            set{

                feld[pos]=value;
            }

        }
     
}
}