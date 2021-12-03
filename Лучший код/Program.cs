int[] R = new int[25];
Random Rand = new Random();
    Console.WriteLine("До:");
for(int i =0; i<R.Length; i++)
   {R[i] = Rand.Next(-9,9); Console.WriteLine("Эл массива {0}", R[i]);}
    Console.WriteLine("После:");
for(int i=0; i<R.Length; i++)
{
   if(R[i]<0)
      R[i]=i*i;
   else
      if(R[i]>0)
         R[i]=i+7;
 Console.WriteLine("Эл массива {0}", R[i]);
}