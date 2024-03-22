# Lab 5 Exercise 5

## simple Method


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex05
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/83302624-0575-4583-a82b-2908b5bcdc78)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/e27d30ab-8d95-44b5-a3e4-744e08fc4e1a)

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex05
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/c0a78e31-1366-4dba-b6a2-c2997fbe2918)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/0f683f7a-0a0f-443a-a120-dd21e6c74c29)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex05
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/1060f572-c39a-4fae-99d2-7d36bb4a9ef5)


7. อธิบายสิ่งที่พบในการทดลอง


