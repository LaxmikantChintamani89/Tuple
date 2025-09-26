using System.Diagnostics;
using System.Security.Principal;

//A Tuple in C# is a data structure that can hold a fixed number of elements,
//potentially of different data types, as a single object.




////Genreric Tuple class 

    Tuple<int, String> Obj1 = new Tuple<int, string>(1, "ABCD");

    //-----------OR---------
    var Obj2 = Tuple.Create(1, "ABCD");

    Debug.Print(Obj2.Item1.ToString()); // Output -->> 1
    Debug.Print(Obj2.Item2); // Output -->> ABCD

//*****************************************************************************************************//

////Value Tuple 

    var Obj33 = (2, "ABCD");

    Debug.Print(Obj33.Item1.ToString()); // Output -->> 2
    Debug.Print(Obj33.Item2); // Output -->> ABCD

//*****************************************************************************************************//

////Named Tuple

var Obj3 = (EmpID: 101, EmpName: "ABCD");

    Debug.Print(Obj3.EmpID.ToString() +"-"+ Obj3.EmpName);
        // Output -->> 101-ABCD

    Obj3.EmpID = 201;
    Obj3.EmpName = "FOCUS";

    Debug.Print(Obj3.EmpID.ToString() + "-" + Obj3.EmpName);
        // Output -->> 201-FOCUS