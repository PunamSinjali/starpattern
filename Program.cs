// for(int i=0;i<=5;i++)
// {
//     for(int j=0;j<=5;j++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine("");
// }

// string? star = "";
// for(int i=0;i<5;i++)
// {
//     for(int j=0;j<5;j++)
//     {
//         star +="*";
//     }
//     star +="\n";
// }
// Console.WriteLine(star);


// for(int i=0;i<5;i++)
// {
//     for(int j=0;j<5;j++)
//     {
//         if(i==0 || j==0 || i==4 || j==4)
//         {
//             Console.Write("*");
//         }
//         else
//         {
//            Console.Write("");
//         }
//     }
//     Console.WriteLine("");
// }


// for (int i = 1; i <= 5; i++)
// {
//     for (int j = 0; j < i; j++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine("");
// }

for(int i=1;i<=5; i++)
{
    for(int j=0;j<i;j++)
    {
        if(j==0|| j==i-1||i==5)
        {
            Console.Write("*");
        }
        else{
            Console.Write(" ");
        }
    }
    Console.WriteLine("");
}  

