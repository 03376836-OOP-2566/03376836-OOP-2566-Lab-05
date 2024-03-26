# Lab 5 Exercise 5

## simple Method


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex05
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var myObj = new MyClass();
myObj.Info();

class MyClass
{
    int F1;
    string F2;
    int F3 = 100;
    string F4 = "ASDF";

    public void Info()
    {
        System.Console.WriteLine($"Default integer      F1 = {F1}");  //Implicit fields initialization
        System.Console.WriteLine($"Default string       F2 = {F2}");

        System.Console.WriteLine($"Initialized integer  F3 = {F3}");  //Explicit field initialization
        System.Console.WriteLine($"Initialized string   F4 = {F4}");
    } 
}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex05
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-05/assets/144195611/699ba15c-4c0a-4dc9-bfb0-13a7abf2a466)


5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex05
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5 ![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-05/assets/144195611/508aa99d-8455-4e80-9460-fa9b79a15dcf)



7. อธิบายสิ่งที่พบในการทดลอง
- มีการสร้าง object ของclass MyClassและเรียกใช้ method Info() เพื่อแสดงผลลัพธ์การเข้าถึง field 

